namespace WF.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "USU�RIO")
                textBox1.Text = string.Empty;
        }



        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = "USU�RIO";
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "SENHA")
                textBox2.Text = string.Empty;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.Text = "SENHA";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Certeza pequeno gafanhoto?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                Application.Exit();

            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
