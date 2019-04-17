using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
    public partial class Form2 : Form
    {
        private List<Image> defaultImages;
        private List<Image> images;
        private int imageIndex;
        private bool showMessage;

        public Form2(List<Image> imagesP)
        {
            InitializeComponent();
            images = imagesP;
            imageIndex = 0;
            btnNext.Text = "Urmatoarea poza";
            //fillImages();
            showMessage = radShowMsg.Checked;
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            imageIndex = 0;
            img.Visible = true;
            //timerImages.Start();
          if (images.Count == 0)
            {
                if (showMessage)
                    MessageBox.Show("Nu sunt poze selectate ");
            }
            else
            {
                img.Image = images[imageIndex];
                img.Visible = true;
                imageIndex++;
            }
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            img.Visible = false;
            //timerImages.Stop();
            
            if (imageIndex < images.Count)
            {
                img.Image = images[imageIndex];
                imageIndex++;
                img.Visible = true;
            }
            else
            {
                if(showMessage)
                    MessageBox.Show("Nu mai exista poze ");
            }
            
        }

        private void chkImage1_CheckedChanged(object sender, EventArgs e)
        {
            fillImages();
        }

        private void chkImage2_CheckedChanged(object sender, EventArgs e)
        {
            fillImages();
        }

        private void chkImage3_CheckedChanged(object sender, EventArgs e)
        {
            fillImages();
        }

        void fillImages()
        {
            images.Clear();
            if (chkImage1.Checked)
            {
                images.Add(defaultImages[0]);
            }
            if (chkImage2.Checked)
            {
                images.Add(defaultImages[1]);
            }
            if (chkImage3.Checked)
            {
                images.Add(defaultImages[2]);
            }
            if(images.Count == 0)
            {
                img.Visible = false;
            }
            else
            {
                if (img.Visible)
                {
                    imageIndex = 0;
                    img.Image = images[0];
                }
            }

        }

        private void radHideMsg_CheckedChanged(object sender, EventArgs e)
        {
            showMessage = false;
        }

        private void radShowMsg_CheckedChanged(object sender, EventArgs e)
        {
            showMessage = true;
        }

        private void timerImages_Tick(object sender, EventArgs e)
        {
            img.Image = defaultImages[imageIndex++];
            if (imageIndex >= defaultImages.Count)
                imageIndex = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
