namespace KonsolTakip.WinForm
{
    partial class AdisyonForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.UrunKodu = new System.Windows.Forms.TextBox();
            this.UrunAdet = new System.Windows.Forms.NumericUpDown();
            this.UrunFiyat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AdisyonData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UrunAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdisyonData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kodu : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyatı  : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Urun Adeti : ";
            // 
            // UrunAdi
            // 
            this.UrunAdi.Location = new System.Drawing.Point(116, 23);
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(120, 20);
            this.UrunAdi.TabIndex = 4;
            // 
            // UrunKodu
            // 
            this.UrunKodu.Location = new System.Drawing.Point(116, 68);
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.Size = new System.Drawing.Size(120, 20);
            this.UrunKodu.TabIndex = 5;
            // 
            // UrunAdet
            // 
            this.UrunAdet.Location = new System.Drawing.Point(116, 145);
            this.UrunAdet.Name = "UrunAdet";
            this.UrunAdet.Size = new System.Drawing.Size(120, 20);
            this.UrunAdet.TabIndex = 7;
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.UrunFiyat.Location = new System.Drawing.Point(116, 105);
            this.UrunFiyat.Name = "UrunFiyat";
            this.UrunFiyat.Size = new System.Drawing.Size(120, 20);
            this.UrunFiyat.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdisyonData
            // 
            this.AdisyonData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdisyonData.Location = new System.Drawing.Point(12, 181);
            this.AdisyonData.Name = "AdisyonData";
            this.AdisyonData.Size = new System.Drawing.Size(633, 199);
            this.AdisyonData.TabIndex = 12;
            this.AdisyonData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdisyonData_CellClick);
            // 
            // AdisyonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 392);
            this.Controls.Add(this.AdisyonData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UrunFiyat);
            this.Controls.Add(this.UrunAdet);
            this.Controls.Add(this.UrunKodu);
            this.Controls.Add(this.UrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdisyonForm";
            this.Text = "AdisyonForm";
            this.Load += new System.EventHandler(this.AdisyonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UrunAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UrunFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdisyonData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrunAdi;
        private System.Windows.Forms.TextBox UrunKodu;
        private System.Windows.Forms.NumericUpDown UrunAdet;
        private System.Windows.Forms.NumericUpDown UrunFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView AdisyonData;
    }
}