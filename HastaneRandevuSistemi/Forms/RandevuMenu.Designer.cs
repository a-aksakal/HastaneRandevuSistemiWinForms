
namespace HastaneRandevuSistemi.Forms
{
    partial class RandevuMenu
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
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHastane = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnileri = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniRandevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaklaşanRandevularımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGeri = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İL";
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(227, 49);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(325, 21);
            this.cmbil.TabIndex = 1;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(227, 111);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(325, 21);
            this.cmbilce.TabIndex = 3;
            this.cmbilce.SelectedIndexChanged += new System.EventHandler(this.cmbilce_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İLÇE";
            // 
            // cmbHastane
            // 
            this.cmbHastane.FormattingEnabled = true;
            this.cmbHastane.Location = new System.Drawing.Point(227, 175);
            this.cmbHastane.Name = "cmbHastane";
            this.cmbHastane.Size = new System.Drawing.Size(325, 21);
            this.cmbHastane.TabIndex = 5;
            this.cmbHastane.SelectedIndexChanged += new System.EventHandler(this.cmbHastane_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "HASTANE \r\n     ADI";
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(227, 241);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(325, 21);
            this.cmbBolum.TabIndex = 7;
            this.cmbBolum.SelectedIndexChanged += new System.EventHandler(this.cmbBolum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "BÖLÜM";
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(227, 302);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(325, 21);
            this.cmbDoktor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOKTOR";
            // 
            // btnileri
            // 
            this.btnileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnileri.Location = new System.Drawing.Point(438, 366);
            this.btnileri.Name = "btnileri";
            this.btnileri.Size = new System.Drawing.Size(114, 52);
            this.btnileri.TabIndex = 10;
            this.btnileri.Text = "İleri";
            this.btnileri.UseVisualStyleBackColor = true;
            this.btnileri.Click += new System.EventHandler(this.btnileri_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniRandevuToolStripMenuItem,
            this.yaklaşanRandevularımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(146, 466);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniRandevuToolStripMenuItem
            // 
            this.yeniRandevuToolStripMenuItem.Name = "yeniRandevuToolStripMenuItem";
            this.yeniRandevuToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.yeniRandevuToolStripMenuItem.Text = "Yeni Randevu";
            // 
            // yaklaşanRandevularımToolStripMenuItem
            // 
            this.yaklaşanRandevularımToolStripMenuItem.Name = "yaklaşanRandevularımToolStripMenuItem";
            this.yaklaşanRandevularımToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.yaklaşanRandevularımToolStripMenuItem.Text = "Yaklaşan Randevularım";
            this.yaklaşanRandevularımToolStripMenuItem.Click += new System.EventHandler(this.yaklaşanRandevularımToolStripMenuItem_Click_1);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(318, 366);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(114, 52);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            // 
            // RandevuMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(623, 466);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnileri);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbHastane);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RandevuMenu";
            this.Text = "RandevuMenu";
            this.Load += new System.EventHandler(this.RandevuMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.ComboBox cmbilce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHastane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnileri;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniRandevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaklaşanRandevularımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnGeri;
    }
}