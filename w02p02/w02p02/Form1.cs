namespace w02p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {

            if (Form1.ActiveForm != null)
            {
                label1.Text = Form1.ActiveForm.Location.X.ToString();
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Form1.ActiveForm != null)
            {
                label1.Text = Form1.ActiveForm.Height.ToString();
            }
        }
    }
}