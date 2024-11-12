namespace w02p03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var odpowiedz = MessageBox.Show("Komunikat", "Tytu³", MessageBoxButtons.YesNoCancel);

            if(odpowiedz == DialogResult.Yes)
            {

            }
            else if (odpowiedz == DialogResult.No)
            {

            }
            else
            {

            }
        }
    }
}