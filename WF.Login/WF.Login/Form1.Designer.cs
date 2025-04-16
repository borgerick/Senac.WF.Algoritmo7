namespace WF.Login
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            button1 = new Button();
            RecuperarSenha = new LinkLabel();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 556);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._747;
            pictureBox1.Location = new Point(0, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(255, 128, 0);
            textBox2.Location = new Point(492, 236);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 49);
            textBox2.TabIndex = 2;
            textBox2.Text = "SENHA";
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(492, 339);
            button1.Name = "button1";
            button1.Size = new Size(334, 62);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // RecuperarSenha
            // 
            RecuperarSenha.AutoSize = true;
            RecuperarSenha.Location = new Point(581, 404);
            RecuperarSenha.Name = "RecuperarSenha";
            RecuperarSenha.Size = new Size(161, 25);
            RecuperarSenha.TabIndex = 0;
            RecuperarSenha.TabStop = true;
            RecuperarSenha.Text = "Esqueceu a Senha?";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 128, 0);
            textBox1.Location = new Point(492, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 49);
            textBox1.TabIndex = 1;
            textBox1.Text = "USUÁRIO";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(492, 195);
            label1.Name = "label1";
            label1.Size = new Size(292, 25);
            label1.TabIndex = 8;
            label1.Text = "________________________________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(492, 264);
            label2.Name = "label2";
            label2.Size = new Size(292, 25);
            label2.TabIndex = 9;
            label2.Text = "________________________________________";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(907, 12);
            button2.Name = "button2";
            button2.Size = new Size(51, 44);
            button2.TabIndex = 10;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(850, 12);
            button3.Name = "button3";
            button3.Size = new Size(51, 44);
            button3.TabIndex = 11;
            button3.Text = "_";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(970, 556);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(RecuperarSenha);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.85D;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel RecuperarSenha;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}
