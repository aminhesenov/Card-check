namespace card_check
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
        }

        private void textBox2_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox3.Text;
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = maskedTextBox1.Text;
        }
        bool k = true;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (k == true)
            {
                k = false;
                textBox4.UseSystemPasswordChar = false;
                pictureBox3.ImageLocation = "H:\\C#\\img\\hidden.png";
            }
            else
            {
                k = true;
                textBox4.UseSystemPasswordChar = true;
                pictureBox3.ImageLocation = "H:\\C#\\img\\view.png";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("Kart məlumatları tam daxil edilməyib",
                    "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                progressBar1.Visible = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
               DialogResult d= MessageBox.Show("Kart məlumatları yoxlanmağa göndərildi",
                    "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(d == DialogResult.OK)
                {
                    progressBar1.Visible = false;
                }
            }
        }
    }
}
