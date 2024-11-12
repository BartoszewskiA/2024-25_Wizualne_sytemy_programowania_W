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
            /*            int x = int.Parse(textBox1.Text);
                        int y = int.Parse(textBox2.Text);*/
            //int wynik = x + y;
            int x = 0, y = 0;
            if (!int.TryParse(textBox1.Text, out x))
            {
                x = 0;
                textBox1.Text = "0";
            }
            if (!int.TryParse(textBox2.Text, out y))
            {
                y = 0;
                textBox2.Text = "0";
            }


            label1.Text= (x+y).ToString();
        }
    }
}