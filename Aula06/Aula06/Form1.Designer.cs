namespace Aula06
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
            txtRes = new TextBox();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btSoma = new Button();
            btSub = new Button();
            bt6 = new Button();
            bt5 = new Button();
            bt4 = new Button();
            btMult = new Button();
            bt9 = new Button();
            bt8 = new Button();
            bt7 = new Button();
            btDiv = new Button();
            btIgual = new Button();
            btLimpar = new Button();
            bt0 = new Button();
            SuspendLayout();
            // 
            // txtRes
            // 
            txtRes.BackColor = Color.RosyBrown;
            txtRes.Location = new Point(42, 52);
            txtRes.Name = "txtRes";
            txtRes.Size = new Size(604, 38);
            txtRes.TabIndex = 0;
            txtRes.Text = "0";
            txtRes.TextAlign = HorizontalAlignment.Right;
            // 
            // bt1
            // 
            bt1.BackColor = Color.RosyBrown;
            bt1.Location = new Point(42, 131);
            bt1.Name = "bt1";
            bt1.Size = new Size(132, 46);
            bt1.TabIndex = 1;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.BackColor = Color.RosyBrown;
            bt2.Location = new Point(189, 131);
            bt2.Name = "bt2";
            bt2.Size = new Size(136, 46);
            bt2.TabIndex = 2;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = false;
            bt2.Click += button2_Click;
            // 
            // bt3
            // 
            bt3.BackColor = Color.RosyBrown;
            bt3.Location = new Point(345, 131);
            bt3.Name = "bt3";
            bt3.Size = new Size(136, 46);
            bt3.TabIndex = 3;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = false;
            bt3.Click += bt3_Click;
            // 
            // btSoma
            // 
            btSoma.BackColor = Color.Tomato;
            btSoma.Location = new Point(504, 131);
            btSoma.Name = "btSoma";
            btSoma.Size = new Size(132, 46);
            btSoma.TabIndex = 4;
            btSoma.Text = "+";
            btSoma.UseVisualStyleBackColor = false;
            btSoma.Click += btSoma_Click;
            // 
            // btSub
            // 
            btSub.BackColor = Color.Tomato;
            btSub.Location = new Point(504, 208);
            btSub.Name = "btSub";
            btSub.Size = new Size(132, 46);
            btSub.TabIndex = 8;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = false;
            btSub.Click += btSub_Click;
            // 
            // bt6
            // 
            bt6.BackColor = Color.RosyBrown;
            bt6.Location = new Point(345, 208);
            bt6.Name = "bt6";
            bt6.Size = new Size(136, 46);
            bt6.TabIndex = 7;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = false;
            bt6.Click += bt6_Click;
            // 
            // bt5
            // 
            bt5.BackColor = Color.RosyBrown;
            bt5.Location = new Point(189, 208);
            bt5.Name = "bt5";
            bt5.Size = new Size(136, 46);
            bt5.TabIndex = 6;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = false;
            bt5.Click += bt5_Click;
            // 
            // bt4
            // 
            bt4.BackColor = Color.RosyBrown;
            bt4.Location = new Point(42, 208);
            bt4.Name = "bt4";
            bt4.Size = new Size(132, 46);
            bt4.TabIndex = 5;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = false;
            bt4.Click += bt4_Click;
            // 
            // btMult
            // 
            btMult.BackColor = Color.Tomato;
            btMult.Location = new Point(504, 284);
            btMult.Name = "btMult";
            btMult.Size = new Size(132, 46);
            btMult.TabIndex = 12;
            btMult.Text = "*";
            btMult.UseVisualStyleBackColor = false;
            btMult.Click += btMult_Click;
            // 
            // bt9
            // 
            bt9.BackColor = Color.RosyBrown;
            bt9.Location = new Point(345, 284);
            bt9.Name = "bt9";
            bt9.Size = new Size(136, 46);
            bt9.TabIndex = 11;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = false;
            bt9.Click += bt9_Click;
            // 
            // bt8
            // 
            bt8.BackColor = Color.RosyBrown;
            bt8.Location = new Point(189, 284);
            bt8.Name = "bt8";
            bt8.Size = new Size(136, 46);
            bt8.TabIndex = 10;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = false;
            bt8.Click += bt8_Click;
            // 
            // bt7
            // 
            bt7.BackColor = Color.RosyBrown;
            bt7.Location = new Point(42, 284);
            bt7.Name = "bt7";
            bt7.Size = new Size(132, 46);
            bt7.TabIndex = 9;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = false;
            bt7.Click += bt7_Click;
            // 
            // btDiv
            // 
            btDiv.BackColor = Color.Tomato;
            btDiv.Location = new Point(504, 367);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(132, 46);
            btDiv.TabIndex = 16;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = false;
            btDiv.Click += btDiv_Click;
            // 
            // btIgual
            // 
            btIgual.BackColor = Color.Tomato;
            btIgual.Location = new Point(345, 367);
            btIgual.Name = "btIgual";
            btIgual.Size = new Size(136, 46);
            btIgual.TabIndex = 15;
            btIgual.Text = "=";
            btIgual.UseVisualStyleBackColor = false;
            btIgual.Click += btIgual_Click;
            // 
            // btLimpar
            // 
            btLimpar.BackColor = Color.Tomato;
            btLimpar.Location = new Point(189, 367);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(136, 46);
            btLimpar.TabIndex = 14;
            btLimpar.Text = "C";
            btLimpar.UseVisualStyleBackColor = false;
            btLimpar.Click += btLimpar_Click;
            // 
            // bt0
            // 
            bt0.BackColor = Color.RosyBrown;
            bt0.Location = new Point(42, 367);
            bt0.Name = "bt0";
            bt0.Size = new Size(132, 46);
            bt0.TabIndex = 13;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = false;
            bt0.Click += bt0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(712, 459);
            Controls.Add(btDiv);
            Controls.Add(btIgual);
            Controls.Add(btLimpar);
            Controls.Add(bt0);
            Controls.Add(btMult);
            Controls.Add(bt9);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(btSub);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(btSoma);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(txtRes);
            Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRes;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btSoma;
        private Button btSub;
        private Button bt6;
        private Button bt5;
        private Button bt4;
        private Button btMult;
        private Button bt9;
        private Button bt8;
        private Button bt7;
        private Button btDiv;
        private Button btIgual;
        private Button btLimpar;
        private Button bt0;
    }
}
