namespace Aula06
{
    public partial class Form1 : Form
    {
        public float n1 = 0, n2 = 0, res = 0;
        public string operacao = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "2";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "1";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + "0";
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(txtRes.Text);
            txtRes.Text = "0";
            operacao = "+";

        }

        private void btSub_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(txtRes.Text);
            txtRes.Text = "0";
            operacao = "-";
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(txtRes.Text);
            txtRes.Text = "0";
            operacao = "*";
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            n1 = float.Parse(txtRes.Text);
            txtRes.Text = "0";
            operacao = "/";
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            res = 0;
            operacao = "";
            txtRes.Text = "0";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            n2 = float.Parse(txtRes.Text);
            if (operacao == "+") {res = n1 + n2; }
            if (operacao == "-") {res = n1 - n2; }
            if (operacao == "*") {res = n1 / n2; }
            if (operacao == "/") { res = n1 / n2; }
            txtRes.Text = res.ToString();
        }
    }
}
