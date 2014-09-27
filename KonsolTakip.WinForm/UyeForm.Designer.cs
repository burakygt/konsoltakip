namespace KonsolTakip.WinForm
{
    partial class UyeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sil = new System.Windows.Forms.Button();
            this.Düzenle = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UyeData = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsure = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UyeData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtsure);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.adres);
            this.panel1.Controls.Add(this.txtmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Sil);
            this.panel1.Controls.Add(this.Düzenle);
            this.panel1.Controls.Add(this.Ekle);
            this.panel1.Controls.Add(this.txttutar);
            this.panel1.Controls.Add(this.txttel);
            this.panel1.Controls.Add(this.txtsoyad);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 185);
            this.panel1.TabIndex = 2;
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(388, 131);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 10;
            this.Sil.Text = "SİL";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Düzenle
            // 
            this.Düzenle.Location = new System.Drawing.Point(307, 131);
            this.Düzenle.Name = "Düzenle";
            this.Düzenle.Size = new System.Drawing.Size(75, 23);
            this.Düzenle.TabIndex = 9;
            this.Düzenle.Text = "DÜZENLE";
            this.Düzenle.UseVisualStyleBackColor = true;
            this.Düzenle.Click += new System.EventHandler(this.Düzenle_Click);
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(226, 131);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(75, 23);
            this.Ekle.TabIndex = 8;
            this.Ekle.Text = "EKLE";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(63, 107);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(143, 20);
            this.txttutar.TabIndex = 7;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(63, 73);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(143, 20);
            this.txttel.TabIndex = 6;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(63, 42);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(143, 20);
            this.txtsoyad.TabIndex = 5;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(63, 9);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(143, 20);
            this.txtad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ücret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // UyeData
            // 
            this.UyeData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UyeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UyeData.Location = new System.Drawing.Point(0, 208);
            this.UyeData.Name = "UyeData";
            this.UyeData.Size = new System.Drawing.Size(471, 250);
            this.UyeData.TabIndex = 3;
            this.UyeData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UyeData_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adres";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(282, 88);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(143, 20);
            this.txtmail.TabIndex = 13;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(282, 6);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(177, 67);
            this.adres.TabIndex = 14;
            this.adres.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Süre";
            // 
            // txtsure
            // 
            this.txtsure.Location = new System.Drawing.Point(63, 138);
            this.txtsure.Name = "txtsure";
            this.txtsure.Size = new System.Drawing.Size(143, 20);
            this.txtsure.TabIndex = 16;
            // 
            // UyeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 459);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UyeData);
            this.Name = "UyeForm";
            this.Text = "UyeForm";
            this.Load += new System.EventHandler(this.UyeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UyeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Düzenle;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UyeData;

    }
}