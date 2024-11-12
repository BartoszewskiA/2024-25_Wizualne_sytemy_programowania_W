namespace w02p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = label1.Text + "\n" + "Start konstruktora";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n" + "Load";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n" + "Shown";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            label1.Text = label1.Text + "\n" + "Closing";
            if(MessageBox.Show("Zamkn¹æ program?", "Pytanie", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }

           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            label1.Text = label1.Text + "\n" + "Cloused";
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n" + "Activated";
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n" + "Deactivated";
        }
    }
}