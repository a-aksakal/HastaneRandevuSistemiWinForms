
namespace HastaneRandevuSistemi.Forms
{
    partial class RandevuTarihSaat
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
            this.yeniRandevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaklaşanRandevularımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn900 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn915 = new System.Windows.Forms.Button();
            this.btn930 = new System.Windows.Forms.Button();
            this.btn945 = new System.Windows.Forms.Button();
            this.btn1000 = new System.Windows.Forms.Button();
            this.btn1015 = new System.Windows.Forms.Button();
            this.btn1030 = new System.Windows.Forms.Button();
            this.btn1045 = new System.Windows.Forms.Button();
            this.btn1100 = new System.Windows.Forms.Button();
            this.btn1115 = new System.Windows.Forms.Button();
            this.btn1130 = new System.Windows.Forms.Button();
            this.btn1145 = new System.Windows.Forms.Button();
            this.btn1330 = new System.Windows.Forms.Button();
            this.btn1345 = new System.Windows.Forms.Button();
            this.btn1400 = new System.Windows.Forms.Button();
            this.btn1415 = new System.Windows.Forms.Button();
            this.btn1430 = new System.Windows.Forms.Button();
            this.btn1445 = new System.Windows.Forms.Button();
            this.btn1500 = new System.Windows.Forms.Button();
            this.btn1515 = new System.Windows.Forms.Button();
            this.btn1530 = new System.Windows.Forms.Button();
            this.btn1545 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniRandevuToolStripMenuItem,
            this.yaklaşanRandevularımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(146, 456);
            this.menuStrip1.TabIndex = 3;
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
            this.yaklaşanRandevularımToolStripMenuItem.Click += new System.EventHandler(this.yaklaşanRandevularımToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 64);
            this.button2.TabIndex = 14;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRandevuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.Location = new System.Drawing.Point(633, 380);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(100, 64);
            this.btnRandevuAl.TabIndex = 13;
            this.btnRandevuAl.Text = "Randevu Oluştur";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 13, 20, 5, 6, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn900
            // 
            this.btn900.BackColor = System.Drawing.Color.Chartreuse;
            this.btn900.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn900.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn900.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn900.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn900.Location = new System.Drawing.Point(50, 40);
            this.btn900.Name = "btn900";
            this.btn900.Size = new System.Drawing.Size(76, 35);
            this.btn900.TabIndex = 16;
            this.btn900.Text = "09:00";
            this.btn900.UseVisualStyleBackColor = false;
            this.btn900.Click += new System.EventHandler(this.btn900_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-16, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "_________________________________________________________________________________" +
    "_________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(595, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "_________________________________________________________________________________" +
    "_________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "TARİH VE SAAT SECİN";
            // 
            // btn915
            // 
            this.btn915.BackColor = System.Drawing.Color.Chartreuse;
            this.btn915.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn915.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn915.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn915.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn915.Location = new System.Drawing.Point(132, 40);
            this.btn915.Name = "btn915";
            this.btn915.Size = new System.Drawing.Size(76, 35);
            this.btn915.TabIndex = 41;
            this.btn915.Text = "09:15";
            this.btn915.UseVisualStyleBackColor = false;
            this.btn915.Click += new System.EventHandler(this.btn915_Click);
            // 
            // btn930
            // 
            this.btn930.BackColor = System.Drawing.Color.Chartreuse;
            this.btn930.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn930.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn930.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn930.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn930.Location = new System.Drawing.Point(214, 40);
            this.btn930.Name = "btn930";
            this.btn930.Size = new System.Drawing.Size(76, 35);
            this.btn930.TabIndex = 42;
            this.btn930.Text = "09:30";
            this.btn930.UseVisualStyleBackColor = false;
            this.btn930.Click += new System.EventHandler(this.btn930_Click);
            // 
            // btn945
            // 
            this.btn945.BackColor = System.Drawing.Color.Chartreuse;
            this.btn945.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn945.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn945.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn945.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn945.Location = new System.Drawing.Point(296, 40);
            this.btn945.Name = "btn945";
            this.btn945.Size = new System.Drawing.Size(76, 35);
            this.btn945.TabIndex = 43;
            this.btn945.Text = "09:45";
            this.btn945.UseVisualStyleBackColor = false;
            this.btn945.Click += new System.EventHandler(this.btn945_Click);
            // 
            // btn1000
            // 
            this.btn1000.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1000.Location = new System.Drawing.Point(378, 40);
            this.btn1000.Name = "btn1000";
            this.btn1000.Size = new System.Drawing.Size(76, 35);
            this.btn1000.TabIndex = 44;
            this.btn1000.Text = "10:00";
            this.btn1000.UseVisualStyleBackColor = false;
            this.btn1000.Click += new System.EventHandler(this.btn1000_Click);
            // 
            // btn1015
            // 
            this.btn1015.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1015.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1015.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1015.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1015.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1015.Location = new System.Drawing.Point(460, 40);
            this.btn1015.Name = "btn1015";
            this.btn1015.Size = new System.Drawing.Size(76, 35);
            this.btn1015.TabIndex = 45;
            this.btn1015.Text = "10:15";
            this.btn1015.UseVisualStyleBackColor = false;
            this.btn1015.Click += new System.EventHandler(this.btn1015_Click);
            // 
            // btn1030
            // 
            this.btn1030.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1030.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1030.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1030.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1030.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1030.Location = new System.Drawing.Point(50, 81);
            this.btn1030.Name = "btn1030";
            this.btn1030.Size = new System.Drawing.Size(76, 35);
            this.btn1030.TabIndex = 46;
            this.btn1030.Text = "10:30";
            this.btn1030.UseVisualStyleBackColor = false;
            this.btn1030.Click += new System.EventHandler(this.btn1030_Click);
            // 
            // btn1045
            // 
            this.btn1045.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1045.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1045.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1045.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1045.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1045.Location = new System.Drawing.Point(132, 81);
            this.btn1045.Name = "btn1045";
            this.btn1045.Size = new System.Drawing.Size(76, 35);
            this.btn1045.TabIndex = 47;
            this.btn1045.Text = "10:45";
            this.btn1045.UseVisualStyleBackColor = false;
            this.btn1045.Click += new System.EventHandler(this.btn1045_Click);
            // 
            // btn1100
            // 
            this.btn1100.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1100.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1100.Location = new System.Drawing.Point(214, 81);
            this.btn1100.Name = "btn1100";
            this.btn1100.Size = new System.Drawing.Size(76, 35);
            this.btn1100.TabIndex = 48;
            this.btn1100.Text = "11:00";
            this.btn1100.UseVisualStyleBackColor = false;
            this.btn1100.Click += new System.EventHandler(this.btn1100_Click);
            // 
            // btn1115
            // 
            this.btn1115.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1115.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1115.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1115.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1115.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1115.Location = new System.Drawing.Point(296, 81);
            this.btn1115.Name = "btn1115";
            this.btn1115.Size = new System.Drawing.Size(76, 35);
            this.btn1115.TabIndex = 49;
            this.btn1115.Text = "11:15";
            this.btn1115.UseVisualStyleBackColor = false;
            this.btn1115.Click += new System.EventHandler(this.btn1115_Click);
            // 
            // btn1130
            // 
            this.btn1130.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1130.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1130.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1130.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1130.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1130.Location = new System.Drawing.Point(378, 81);
            this.btn1130.Name = "btn1130";
            this.btn1130.Size = new System.Drawing.Size(76, 35);
            this.btn1130.TabIndex = 50;
            this.btn1130.Text = "11:30";
            this.btn1130.UseVisualStyleBackColor = false;
            this.btn1130.Click += new System.EventHandler(this.btn1130_Click);
            // 
            // btn1145
            // 
            this.btn1145.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1145.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1145.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1145.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1145.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1145.Location = new System.Drawing.Point(460, 81);
            this.btn1145.Name = "btn1145";
            this.btn1145.Size = new System.Drawing.Size(76, 35);
            this.btn1145.TabIndex = 51;
            this.btn1145.Text = "11:45";
            this.btn1145.UseVisualStyleBackColor = false;
            this.btn1145.Click += new System.EventHandler(this.btn1145_Click);
            // 
            // btn1330
            // 
            this.btn1330.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1330.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1330.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1330.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1330.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1330.Location = new System.Drawing.Point(50, 173);
            this.btn1330.Name = "btn1330";
            this.btn1330.Size = new System.Drawing.Size(76, 35);
            this.btn1330.TabIndex = 52;
            this.btn1330.Text = "13:30";
            this.btn1330.UseVisualStyleBackColor = false;
            this.btn1330.Click += new System.EventHandler(this.btn1330_Click);
            // 
            // btn1345
            // 
            this.btn1345.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1345.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1345.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1345.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1345.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1345.Location = new System.Drawing.Point(132, 173);
            this.btn1345.Name = "btn1345";
            this.btn1345.Size = new System.Drawing.Size(76, 35);
            this.btn1345.TabIndex = 53;
            this.btn1345.Text = "13:45";
            this.btn1345.UseVisualStyleBackColor = false;
            this.btn1345.Click += new System.EventHandler(this.btn1345_Click);
            // 
            // btn1400
            // 
            this.btn1400.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1400.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1400.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1400.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1400.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1400.Location = new System.Drawing.Point(214, 173);
            this.btn1400.Name = "btn1400";
            this.btn1400.Size = new System.Drawing.Size(76, 35);
            this.btn1400.TabIndex = 54;
            this.btn1400.Text = "14:00";
            this.btn1400.UseVisualStyleBackColor = false;
            this.btn1400.Click += new System.EventHandler(this.btn1400_Click);
            // 
            // btn1415
            // 
            this.btn1415.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1415.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1415.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1415.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1415.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1415.Location = new System.Drawing.Point(296, 173);
            this.btn1415.Name = "btn1415";
            this.btn1415.Size = new System.Drawing.Size(76, 35);
            this.btn1415.TabIndex = 55;
            this.btn1415.Text = "14:15";
            this.btn1415.UseVisualStyleBackColor = false;
            this.btn1415.Click += new System.EventHandler(this.btn1415_Click);
            // 
            // btn1430
            // 
            this.btn1430.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1430.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1430.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1430.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1430.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1430.Location = new System.Drawing.Point(378, 173);
            this.btn1430.Name = "btn1430";
            this.btn1430.Size = new System.Drawing.Size(76, 35);
            this.btn1430.TabIndex = 56;
            this.btn1430.Text = "14:30";
            this.btn1430.UseVisualStyleBackColor = false;
            this.btn1430.Click += new System.EventHandler(this.btn1430_Click);
            // 
            // btn1445
            // 
            this.btn1445.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1445.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1445.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1445.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1445.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1445.Location = new System.Drawing.Point(460, 173);
            this.btn1445.Name = "btn1445";
            this.btn1445.Size = new System.Drawing.Size(76, 35);
            this.btn1445.TabIndex = 57;
            this.btn1445.Text = "14:45";
            this.btn1445.UseVisualStyleBackColor = false;
            this.btn1445.Click += new System.EventHandler(this.btn1445_Click);
            // 
            // btn1500
            // 
            this.btn1500.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1500.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1500.Location = new System.Drawing.Point(50, 214);
            this.btn1500.Name = "btn1500";
            this.btn1500.Size = new System.Drawing.Size(76, 35);
            this.btn1500.TabIndex = 58;
            this.btn1500.Text = "15:00";
            this.btn1500.UseVisualStyleBackColor = false;
            this.btn1500.Click += new System.EventHandler(this.btn1500_Click);
            // 
            // btn1515
            // 
            this.btn1515.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1515.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1515.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1515.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1515.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1515.Location = new System.Drawing.Point(132, 214);
            this.btn1515.Name = "btn1515";
            this.btn1515.Size = new System.Drawing.Size(76, 35);
            this.btn1515.TabIndex = 59;
            this.btn1515.Text = "15:15";
            this.btn1515.UseVisualStyleBackColor = false;
            this.btn1515.Click += new System.EventHandler(this.btn1515_Click);
            // 
            // btn1530
            // 
            this.btn1530.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1530.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1530.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1530.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1530.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1530.Location = new System.Drawing.Point(214, 214);
            this.btn1530.Name = "btn1530";
            this.btn1530.Size = new System.Drawing.Size(76, 35);
            this.btn1530.TabIndex = 60;
            this.btn1530.Text = "15:30";
            this.btn1530.UseVisualStyleBackColor = false;
            this.btn1530.Click += new System.EventHandler(this.btn1530_Click);
            // 
            // btn1545
            // 
            this.btn1545.BackColor = System.Drawing.Color.Chartreuse;
            this.btn1545.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1545.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1545.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1545.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1545.Location = new System.Drawing.Point(296, 214);
            this.btn1545.Name = "btn1545";
            this.btn1545.Size = new System.Drawing.Size(76, 35);
            this.btn1545.TabIndex = 61;
            this.btn1545.Text = "15:45";
            this.btn1545.UseVisualStyleBackColor = false;
            this.btn1545.Click += new System.EventHandler(this.btn1545_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn1545);
            this.panel1.Controls.Add(this.btn1530);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn1515);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn1500);
            this.panel1.Controls.Add(this.btn1445);
            this.panel1.Controls.Add(this.btn1430);
            this.panel1.Controls.Add(this.btn1415);
            this.panel1.Controls.Add(this.btn1400);
            this.panel1.Controls.Add(this.btn1345);
            this.panel1.Controls.Add(this.btn1330);
            this.panel1.Controls.Add(this.btn1145);
            this.panel1.Controls.Add(this.btn1130);
            this.panel1.Controls.Add(this.btn1115);
            this.panel1.Controls.Add(this.btn1100);
            this.panel1.Controls.Add(this.btn1045);
            this.panel1.Controls.Add(this.btn1030);
            this.panel1.Controls.Add(this.btn1015);
            this.panel1.Controls.Add(this.btn1000);
            this.panel1.Controls.Add(this.btn945);
            this.panel1.Controls.Add(this.btn930);
            this.panel1.Controls.Add(this.btn915);
            this.panel1.Controls.Add(this.btn900);
            this.panel1.Location = new System.Drawing.Point(150, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 291);
            this.panel1.TabIndex = 62;
            // 
            // RandevuTarihSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(742, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RandevuTarihSaat";
            this.Text = "RandevuTarihSaat";
            this.Load += new System.EventHandler(this.RandevuTarihSaat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniRandevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaklaşanRandevularımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn900;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn915;
        private System.Windows.Forms.Button btn930;
        private System.Windows.Forms.Button btn945;
        private System.Windows.Forms.Button btn1000;
        private System.Windows.Forms.Button btn1015;
        private System.Windows.Forms.Button btn1030;
        private System.Windows.Forms.Button btn1045;
        private System.Windows.Forms.Button btn1100;
        private System.Windows.Forms.Button btn1115;
        private System.Windows.Forms.Button btn1130;
        private System.Windows.Forms.Button btn1145;
        private System.Windows.Forms.Button btn1330;
        private System.Windows.Forms.Button btn1345;
        private System.Windows.Forms.Button btn1400;
        private System.Windows.Forms.Button btn1415;
        private System.Windows.Forms.Button btn1430;
        private System.Windows.Forms.Button btn1445;
        private System.Windows.Forms.Button btn1500;
        private System.Windows.Forms.Button btn1515;
        private System.Windows.Forms.Button btn1530;
        private System.Windows.Forms.Button btn1545;
        private System.Windows.Forms.Panel panel1;
    }
}