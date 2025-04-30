namespace Aula05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btVerificar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0) // se qtd de caracteres digitados == 0
            {
                MessageBox.Show("Preencha o campo Nome corretamente", "Atenção");
                txtNome.BackColor = Color.Yellow;
                txtNome.Focus();
            }
            else // se o campo nome foi preenchido
            {
                if (txtEmail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha o campo Email corretamente", "Atenção");
                    txtEmail.BackColor = Color.Yellow;
                    txtEmail.Focus();
                }
                else
                {
                    if (cboEstado.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Preencha o campo Estado corretamente", "Atenção");
                        cboEstado.BackColor = Color.Yellow;
                        cboEstado.Focus();
                    }
                    else
                    {
                        //todos os campos foram preenchidos
                        txtNome.BackColor = Color.White;
                        txtEmail.BackColor = Color.White;
                        cboEstado.BackColor = Color.White;
                        MessageBox.Show("Parabéns!", "Atenção");
                    }
                }
            }

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // se tecla entrer foi pressionada
            if (e.KeyChar == 13)
            {
                if (txtNome.Text.Trim().Length == 0)
                {
                    MessageBox.Show("O campo Nome não foi preenchido", "Atenção");
                    txtNome.BackColor = Color.Yellow;
                }
                else
                {
                    txtNome.BackColor = Color.White;
                    txtEmail.Focus();

                }

            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // se tecla entrer foi pressionada
            if (e.KeyChar == 13)
            {
                if (txtEmail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("O campo E-mail não foi preenchido", "Atenção");
                    txtNome.BackColor = Color.Yellow;
                }
                else
                {
                    txtEmail.BackColor = Color.White;
                    cboEstado.Focus();

                }

            }
        }

        private void cboEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // se tecla entrer foi pressionada
            if (e.KeyChar == 13)
            {
                if (cboEstado.Text.Trim().Length == 0)
                {
                    MessageBox.Show("O campo Estado não foi preenchido", "Atenção");
                    cboEstado.BackColor = Color.Yellow;
                }
                else
                {
                    cboEstado.BackColor = Color.White;
                    btVerificar.Focus();

                }

            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo Nome não foi preenchido", "Atenção");
                txtNome.BackColor = Color.Yellow;
            }

        }
    }
}
