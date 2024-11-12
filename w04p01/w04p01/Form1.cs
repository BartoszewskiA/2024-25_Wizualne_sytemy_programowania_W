namespace w04p01
{
    public partial class Form1 : Form
    {

        double KURS_EURO = 4.3;
        double KURS_USD = 3.9;
        public Form1()
        {
            InitializeComponent();
            tb_zr.Text = hScrollBar1.Value.ToString();
            tb_doc.Text = "0"; //do zmiany
            rb_zr_pln.Checked = true;
            rb_dc_usd.Checked = true;


        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tb_zr.Text = e.NewValue.ToString();
            tb_doc.Text = przelicz(e.NewValue).ToString();
        }

        double przelicz(double kwota)
        {
            double wynik = 0;
            double kwota_przeliczeniowa = 0;
            if (rb_zr_pln.Checked)
                kwota_przeliczeniowa = kwota;
            else if (rb_zr_euro.Checked)
                kwota_przeliczeniowa = kwota * KURS_EURO;
            else if (rb_zr_usd.Checked)
                kwota_przeliczeniowa = kwota * KURS_USD;

            if (rb_dc_pln.Checked)
                wynik = kwota_przeliczeniowa;
            else if (rb_dc_euro.Checked)
                wynik = kwota_przeliczeniowa / KURS_EURO;
            else if (rb_dc_usd.Checked)
                wynik = kwota_przeliczeniowa / KURS_USD;
            wynik = Math.Round(wynik, 2);

            return wynik;
        }

        void reakcja_na_rb()
        {
            Color kolor_pln = Color.FromArgb(255, 0, 200, 100);
            Color kolor_usd = Color.FromArgb(255, 200, 0, 100);
            Color kolor_euro = Color.FromArgb(255, 0, 50, 200);

            if (rb_zr_pln.Checked)
            {
                lab_zr.Text = "PLN";
                lab_zr.ForeColor = kolor_pln;
            }
            else if (rb_zr_usd.Checked)
            {
                lab_zr.Text = "USD";
                lab_zr.ForeColor = kolor_usd;
            }
            else if (rb_zr_euro.Checked)
            {
                lab_zr.Text = "EURO";
                lab_zr.ForeColor = kolor_euro;
            }

            if (rb_dc_pln.Checked)
            {
                lab_doc.Text = "PLN";
                lab_doc.ForeColor = kolor_pln;
            }
            else if (rb_dc_usd.Checked)
            {
                lab_doc.Text = "USD";
                lab_doc.ForeColor = kolor_usd;
            }
            else if (rb_dc_euro.Checked)
            {
                lab_doc.Text = "EURO";
                lab_doc.ForeColor = kolor_euro;
            }
        }

        private void rb_zr_pln_CheckedChanged(object sender, EventArgs e)
        {
            reakcja_na_rb();
            tb_doc.Text = przelicz(hScrollBar1.Value).ToString();
        }

        private void rb_zr_euro_CheckedChanged(object sender, EventArgs e)
        {
            reakcja_na_rb();
            tb_doc.Text = przelicz(hScrollBar1.Value).ToString();
        }

        private void rb_zr_usd_CheckedChanged(object sender, EventArgs e)
        {
            reakcja_na_rb();
            tb_doc.Text = przelicz(hScrollBar1.Value).ToString();
        }

        private void rb_dc_pln_CheckedChanged(object sender, EventArgs e)
        {
            reakcja_na_rb();
            tb_doc.Text = przelicz(hScrollBar1.Value).ToString();
        }

        private void rb_dc_euro_CheckedChanged(object sender, EventArgs e)
        {
            reakcja_na_rb();
            tb_doc.Text = przelicz(hScrollBar1.Value).ToString();
        }

        private void rb_dc_usd_CheckedChanged(object sender, EventArgs e)
        {
            reakcja_na_rb();
            tb_doc.Text = przelicz(hScrollBar1.Value).ToString();
        }
    }
}