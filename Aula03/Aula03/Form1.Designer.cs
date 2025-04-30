namespace Aula03
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
            btMensagem = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btMensagem
            // 
            btMensagem.BackColor = Color.FromArgb(255, 128, 128);
            btMensagem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btMensagem.Location = new Point(557, 272);
            btMensagem.Name = "btMensagem";
            btMensagem.Size = new Size(133, 56);
            btMensagem.TabIndex = 0;
            btMensagem.Text = "Mensagem";
            btMensagem.UseVisualStyleBackColor = false;
            btMensagem.Click += btMensagem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 50);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 1;
            label1.Text = "Digite seu Nome:";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.InactiveBorder;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(92, 94);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(485, 34);
            txtNome.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btMensagem);
            Name = "Form1";
            Text = "Aula 03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btMensagem;
        private Label label1;
        private TextBox txtNome;
    }
}
