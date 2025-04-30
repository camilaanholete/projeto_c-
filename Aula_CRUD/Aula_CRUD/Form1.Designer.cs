namespace Aula_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            txtxNome = new TextBox();
            txtEmail = new TextBox();
            groupBox1 = new GroupBox();
            btExcluir = new Button();
            btAlterar = new Button();
            btSalvar = new Button();
            btNovo = new Button();
            btConsultar = new Button();
            dgvFuncionarios = new DataGridView();
            btBuscarFoto = new Button();
            Imagem = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Imagem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe Print", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(202, 9);
            label1.Name = "label1";
            label1.Size = new Size(472, 61);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Funcionários ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(8, 106);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(9, 164);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(8, 229);
            label4.Name = "label4";
            label4.Size = new Size(77, 28);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(111, 100);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(160, 34);
            txtCodigo.TabIndex = 4;
            // 
            // txtxNome
            // 
            txtxNome.Location = new Point(111, 158);
            txtxNome.Name = "txtxNome";
            txtxNome.Size = new Size(482, 34);
            txtxNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(482, 34);
            txtEmail.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btExcluir);
            groupBox1.Controls.Add(btAlterar);
            groupBox1.Controls.Add(btSalvar);
            groupBox1.Controls.Add(btNovo);
            groupBox1.Location = new Point(811, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 184);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btExcluir
            // 
            btExcluir.BackColor = SystemColors.ActiveCaptionText;
            btExcluir.Enabled = false;
            btExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btExcluir.ForeColor = SystemColors.ActiveCaption;
            btExcluir.Location = new Point(169, 118);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(119, 50);
            btExcluir.TabIndex = 11;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = false;
            btExcluir.Click += btExcluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.BackColor = SystemColors.ActiveCaptionText;
            btAlterar.Enabled = false;
            btAlterar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAlterar.ForeColor = SystemColors.ActiveCaption;
            btAlterar.Location = new Point(169, 33);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(119, 54);
            btAlterar.TabIndex = 10;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = false;
            btAlterar.Click += btAlterar_Click;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = SystemColors.ActiveCaptionText;
            btSalvar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.ForeColor = SystemColors.ActiveCaption;
            btSalvar.Location = new Point(18, 114);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(119, 54);
            btSalvar.TabIndex = 9;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // btNovo
            // 
            btNovo.BackColor = SystemColors.ControlText;
            btNovo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNovo.ForeColor = SystemColors.ActiveCaption;
            btNovo.Location = new Point(18, 33);
            btNovo.Name = "btNovo";
            btNovo.Size = new Size(119, 52);
            btNovo.TabIndex = 8;
            btNovo.Text = "Novo";
            btNovo.UseVisualStyleBackColor = false;
            btNovo.Click += btNovo_Click;
            // 
            // btConsultar
            // 
            btConsultar.Image = Properties.Resources.pesquisar_png;
            btConsultar.Location = new Point(289, 95);
            btConsultar.Name = "btConsultar";
            btConsultar.Size = new Size(48, 44);
            btConsultar.TabIndex = 8;
            btConsultar.UseVisualStyleBackColor = true;
            btConsultar.Click += btConsultar_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Location = new Point(29, 325);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.RowHeadersWidth = 51;
            dgvFuncionarios.Size = new Size(1027, 176);
            dgvFuncionarios.TabIndex = 9;
            dgvFuncionarios.CellClick += dgvFuncionarios_CellClick;
            // 
            // btBuscarFoto
            // 
            btBuscarFoto.BackColor = SystemColors.ActiveCaptionText;
            btBuscarFoto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBuscarFoto.ForeColor = SystemColors.ActiveCaption;
            btBuscarFoto.Location = new Point(384, 95);
            btBuscarFoto.Name = "btBuscarFoto";
            btBuscarFoto.Size = new Size(138, 50);
            btBuscarFoto.TabIndex = 10;
            btBuscarFoto.Text = "Buscar Foto";
            btBuscarFoto.UseVisualStyleBackColor = false;
            btBuscarFoto.Click += btBuscarFoto_Click;
            // 
            // Imagem
            // 
            Imagem.Location = new Point(616, 85);
            Imagem.Name = "Imagem";
            Imagem.Size = new Size(171, 172);
            Imagem.TabIndex = 11;
            Imagem.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 554);
            Controls.Add(Imagem);
            Controls.Add(btBuscarFoto);
            Controls.Add(dgvFuncionarios);
            Controls.Add(btConsultar);
            Controls.Add(groupBox1);
            Controls.Add(txtEmail);
            Controls.Add(txtxNome);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Cadastro de Funcionários";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)Imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox txtxNome;
        private TextBox txtEmail;
        private GroupBox groupBox1;
        private Button btNovo;
        private Button btSalvar;
        private Button btConsultar;
        private DataGridView dgvFuncionarios;
        private Button btAlterar;
        private Button btExcluir;
        private Button btBuscarFoto;
        private PictureBox Imagem;
    }
}
