namespace FormsProject
{
    partial class Form1
    {
         
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnShow = new System.Windows.Forms.Button();
            this.chkLs = new System.Windows.Forms.CheckedListBox();
            this.lst = new System.Windows.Forms.ListBox();
            this.file1 = new System.Windows.Forms.PictureBox();
            this.bigImages = new System.Windows.Forms.ImageList(this.components);
            this.lstView = new System.Windows.Forms.ListView();
            this.smallImages = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.file1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(719, 442);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(144, 28);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "ArataPoze";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // chkLs
            // 
            this.chkLs.FormattingEnabled = true;
            this.chkLs.Location = new System.Drawing.Point(35, 15);
            this.chkLs.Margin = new System.Windows.Forms.Padding(4);
            this.chkLs.Name = "chkLs";
            this.chkLs.Size = new System.Drawing.Size(129, 106);
            this.chkLs.TabIndex = 1;
            this.chkLs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkLst_ItemCheck);
            this.chkLs.SelectedIndexChanged += new System.EventHandler(this.ChkLstSelectedIndexChanged);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 16;
            this.lst.Location = new System.Drawing.Point(196, 14);
            this.lst.Margin = new System.Windows.Forms.Padding(4);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(137, 132);
            this.lst.TabIndex = 2;
            // 
            // file1
            // 
            this.file1.Location = new System.Drawing.Point(689, 15);
            this.file1.Margin = new System.Windows.Forms.Padding(4);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(227, 290);
            this.file1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.file1.TabIndex = 3;
            this.file1.TabStop = false;
            // 
            // bigImages
            // 
            this.bigImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("bigImages.ImageStream")));
            this.bigImages.TransparentColor = System.Drawing.Color.Transparent;
            this.bigImages.Images.SetKeyName(0, "1.jpg");
            this.bigImages.Images.SetKeyName(1, "2.jpg");
            this.bigImages.Images.SetKeyName(2, "3.jpg");
            this.bigImages.Images.SetKeyName(3, "4.png");
            // 
            // lstView
            // 
            this.lstView.LargeImageList = this.bigImages;
            this.lstView.Location = new System.Drawing.Point(52, 154);
            this.lstView.Margin = new System.Windows.Forms.Padding(4);
            this.lstView.MultiSelect = false;
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(581, 368);
            this.lstView.SmallImageList = this.smallImages;
            this.lstView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstView.TabIndex = 4;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // smallImages
            // 
            this.smallImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImages.ImageStream")));
            this.smallImages.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImages.Images.SetKeyName(0, "1.jpg");
            this.smallImages.Images.SetKeyName(1, "2.jpg");
            this.smallImages.Images.SetKeyName(2, "3.jpg");
            this.smallImages.Images.SetKeyName(3, "4.png");
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cu icoane mici",
            "Cu icoane mari",
            "Detaliat",
            "Lista",
            "Tile"});
            this.comboBox1.Location = new System.Drawing.Point(387, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Detaliat";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 538);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.chkLs);
            this.Controls.Add(this.btnShow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Formular principal";
            ((System.ComponentModel.ISupportInitialize)(this.file1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckedListBox chkLs;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.PictureBox file1;
        private System.Windows.Forms.ImageList bigImages;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ImageList smallImages;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

