namespace sinavprogrami
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
            cmbDersler = new ComboBox();
            lblSoru = new Label();
            rbSecenekA = new RadioButton();
            rbSecenekB = new RadioButton();
            rbSecenekC = new RadioButton();
            rbSecenekD = new RadioButton();
            SinavBaslaBTN = new Button();
            IleriBTN = new Button();
            SinaviBitirBTN = new Button();
            GeriBTN = new Button();
            Surelbl = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbDersler
            // 
            cmbDersler.BackColor = Color.FromArgb(192, 192, 255);
            cmbDersler.FormattingEnabled = true;
            cmbDersler.Location = new Point(12, 12);
            cmbDersler.Name = "cmbDersler";
            cmbDersler.Size = new Size(179, 28);
            cmbDersler.TabIndex = 0;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(12, 107);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(0, 20);
            lblSoru.TabIndex = 1;
            // 
            // rbSecenekA
            // 
            rbSecenekA.AutoSize = true;
            rbSecenekA.Location = new Point(12, 174);
            rbSecenekA.Name = "rbSecenekA";
            rbSecenekA.Size = new Size(17, 16);
            rbSecenekA.TabIndex = 2;
            rbSecenekA.TabStop = true;
            rbSecenekA.UseVisualStyleBackColor = true;
            // 
            // rbSecenekB
            // 
            rbSecenekB.AutoSize = true;
            rbSecenekB.Location = new Point(12, 209);
            rbSecenekB.Name = "rbSecenekB";
            rbSecenekB.Size = new Size(17, 16);
            rbSecenekB.TabIndex = 3;
            rbSecenekB.TabStop = true;
            rbSecenekB.UseVisualStyleBackColor = true;
            // 
            // rbSecenekC
            // 
            rbSecenekC.AutoSize = true;
            rbSecenekC.Location = new Point(12, 239);
            rbSecenekC.Name = "rbSecenekC";
            rbSecenekC.Size = new Size(17, 16);
            rbSecenekC.TabIndex = 4;
            rbSecenekC.TabStop = true;
            rbSecenekC.UseVisualStyleBackColor = true;
            // 
            // rbSecenekD
            // 
            rbSecenekD.AutoSize = true;
            rbSecenekD.Location = new Point(12, 269);
            rbSecenekD.Name = "rbSecenekD";
            rbSecenekD.Size = new Size(17, 16);
            rbSecenekD.TabIndex = 5;
            rbSecenekD.TabStop = true;
            rbSecenekD.UseVisualStyleBackColor = true;
            // 
            // SinavBaslaBTN
            // 
            SinavBaslaBTN.BackColor = Color.FromArgb(192, 192, 255);
            SinavBaslaBTN.Location = new Point(197, 11);
            SinavBaslaBTN.Name = "SinavBaslaBTN";
            SinavBaslaBTN.Size = new Size(126, 29);
            SinavBaslaBTN.TabIndex = 6;
            SinavBaslaBTN.Text = "Sınav Başlat";
            SinavBaslaBTN.UseVisualStyleBackColor = false;
            SinavBaslaBTN.Click += SinavBaslaBTN_Click;
            // 
            // IleriBTN
            // 
            IleriBTN.BackColor = Color.FromArgb(192, 192, 255);
            IleriBTN.Location = new Point(174, 357);
            IleriBTN.Name = "IleriBTN";
            IleriBTN.Size = new Size(117, 49);
            IleriBTN.TabIndex = 7;
            IleriBTN.Text = "İleri >>";
            IleriBTN.UseVisualStyleBackColor = false;
            IleriBTN.Click += IleriBTN_Click;
            // 
            // SinaviBitirBTN
            // 
            SinaviBitirBTN.BackColor = Color.FromArgb(192, 192, 255);
            SinaviBitirBTN.Location = new Point(340, 11);
            SinaviBitirBTN.Name = "SinaviBitirBTN";
            SinaviBitirBTN.Size = new Size(142, 29);
            SinaviBitirBTN.TabIndex = 8;
            SinaviBitirBTN.Text = "Sınav Bitir";
            SinaviBitirBTN.UseVisualStyleBackColor = false;
            SinaviBitirBTN.Click += SinaviBitirBTN_Click;
            // 
            // GeriBTN
            // 
            GeriBTN.BackColor = Color.FromArgb(192, 192, 255);
            GeriBTN.Location = new Point(6, 357);
            GeriBTN.Name = "GeriBTN";
            GeriBTN.Size = new Size(119, 49);
            GeriBTN.TabIndex = 9;
            GeriBTN.Text = "<< Geri";
            GeriBTN.UseVisualStyleBackColor = false;
            GeriBTN.Click += GeriBTN_Click;
            // 
            // Surelbl
            // 
            Surelbl.AutoSize = true;
            Surelbl.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Surelbl.ForeColor = Color.Red;
            Surelbl.Location = new Point(337, 386);
            Surelbl.Name = "Surelbl";
            Surelbl.Size = new Size(0, 20);
            Surelbl.TabIndex = 10;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(340, 357);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 11;
            label1.Text = "Kalan Süre:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(508, 450);
            Controls.Add(label1);
            Controls.Add(Surelbl);
            Controls.Add(GeriBTN);
            Controls.Add(SinaviBitirBTN);
            Controls.Add(IleriBTN);
            Controls.Add(SinavBaslaBTN);
            Controls.Add(rbSecenekD);
            Controls.Add(rbSecenekC);
            Controls.Add(rbSecenekB);
            Controls.Add(rbSecenekA);
            Controls.Add(lblSoru);
            Controls.Add(cmbDersler);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Ecem Köklü";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDersler;
        private Label lblSoru;
        private RadioButton rbSecenekA;
        private RadioButton rbSecenekB;
        private RadioButton rbSecenekC;
        private RadioButton rbSecenekD;
        private Button SinavBaslaBTN;
        private Button IleriBTN;
        private Button SinaviBitirBTN;
        private Button GeriBTN;
        private Label Surelbl;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}