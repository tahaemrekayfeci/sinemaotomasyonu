
namespace sinemaotomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_salon = new System.Windows.Forms.TextBox();
            this.txt_koltuk = new System.Windows.Forms.TextBox();
            this.satan = new System.Windows.Forms.GroupBox();
            this.cbx_indirim = new System.Windows.Forms.CheckBox();
            this.btn_biletiptal = new System.Windows.Forms.Button();
            this.btn_biletsat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_boskoltuk = new System.Windows.Forms.Button();
            this.btn_bakiye = new System.Windows.Forms.Button();
            this.btn_olustur = new System.Windows.Forms.Button();
            this.lbl_boskoltuk = new System.Windows.Forms.Label();
            this.lbl_sayi = new System.Windows.Forms.Label();
            this.satan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koltuk Sayısı :";
            // 
            // txt_salon
            // 
            this.txt_salon.Location = new System.Drawing.Point(118, 23);
            this.txt_salon.Name = "txt_salon";
            this.txt_salon.Size = new System.Drawing.Size(100, 20);
            this.txt_salon.TabIndex = 2;
            // 
            // txt_koltuk
            // 
            this.txt_koltuk.Location = new System.Drawing.Point(118, 74);
            this.txt_koltuk.Name = "txt_koltuk";
            this.txt_koltuk.Size = new System.Drawing.Size(100, 20);
            this.txt_koltuk.TabIndex = 3;
            // 
            // satan
            // 
            this.satan.Controls.Add(this.btn_biletiptal);
            this.satan.Controls.Add(this.btn_biletsat);
            this.satan.Controls.Add(this.cbx_indirim);
            this.satan.Location = new System.Drawing.Point(15, 158);
            this.satan.Name = "satan";
            this.satan.Size = new System.Drawing.Size(203, 161);
            this.satan.TabIndex = 4;
            this.satan.TabStop = false;
            this.satan.Text = "Satış İptali";
            // 
            // cbx_indirim
            // 
            this.cbx_indirim.AutoSize = true;
            this.cbx_indirim.Location = new System.Drawing.Point(6, 19);
            this.cbx_indirim.Name = "cbx_indirim";
            this.cbx_indirim.Size = new System.Drawing.Size(56, 17);
            this.cbx_indirim.TabIndex = 0;
            this.cbx_indirim.Text = "İndirim";
            this.cbx_indirim.UseVisualStyleBackColor = true;
            // 
            // btn_biletiptal
            // 
            this.btn_biletiptal.Location = new System.Drawing.Point(103, 82);
            this.btn_biletiptal.Name = "btn_biletiptal";
            this.btn_biletiptal.Size = new System.Drawing.Size(75, 42);
            this.btn_biletiptal.TabIndex = 5;
            this.btn_biletiptal.Text = "Bilet İptal";
            this.btn_biletiptal.UseVisualStyleBackColor = true;
            this.btn_biletiptal.Click += new System.EventHandler(this.btn_biletiptal_Click);
            // 
            // btn_biletsat
            // 
            this.btn_biletsat.Location = new System.Drawing.Point(6, 82);
            this.btn_biletsat.Name = "btn_biletsat";
            this.btn_biletsat.Size = new System.Drawing.Size(75, 42);
            this.btn_biletsat.TabIndex = 6;
            this.btn_biletsat.Text = "Bilet Sat";
            this.btn_biletsat.UseVisualStyleBackColor = true;
            this.btn_biletsat.Click += new System.EventHandler(this.btn_biletsat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_boskoltuk);
            this.groupBox1.Controls.Add(this.btn_bakiye);
            this.groupBox1.Location = new System.Drawing.Point(267, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 161);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rapor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_boskoltuk
            // 
            this.btn_boskoltuk.Location = new System.Drawing.Point(103, 82);
            this.btn_boskoltuk.Name = "btn_boskoltuk";
            this.btn_boskoltuk.Size = new System.Drawing.Size(75, 42);
            this.btn_boskoltuk.TabIndex = 5;
            this.btn_boskoltuk.Text = "Boş Koltuk";
            this.btn_boskoltuk.UseVisualStyleBackColor = true;
            this.btn_boskoltuk.Click += new System.EventHandler(this.btn_boskoltuk_Click);
            // 
            // btn_bakiye
            // 
            this.btn_bakiye.Location = new System.Drawing.Point(6, 82);
            this.btn_bakiye.Name = "btn_bakiye";
            this.btn_bakiye.Size = new System.Drawing.Size(75, 42);
            this.btn_bakiye.TabIndex = 6;
            this.btn_bakiye.Text = "Bakiye";
            this.btn_bakiye.UseVisualStyleBackColor = true;
            this.btn_bakiye.Click += new System.EventHandler(this.btn_bakiye_Click);
            // 
            // btn_olustur
            // 
            this.btn_olustur.Location = new System.Drawing.Point(267, 23);
            this.btn_olustur.Name = "btn_olustur";
            this.btn_olustur.Size = new System.Drawing.Size(203, 59);
            this.btn_olustur.TabIndex = 7;
            this.btn_olustur.Text = "Oluştur";
            this.btn_olustur.UseVisualStyleBackColor = true;
            this.btn_olustur.Click += new System.EventHandler(this.btn_olustur_Click);
            // 
            // lbl_boskoltuk
            // 
            this.lbl_boskoltuk.AutoSize = true;
            this.lbl_boskoltuk.Location = new System.Drawing.Point(12, 346);
            this.lbl_boskoltuk.Name = "lbl_boskoltuk";
            this.lbl_boskoltuk.Size = new System.Drawing.Size(94, 13);
            this.lbl_boskoltuk.TabIndex = 8;
            this.lbl_boskoltuk.Text = "Boş Koltuk Sayısı :";
            // 
            // lbl_sayi
            // 
            this.lbl_sayi.AutoSize = true;
            this.lbl_sayi.Location = new System.Drawing.Point(112, 346);
            this.lbl_sayi.Name = "lbl_sayi";
            this.lbl_sayi.Size = new System.Drawing.Size(16, 13);
            this.lbl_sayi.TabIndex = 9;
            this.lbl_sayi.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_sayi);
            this.Controls.Add(this.lbl_boskoltuk);
            this.Controls.Add(this.btn_olustur);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.satan);
            this.Controls.Add(this.txt_koltuk);
            this.Controls.Add(this.txt_salon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.satan.ResumeLayout(false);
            this.satan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_salon;
        private System.Windows.Forms.TextBox txt_koltuk;
        private System.Windows.Forms.GroupBox satan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_boskoltuk;
        private System.Windows.Forms.Button btn_bakiye;
        private System.Windows.Forms.Button btn_biletiptal;
        private System.Windows.Forms.Button btn_biletsat;
        private System.Windows.Forms.CheckBox cbx_indirim;
        private System.Windows.Forms.Button btn_olustur;
        private System.Windows.Forms.Label lbl_boskoltuk;
        private System.Windows.Forms.Label lbl_sayi;
    }
}

