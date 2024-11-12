namespace w03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                label1.Text += "\nKlikniêto lewy przysisk;";
            }
            else if (e.Button == MouseButtons.Right) { label1.Text += "\nKlikniêto prawy przycisk"; }
            label1.Text += e.Location.X.ToString() + " ; " + e.Location.Y.ToString();

            if (e.Location.Y < 100)
            {
                panel1.BackColor = Color.FromArgb(180, 180, 180);
            }
            else if (e.Location.Y < 200)
            {
                panel1.BackColor = Color.FromArgb(100, 100, 100);
            }
            else
                panel1.BackColor = Color.FromArgb(50, 50, 50);


        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Green;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }
    }
}