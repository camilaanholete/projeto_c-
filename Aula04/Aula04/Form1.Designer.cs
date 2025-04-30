namespace Aula04
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
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            textRes = new TextBox();
            btSomar = new Button();
            btSubtrair = new Button();
            btMultiplicar = new Button();
            btDividir = new Button();
            btRaiz = new Button();
            btPotencia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Papyrus", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(332, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 64);
            label1.TabIndex = 0;
            label1.Text = "Calculadora";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Papyrus", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 109);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 1;
            label2.Text = "Digite um Número:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Papyrus", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 177);
            label3.Name = "label3";
            label3.Size = new Size(231, 37);
            label3.TabIndex = 2;
            label3.Text = "Digite outro Número:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Papyrus", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 286);
            label4.Name = "label4";
            label4.Size = new Size(126, 37);
            label4.TabIndex = 3;
            label4.Text = "Resultado:";
            // 
            // txtN1
            // 
            txtN1.Font = new Font("Papyrus", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtN1.Location = new Point(353, 109);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(179, 44);
            txtN1.TabIndex = 4;
            txtN1.KeyPress += txtN1_KeyPress;
            // 
            // txtN2
            // 
            txtN2.Font = new Font("Papyrus", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtN2.Location = new Point(353, 177);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(179, 44);
            txtN2.TabIndex = 5;
            // 
            // textRes
            // 
            textRes.BackColor = Color.Tomato;
            textRes.Enabled = false;
            textRes.Font = new Font("Papyrus", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textRes.Location = new Point(353, 283);
            textRes.Name = "textRes";
            textRes.Size = new Size(179, 44);
            textRes.TabIndex = 6;
            textRes.TextChanged += textRes_TextChanged;
            // 
            // btSomar
            // 
            btSomar.BackColor = SystemColors.GrayText;
            btSomar.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSomar.ForeColor = SystemColors.Control;
            btSomar.Location = new Point(681, 108);
            btSomar.Name = "btSomar";
            btSomar.Size = new Size(215, 39);
            btSomar.TabIndex = 7;
            btSomar.Text = "SOMAR";
            btSomar.UseVisualStyleBackColor = false;
            btSomar.Click += btSomar_Click;
            // 
            // btSubtrair
            // 
            btSubtrair.BackColor = SystemColors.GrayText;
            btSubtrair.DialogResult = DialogResult.Cancel;
            btSubtrair.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubtrair.ForeColor = SystemColors.ButtonHighlight;
            btSubtrair.Location = new Point(681, 162);
            btSubtrair.Name = "btSubtrair";
            btSubtrair.Size = new Size(215, 39);
            btSubtrair.TabIndex = 8;
            btSubtrair.Text = "SUBTRAIR";
            btSubtrair.UseVisualStyleBackColor = false;
            btSubtrair.Click += btSubtrair_Click;
            // 
            // btMultiplicar
            // 
            btMultiplicar.BackColor = SystemColors.GrayText;
            btMultiplicar.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btMultiplicar.ForeColor = SystemColors.ButtonHighlight;
            btMultiplicar.Location = new Point(681, 216);
            btMultiplicar.Name = "btMultiplicar";
            btMultiplicar.Size = new Size(215, 39);
            btMultiplicar.TabIndex = 8;
            btMultiplicar.Text = "MULTIPLICAR";
            btMultiplicar.UseVisualStyleBackColor = false;
            btMultiplicar.Click += btMultiplicar_Click;
            // 
            // btDividir
            // 
            btDividir.BackColor = SystemColors.GrayText;
            btDividir.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDividir.ForeColor = SystemColors.ButtonHighlight;
            btDividir.Location = new Point(681, 272);
            btDividir.Name = "btDividir";
            btDividir.Size = new Size(215, 39);
            btDividir.TabIndex = 8;
            btDividir.Text = "DIVIDIR";
            btDividir.UseVisualStyleBackColor = false;
            btDividir.Click += btDividir_Click;
            // 
            // btRaiz
            // 
            btRaiz.BackColor = SystemColors.ControlDarkDark;
            btRaiz.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRaiz.ForeColor = SystemColors.ButtonHighlight;
            btRaiz.Location = new Point(681, 377);
            btRaiz.Name = "btRaiz";
            btRaiz.Size = new Size(215, 38);
            btRaiz.TabIndex = 9;
            btRaiz.Text = "RAIZ QUADRADA";
            btRaiz.UseVisualStyleBackColor = false;
            btRaiz.Click += btRaiz_Click;
            // 
            // btPotencia
            // 
            btPotencia.BackColor = SystemColors.ControlDarkDark;
            btPotencia.Font = new Font("Papyrus", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btPotencia.ForeColor = SystemColors.ButtonHighlight;
            btPotencia.Location = new Point(681, 329);
            btPotencia.Name = "btPotencia";
            btPotencia.Size = new Size(215, 31);
            btPotencia.TabIndex = 9;
            btPotencia.Text = "POTÊNCIA";
            btPotencia.UseMnemonic = false;
            btPotencia.UseVisualStyleBackColor = false;
            btPotencia.Click += btPotencia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 608);
            Controls.Add(btPotencia);
            Controls.Add(btRaiz);
            Controls.Add(btDividir);
            Controls.Add(btMultiplicar);
            Controls.Add(btSubtrair);
            Controls.Add(btSomar);
            Controls.Add(textRes);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox textRes;
        private Button btSomar;
        private Button btSubtrair;
        private Button btMultiplicar;
        private Button btDividir;
        private Button btRaiz;
        private Button btPotencia;
    }
}
