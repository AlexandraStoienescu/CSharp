namespace FormsProject
{
    partial class Form2
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
            this.btnShow = new System.Windows.Forms.Button();
            this.img = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.chkImage1 = new System.Windows.Forms.CheckBox();
            this.chkImage2 = new System.Windows.Forms.CheckBox();
            this.chkImage3 = new System.Windows.Forms.CheckBox();
            this.radShowMsg = new System.Windows.Forms.RadioButton();
            this.radHideMsg = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerImages = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(52, 27);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 28);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Arata Poza";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(369, 76);
            this.img.Margin = new System.Windows.Forms.Padding(4);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(353, 375);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            this.img.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(200, 27);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(136, 28);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "button1";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // chkImage1
            // 
            this.chkImage1.AutoSize = true;
            this.chkImage1.Location = new System.Drawing.Point(96, 122);
            this.chkImage1.Margin = new System.Windows.Forms.Padding(4);
            this.chkImage1.Name = "chkImage1";
            this.chkImage1.Size = new System.Drawing.Size(78, 21);
            this.chkImage1.TabIndex = 3;
            this.chkImage1.Text = "Poza  1";
            this.chkImage1.UseVisualStyleBackColor = true;
            this.chkImage1.Visible = false;
            this.chkImage1.CheckedChanged += new System.EventHandler(this.chkImage1_CheckedChanged);
            // 
            // chkImage2
            // 
            this.chkImage2.AutoSize = true;
            this.chkImage2.Location = new System.Drawing.Point(96, 172);
            this.chkImage2.Margin = new System.Windows.Forms.Padding(4);
            this.chkImage2.Name = "chkImage2";
            this.chkImage2.Size = new System.Drawing.Size(78, 21);
            this.chkImage2.TabIndex = 4;
            this.chkImage2.Text = "Poza  2";
            this.chkImage2.UseVisualStyleBackColor = true;
            this.chkImage2.Visible = false;
            this.chkImage2.CheckedChanged += new System.EventHandler(this.chkImage2_CheckedChanged);
            // 
            // chkImage3
            // 
            this.chkImage3.AutoSize = true;
            this.chkImage3.Location = new System.Drawing.Point(96, 228);
            this.chkImage3.Margin = new System.Windows.Forms.Padding(4);
            this.chkImage3.Name = "chkImage3";
            this.chkImage3.Size = new System.Drawing.Size(74, 21);
            this.chkImage3.TabIndex = 5;
            this.chkImage3.Text = "Poza 3";
            this.chkImage3.UseVisualStyleBackColor = true;
            this.chkImage3.Visible = false;
            this.chkImage3.CheckedChanged += new System.EventHandler(this.chkImage3_CheckedChanged);
            // 
            // radShowMsg
            // 
            this.radShowMsg.AutoSize = true;
            this.radShowMsg.Checked = true;
            this.radShowMsg.Location = new System.Drawing.Point(73, 41);
            this.radShowMsg.Margin = new System.Windows.Forms.Padding(4);
            this.radShowMsg.Name = "radShowMsg";
            this.radShowMsg.Size = new System.Drawing.Size(123, 21);
            this.radShowMsg.TabIndex = 6;
            this.radShowMsg.TabStop = true;
            this.radShowMsg.Text = "Arata mesajele";
            this.radShowMsg.UseVisualStyleBackColor = true;
            this.radShowMsg.CheckedChanged += new System.EventHandler(this.radShowMsg_CheckedChanged);
            // 
            // radHideMsg
            // 
            this.radHideMsg.AutoSize = true;
            this.radHideMsg.Location = new System.Drawing.Point(73, 84);
            this.radHideMsg.Margin = new System.Windows.Forms.Padding(4);
            this.radHideMsg.Name = "radHideMsg";
            this.radHideMsg.Size = new System.Drawing.Size(144, 21);
            this.radHideMsg.TabIndex = 7;
            this.radHideMsg.Text = "Ascunde Mesajele";
            this.radHideMsg.UseVisualStyleBackColor = true;
            this.radHideMsg.CheckedChanged += new System.EventHandler(this.radHideMsg_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radShowMsg);
            this.groupBox1.Controls.Add(this.radHideMsg);
            this.groupBox1.Location = new System.Drawing.Point(73, 305);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(263, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // timerImages
            // 
            this.timerImages.Interval = 3000;
            this.timerImages.Tick += new System.EventHandler(this.timerImages_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkImage3);
            this.Controls.Add(this.chkImage2);
            this.Controls.Add(this.chkImage1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.img);
            this.Controls.Add(this.btnShow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Formular2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox chkImage1;
        private System.Windows.Forms.CheckBox chkImage2;
        private System.Windows.Forms.CheckBox chkImage3;
        private System.Windows.Forms.RadioButton radShowMsg;
        private System.Windows.Forms.RadioButton radHideMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerImages;
    }
}
