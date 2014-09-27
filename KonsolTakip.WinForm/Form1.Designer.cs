namespace KonsolTakip.WinForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adisyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envanterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tamirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açılışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adisyonToolStripMenuItem,
            this.borçlarToolStripMenuItem,
            this.envanterToolStripMenuItem,
            this.kiralamaToolStripMenuItem,
            this.notlarToolStripMenuItem,
            this.tamirToolStripMenuItem,
            this.üyelerToolStripMenuItem,
            this.açılışToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // adisyonToolStripMenuItem
            // 
            this.adisyonToolStripMenuItem.Name = "adisyonToolStripMenuItem";
            this.adisyonToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.adisyonToolStripMenuItem.Text = "Adisyon";
            this.adisyonToolStripMenuItem.Click += new System.EventHandler(this.adisyonToolStripMenuItem_Click);
            // 
            // borçlarToolStripMenuItem
            // 
            this.borçlarToolStripMenuItem.Name = "borçlarToolStripMenuItem";
            this.borçlarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.borçlarToolStripMenuItem.Text = "Borçlar";
            this.borçlarToolStripMenuItem.Click += new System.EventHandler(this.borçlarToolStripMenuItem_Click);
            // 
            // envanterToolStripMenuItem
            // 
            this.envanterToolStripMenuItem.Name = "envanterToolStripMenuItem";
            this.envanterToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.envanterToolStripMenuItem.Text = "Envanter";
            this.envanterToolStripMenuItem.Click += new System.EventHandler(this.envanterToolStripMenuItem_Click);
            // 
            // kiralamaToolStripMenuItem
            // 
            this.kiralamaToolStripMenuItem.Name = "kiralamaToolStripMenuItem";
            this.kiralamaToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.kiralamaToolStripMenuItem.Text = "Kiralama";
            this.kiralamaToolStripMenuItem.Click += new System.EventHandler(this.kiralamaToolStripMenuItem_Click);
            // 
            // notlarToolStripMenuItem
            // 
            this.notlarToolStripMenuItem.Name = "notlarToolStripMenuItem";
            this.notlarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.notlarToolStripMenuItem.Text = "Notlar";
            this.notlarToolStripMenuItem.Click += new System.EventHandler(this.notlarToolStripMenuItem_Click);
            // 
            // tamirToolStripMenuItem
            // 
            this.tamirToolStripMenuItem.Name = "tamirToolStripMenuItem";
            this.tamirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.tamirToolStripMenuItem.Text = "Tamir";
            this.tamirToolStripMenuItem.Click += new System.EventHandler(this.tamirToolStripMenuItem_Click);
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.üyelerToolStripMenuItem.Text = "Üyeler";
            this.üyelerToolStripMenuItem.Click += new System.EventHandler(this.üyelerToolStripMenuItem_Click);
            // 
            // açılışToolStripMenuItem
            // 
            this.açılışToolStripMenuItem.Name = "açılışToolStripMenuItem";
            this.açılışToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.açılışToolStripMenuItem.Text = "Açılış";
            this.açılışToolStripMenuItem.Click += new System.EventHandler(this.açılışToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adisyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envanterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tamirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açılışToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

