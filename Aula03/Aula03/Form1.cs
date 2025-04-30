namespace Aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMensagem_Click(object sender, EventArgs e)
        {
            //criando uma variavel
            string nome;
            //atribuir um valor para a variavel nome
            nome = txtNome.Text.Trim().ToLower();
            //exibir a mensagem
            MessageBox.Show("Boa Noite " + nome, "Sucesso");
        }
    }
}
