namespace Aula04
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSomar_Click(object sender, EventArgs e)
        {
            // criar as variaves
            float n1, n2, res = 0;

            // atribuindo o valor digitado para a variavel convertido para numero

            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            // processamento - somar
            res = n1 + n2;

            //exibir o resultado no objeto texto

            textRes.Text = res.ToString();

        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            // criar as variaves
            float n1, n2, res = 0;

            // atribuindo o valor digitado para a variavel convertido para numero

            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            // processamento - subtrair
            res = n1 - n2;

            //exibir o resultado no objeto texto

            textRes.Text = res.ToString();


        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            // criar as variaves
            float n1, n2, res = 0;

            // atribuindo o valor digitado para a variavel convertido para numero

            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            // processamento - multiplicar
            res = n1 * n2;

            //exibir o resultado no objeto texto

            textRes.Text = res.ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            // criar as variaves
            float n1, n2, res = 0;

            // atribuindo o valor digitado para a variavel convertido para numero

            n1 = float.Parse(txtN1.Text);
            n2 = float.Parse(txtN2.Text);

            // processamento - dividir
            res = n1 / n2;

            //exibir o resultado no objeto texto

            textRes.Text = res.ToString();
        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // Tabela ASCII

            {
                MessageBox.Show("Você clicou na tecla Enter", "Atenção");
            }
        }

        private void btPotencia_Click(object sender, EventArgs e)
        {
            double n1, n2, res = 0;

            // atribuindo o valor digitado para a variavel convertido para numero

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);

            // processamento - potencia

            res = Math.Pow(n1, n2);


            //exibir o resultado no objeto texto

            textRes.Text = res.ToString();

        }

        private void btRaiz_Click(object sender, EventArgs e)
        {
            double n1, res = 0;

            // atribuindo o valor digitado para a variavel convertido para numero

            n1 = double.Parse(txtN1.Text);
            

            // processamento - raiz quadrada

            res = Math.Sqrt(n1);


            //exibir o resultado no objeto texto

            textRes.Text = res.ToString();
        }
    }
}
