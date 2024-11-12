namespace w01p01
{
    public partial class Form1 : Form
    {
        int ile = 0;
        public Form1()
        {
            InitializeComponent();

            //label2.Text = "tekst wpisany przez c#";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ile++;
            label2.Text = ile.ToString();
        }
    }
}