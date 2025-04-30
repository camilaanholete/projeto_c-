using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System.Data;
using System.Linq.Expressions;

namespace Aula_CRUD
{
    public partial class Form1 : Form
    {
        public MySqlConnection conexao;
        public string fotoEndereco = string.Empty;
        

        public Form1()
        {
            InitializeComponent();
            btSalvar.Enabled = false;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (btNovo.Text == "Novo")
            {
                btSalvar.Enabled = true;
                txtCodigo.Enabled = false;
                btNovo.Text = "Cancelar";

            }
            else
            {
                btSalvar.Enabled = false;
                txtCodigo.Enabled = true;
                btNovo.Text = "Novo";
                txtCodigo.Focus();
            }
            LimparDados();
            btAlterar.Enabled = false;
            btExcluir.Enabled = false;


        }
        public void LimparDados()
        {
            txtxNome.Text = "";
            txtxNome.Text = "";
            txtEmail.Text = "";
            Imagem.Image = null;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtxNome.Text.ToUpper().Trim();
                string email = txtEmail.Text.ToUpper().Trim();

                conexao = Banco.Conexao.getConexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO funcionarios (nome, email, status, imagem )" +
                    " VALUES (@nome, @email, @status, @imagem)";

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@status", true);
                if (fotoEndereco == "")
                {
                    comando.Parameters.AddWithValue("@imagem", null);
                }
                else
                {
                    comando.Parameters.AddWithValue("imagem", ConverteImagemToByte());
                }

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados gravados com Sucesso!", "Atenção");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar gravar dados! \n" + ex.Message);
            }
            finally
            {
                conexao.Close();
                btNovo.Text = "Novo";
                btSalvar.Enabled = false;
                LimparDados();
                ConsultarTodos();
            }

        }

        public byte[] ConverteImagemToByte()
        {
            byte[] imagemByte = null;

            FileStream fs = new FileStream(fotoEndereco, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            imagemByte = br.ReadBytes((int)fs.Length);
            return imagemByte;
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Enabled == false)
            {
                txtCodigo.Enabled = true;
                btNovo.Text = "Novo";
                btSalvar.Enabled = false;
                txtCodigo.Focus();
            }
            else
            {
                try
                {
                    int codigo = Convert.ToInt16(txtCodigo.Text);
                    ConsultarCodigo(codigo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Digite um número válido!", "Atenção");
                }

            }
        }

        private void ConsultarCodigo(int codigo)
        {
            try
            {
                conexao = Banco.Conexao.getConexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = " SELECT * FROM funcionarios " +
                    " WHERE status = true and codigo = @codigo";

                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Prepare();

                MySqlDataReader dados = comando.ExecuteReader();

                if (dados.Read())
                {
                    txtCodigo.Text = dados["codigo"].ToString();
                    txtxNome.Text = dados["nome"].ToString();
                    txtEmail.Text = dados["email"].ToString();
                    btAlterar.Enabled = true;
                    btExcluir.Enabled = true;
                    if (dados["imagem"] != DBNull.Value)
                    {
                        Imagem.Image = ConverteByteToImagem((byte[])dados["imagem"]);
                    }
                    else
                    {
                        Imagem.Image = null;
                    }

                }
                else
                {
                    MessageBox.Show("O código não foi localizado", "Atenção");
                    LimparDados();
                    btAlterar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar : \n" + ex.Message);
                LimparDados();

            }
            finally
            {
                conexao.Close();
            }

        }

        public Image ConverteByteToImagem(byte[] imgBytes)
        {
            MemoryStream ms = new MemoryStream(imgBytes);
            return Image.FromStream(ms);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConsultarTodos();
        }

        private void ConsultarTodos()
        {
            try
            {
                conexao = Banco.Conexao.getConexao();
                conexao.Open();

                string sql = "Select * from funcionarios where status = true";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);

                da.Fill(dt);
                dgvFuncionarios.DataSource = dt;
            }
            catch (Exception ex)
            {

            }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt16(txtCodigo.Text);
                string nome = txtxNome.Text.ToUpper();
                string email = txtEmail.Text.ToUpper();

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || txtCodigo.Text.Length == 0)
                {
                    MessageBox.Show("Preencha os campos corretamente para a alteração", "Atenção ");
                }

                conexao = Banco.Conexao.getConexao();
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                comando.CommandText = "UPDATE funcionarios SET nome=@nome, email=@email," +
                    "imagem=@imagem WHERE codigo=@codigo";

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("codigo", codigo);
                if(fotoEndereco == "")
                {
                    comando.Parameters.AddWithValue("@imagem", null);
                }
                else
                {
                    comando.Parameters.AddWithValue("@imagem", ConverteImagemToByte());
                }

                comando.Prepare();
                comando.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com Sucesso!", "Atenção");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar os dados! \n" + ex.Message, "Atenção");
            }
            finally
            {
                conexao.Close();
                LimparDados();
                ConsultarTodos();
                btAlterar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        private void dgvFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int linha = e.RowIndex;

                DataGridViewRow selecao = dgvFuncionarios.Rows[linha];
                int codigo = Convert.ToInt16(selecao.Cells[0].Value);

                ConsultarCodigo(codigo);

            }
            catch (Exception ex) { }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    int codigo = Convert.ToInt16(txtCodigo.Text);

                    conexao = Banco.Conexao.getConexao();
                    conexao.Open();

                    MySqlCommand comando = new MySqlCommand();
                    comando.Connection = conexao;
                    comando.CommandText = "UPDATE funcionarios SET status = false " +
                                           " WHERE codigo = @codigo";

                    comando.Parameters.AddWithValue("@codigo", codigo);

                    comando.Prepare();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Registo excluído com sucesso", "Atenção");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar excluir! \n" + ex.Message, "Atenção");
                }

                finally
                {
                    conexao.Close();
                    LimparDados();
                    btAlterar.Enabled = false;
                    btExcluir.Enabled = false;
                }

            }
        }

        private void btBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog janela = new OpenFileDialog();
            janela.Filter = "Imagens (*.jpg; *png) | *.jpg; *.png ";
            if(janela.ShowDialog() == DialogResult.OK)
            {
                fotoEndereco = janela.FileName.ToString();
                Imagem.ImageLocation = fotoEndereco;

            }
        }
    }
}
