namespace w01p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White; 
            textBox1.BackColor = Color.White;
            int x = 0, y = 0;
            if (!int.TryParse(textBox1.Text, out x))
            {
                textBox1.BackColor = Color.Red;
                MessageBox.Show("Nalezy wype³niæ pierwsze pole", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (!int.TryParse(textBox2.Text, out y))
            {
                textBox2.BackColor = Color.Red;
                return;
            }


            label1.Text = (x + y).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}