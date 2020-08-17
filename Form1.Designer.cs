namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ımageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.newFile = new System.Windows.Forms.Button();
            this.L800 = new System.Windows.Forms.Button();
            this.Elements = new System.Windows.Forms.ListBox();
            this.L1800Name = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backScript = new System.Windows.Forms.Button();
            this.u900Full = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dosya Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 523);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(488, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ımageList
            // 
            this.ımageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.ımageList;
            this.listView.Location = new System.Drawing.Point(15, 347);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(488, 102);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // newFile
            // 
            this.newFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newFile.Location = new System.Drawing.Point(285, 468);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(218, 39);
            this.newFile.TabIndex = 3;
            this.newFile.Text = "Log Dosyasını Aç";
            this.newFile.UseVisualStyleBackColor = true;
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // L800
            // 
            this.L800.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.L800.Location = new System.Drawing.Point(523, 47);
            this.L800.Name = "L800";
            this.L800.Size = new System.Drawing.Size(138, 56);
            this.L800.TabIndex = 5;
            this.L800.Text = "L800 isim değiştirme";
            this.L800.UseVisualStyleBackColor = true;
            this.L800.Click += new System.EventHandler(this.L800_Click);
            // 
            // Elements
            // 
            this.Elements.FormattingEnabled = true;
            this.Elements.Location = new System.Drawing.Point(12, 25);
            this.Elements.Name = "Elements";
            this.Elements.Size = new System.Drawing.Size(491, 290);
            this.Elements.TabIndex = 6;
            this.Elements.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // L1800Name
            // 
            this.L1800Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.L1800Name.Location = new System.Drawing.Point(667, 47);
            this.L1800Name.Name = "L1800Name";
            this.L1800Name.Size = new System.Drawing.Size(138, 56);
            this.L1800Name.TabIndex = 7;
            this.L1800Name.Text = "L1800 isim değiştirme";
            this.L1800Name.UseVisualStyleBackColor = true;
            this.L1800Name.Click += new System.EventHandler(this.L1800Name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seçilen Dosyanın İçeriğindeki Fileslar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "İsmi Değiştirilen Dosyalar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(742, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Swap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(716, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Co-Located";
            // 
            // backScript
            // 
            this.backScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backScript.Location = new System.Drawing.Point(523, 160);
            this.backScript.Name = "backScript";
            this.backScript.Size = new System.Drawing.Size(138, 56);
            this.backScript.TabIndex = 13;
            this.backScript.Text = "L800";
            this.backScript.UseVisualStyleBackColor = true;
            this.backScript.Click += new System.EventHandler(this.backScript_Click);
            // 
            // u900Full
            // 
            this.u900Full.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.u900Full.Location = new System.Drawing.Point(666, 160);
            this.u900Full.Name = "u900Full";
            this.u900Full.Size = new System.Drawing.Size(138, 56);
            this.u900Full.TabIndex = 14;
            this.u900Full.Text = "U2100 TAM";
            this.u900Full.UseVisualStyleBackColor = true;
            this.u900Full.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(811, 160);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 56);
            this.button4.TabIndex = 15;
            this.button4.Text = "U2100 Eksik";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(524, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 56);
            this.button3.TabIndex = 16;
            this.button3.Text = "L1800";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(666, 222);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 56);
            this.button5.TabIndex = 17;
            this.button5.Text = "U900 TAM";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(811, 222);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(138, 56);
            this.button6.TabIndex = 18;
            this.button6.Text = "U900 Eksik";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(811, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 58);
            this.button7.TabIndex = 19;
            this.button7.Text = "L2600 isim değiştirme";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(554, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(382, 140);
            this.label5.TabIndex = 20;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 595);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.u900Full);
            this.Controls.Add(this.backScript);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L1800Name);
            this.Controls.Add(this.Elements);
            this.Controls.Add(this.L800);
            this.Controls.Add(this.newFile);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ImageList ımageList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button newFile;
        private System.Windows.Forms.Button L800;
        private System.Windows.Forms.ListBox Elements;
        private System.Windows.Forms.Button L1800Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backScript;
        private System.Windows.Forms.Button u900Full;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
    }
}

