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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            RecuperarSenha = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.Location = new Point(492, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(492, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(334, 31);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(492, 339);
            button1.Name = "button1";
            button1.Size = new Size(334, 52);
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
            RecuperarSenha.TabIndex = 4;
            RecuperarSenha.TabStop = true;
            RecuperarSenha.Text = "Esqueceu a Senha?";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(852, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 44);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(907, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 44);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(970, 556);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(RecuperarSenha);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Opacity = 0.85D;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private LinkLabel RecuperarSenha;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
