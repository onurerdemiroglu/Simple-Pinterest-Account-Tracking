namespace PinterestToken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToplamHesapBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ToplamDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toplamshadow = new System.Windows.Forms.TextBox();
            this.Hesap = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.resimlink = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hesap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 644);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.Hesap);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1322, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pinterest Hesap Takip";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ToplamHesapBan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ToplamDomain);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.toplamshadow);
            this.groupBox1.Location = new System.Drawing.Point(241, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 66);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İstatistik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(893, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "İşlem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Toplam Hesap Ban:";
            // 
            // ToplamHesapBan
            // 
            this.ToplamHesapBan.Location = new System.Drawing.Point(164, 26);
            this.ToplamHesapBan.Name = "ToplamHesapBan";
            this.ToplamHesapBan.Size = new System.Drawing.Size(114, 26);
            this.ToplamHesapBan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Domain Ban:";
            // 
            // ToplamDomain
            // 
            this.ToplamDomain.Location = new System.Drawing.Point(750, 29);
            this.ToplamDomain.Name = "ToplamDomain";
            this.ToplamDomain.Size = new System.Drawing.Size(114, 26);
            this.ToplamDomain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Shadow Sayısı:";
            // 
            // toplamshadow
            // 
            this.toplamshadow.Location = new System.Drawing.Point(467, 26);
            this.toplamshadow.Name = "toplamshadow";
            this.toplamshadow.Size = new System.Drawing.Size(114, 26);
            this.toplamshadow.TabIndex = 0;
            // 
            // Hesap
            // 
            this.Hesap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hesap.Location = new System.Drawing.Point(15, 69);
            this.Hesap.Name = "Hesap";
            this.Hesap.Size = new System.Drawing.Size(1301, 536);
            this.Hesap.TabIndex = 29;
            this.Hesap.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Hesap_CellContentDoubleClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(29, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 48);
            this.button3.TabIndex = 22;
            this.button3.Text = "Hesap takip";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // resimlink
            // 
            this.resimlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resimlink.FormattingEnabled = true;
            this.resimlink.ItemHeight = 20;
            this.resimlink.Location = new System.Drawing.Point(1983, 1013);
            this.resimlink.Name = "resimlink";
            this.resimlink.Size = new System.Drawing.Size(65, 64);
            this.resimlink.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 663);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.resimlink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pinterest Hesap Takip";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hesap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView Hesap;
        private System.Windows.Forms.ListBox resimlink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToplamHesapBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ToplamDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toplamshadow;
        private System.Windows.Forms.Label label4;
    }
}

