namespace w04p01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lab_zr = new Label();
            lab_doc = new Label();
            tb_zr = new TextBox();
            tb_doc = new TextBox();
            groupBox1 = new GroupBox();
            rb_zr_usd = new RadioButton();
            rb_zr_euro = new RadioButton();
            rb_zr_pln = new RadioButton();
            groupBox2 = new GroupBox();
            rb_dc_usd = new RadioButton();
            rb_dc_euro = new RadioButton();
            rb_dc_pln = new RadioButton();
            imageList1 = new ImageList(components);
            hScrollBar1 = new HScrollBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lab_zr
            // 
            lab_zr.AutoSize = true;
            lab_zr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_zr.Location = new Point(53, 30);
            lab_zr.Name = "lab_zr";
            lab_zr.Size = new Size(47, 28);
            lab_zr.TabIndex = 0;
            lab_zr.Text = "PLN";
            // 
            // lab_doc
            // 
            lab_doc.AutoSize = true;
            lab_doc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lab_doc.Location = new Point(53, 89);
            lab_doc.Name = "lab_doc";
            lab_doc.Size = new Size(63, 28);
            lab_doc.TabIndex = 1;
            lab_doc.Text = "EURO";
            // 
            // tb_zr
            // 
            tb_zr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_zr.Location = new Point(136, 27);
            tb_zr.Name = "tb_zr";
            tb_zr.Size = new Size(252, 34);
            tb_zr.TabIndex = 2;
            // 
            // tb_doc
            // 
            tb_doc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_doc.Location = new Point(136, 86);
            tb_doc.Name = "tb_doc";
            tb_doc.Size = new Size(252, 34);
            tb_doc.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rb_zr_usd);
            groupBox1.Controls.Add(rb_zr_euro);
            groupBox1.Controls.Add(rb_zr_pln);
            groupBox1.Location = new Point(47, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 169);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waluta żródłowa";
            // 
            // rb_zr_usd
            // 
            rb_zr_usd.AutoSize = true;
            rb_zr_usd.Location = new Point(16, 112);
            rb_zr_usd.Name = "rb_zr_usd";
            rb_zr_usd.Size = new Size(59, 24);
            rb_zr_usd.TabIndex = 2;
            rb_zr_usd.TabStop = true;
            rb_zr_usd.Text = "USD";
            rb_zr_usd.UseVisualStyleBackColor = true;
            rb_zr_usd.CheckedChanged += rb_zr_usd_CheckedChanged;
            // 
            // rb_zr_euro
            // 
            rb_zr_euro.AutoSize = true;
            rb_zr_euro.Location = new Point(15, 69);
            rb_zr_euro.Name = "rb_zr_euro";
            rb_zr_euro.Size = new Size(68, 24);
            rb_zr_euro.TabIndex = 1;
            rb_zr_euro.TabStop = true;
            rb_zr_euro.Text = "EURO";
            rb_zr_euro.UseVisualStyleBackColor = true;
            rb_zr_euro.CheckedChanged += rb_zr_euro_CheckedChanged;
            // 
            // rb_zr_pln
            // 
            rb_zr_pln.AutoSize = true;
            rb_zr_pln.Location = new Point(14, 32);
            rb_zr_pln.Name = "rb_zr_pln";
            rb_zr_pln.Size = new Size(56, 24);
            rb_zr_pln.TabIndex = 0;
            rb_zr_pln.TabStop = true;
            rb_zr_pln.Text = "PLN";
            rb_zr_pln.UseVisualStyleBackColor = true;
            rb_zr_pln.CheckedChanged += rb_zr_pln_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rb_dc_usd);
            groupBox2.Controls.Add(rb_dc_euro);
            groupBox2.Controls.Add(rb_dc_pln);
            groupBox2.Location = new Point(231, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(157, 169);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "waluta docelowa";
            // 
            // rb_dc_usd
            // 
            rb_dc_usd.AutoSize = true;
            rb_dc_usd.Location = new Point(16, 112);
            rb_dc_usd.Name = "rb_dc_usd";
            rb_dc_usd.Size = new Size(59, 24);
            rb_dc_usd.TabIndex = 2;
            rb_dc_usd.TabStop = true;
            rb_dc_usd.Text = "USD";
            rb_dc_usd.UseVisualStyleBackColor = true;
            rb_dc_usd.CheckedChanged += rb_dc_usd_CheckedChanged;
            // 
            // rb_dc_euro
            // 
            rb_dc_euro.AutoSize = true;
            rb_dc_euro.Location = new Point(16, 69);
            rb_dc_euro.Name = "rb_dc_euro";
            rb_dc_euro.Size = new Size(68, 24);
            rb_dc_euro.TabIndex = 1;
            rb_dc_euro.TabStop = true;
            rb_dc_euro.Text = "EURO";
            rb_dc_euro.UseVisualStyleBackColor = true;
            rb_dc_euro.CheckedChanged += rb_dc_euro_CheckedChanged;
            // 
            // rb_dc_pln
            // 
            rb_dc_pln.AutoSize = true;
            rb_dc_pln.Location = new Point(16, 32);
            rb_dc_pln.Name = "rb_dc_pln";
            rb_dc_pln.Size = new Size(56, 24);
            rb_dc_pln.TabIndex = 0;
            rb_dc_pln.TabStop = true;
            rb_dc_pln.Text = "PLN";
            rb_dc_pln.UseVisualStyleBackColor = true;
            rb_dc_pln.CheckedChanged += rb_dc_pln_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(53, 350);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(335, 26);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 415);
            Controls.Add(hScrollBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tb_doc);
            Controls.Add(tb_zr);
            Controls.Add(lab_doc);
            Controls.Add(lab_zr);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_zr;
        private Label lab_doc;
        private TextBox tb_zr;
        private TextBox tb_doc;
        private GroupBox groupBox1;
        private RadioButton rb_zr_usd;
        private RadioButton rb_zr_euro;
        private RadioButton rb_zr_pln;
        private GroupBox groupBox2;
        private RadioButton rb_dc_usd;
        private RadioButton rb_dc_euro;
        private RadioButton rb_dc_pln;
        private ImageList imageList1;
        private HScrollBar hScrollBar1;
    }
}