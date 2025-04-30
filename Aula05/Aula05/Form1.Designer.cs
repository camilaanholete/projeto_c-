namespace Aula05
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
            txtNome = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            cboEstado = new ComboBox();
            btVerificar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(98, 82);
            label1.Name = "label1";
            label1.Size = new Size(168, 27);
            label1.TabIndex = 0;
            label1.Text = "Digite o seu Nome:";
            label1.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(413, 82);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(245, 38);
            txtNome.TabIndex = 1;
            txtNome.KeyPress += txtNome_KeyPress;
            txtNome.Leave += txtNome_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(98, 177);
            label2.Name = "label2";
            label2.Size = new Size(171, 27);
            label2.TabIndex = 2;
            label2.Text = "Digite o seu E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(413, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 38);
            txtEmail.TabIndex = 3;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(98, 266);
            label3.Name = "label3";
            label3.Size = new Size(202, 27);
            label3.TabIndex = 4;
            label3.Text = "Escolha o Estado (UF):";
            label3.Click += label3_Click;
            // 
            // cboEstado
            // 
            cboEstado.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "SÃO PAULO", "MINAS GERAIS", "RIO DE JANEIRO", "ESPIRITO SANTO" });
            cboEstado.Location = new Point(413, 258);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(245, 32);
            cboEstado.TabIndex = 5;
            cboEstado.KeyPress += cboEstado_KeyPress;
            // 
            // btVerificar
            // 
            btVerificar.BackColor = SystemColors.GrayText;
            btVerificar.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btVerificar.ForeColor = SystemColors.ButtonHighlight;
            btVerificar.Location = new Point(413, 379);
            btVerificar.Name = "btVerificar";
            btVerificar.Size = new Size(111, 37);
            btVerificar.TabIndex = 6;
            btVerificar.Text = "Verificar Dados";
            btVerificar.UseVisualStyleBackColor = false;
            btVerificar.Click += btVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btVerificar);
            Controls.Add(cboEstado);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private ComboBox cboEstado;
        private Button btVerificar;
    }
}
