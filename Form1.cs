using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace FormsProject
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> imagesNameToPath;
      

        public Form1()
        {
            InitializeComponent();
            imagesNameToPath = new Dictionary<string, string>();
            imagesNameToPath.Add("poza 1", "1.jpg");
            imagesNameToPath.Add("poza 2", "2.jpg");
            imagesNameToPath.Add("poza 3", "3.png");
            imagesNameToPath.Add("poza 4", "4.png");

            foreach(string key in imagesNameToPath.Keys) {
                chkLs.Items.Add(key);
            }

            lstView.SmallImageList = smallImages;
            lstView.LargeImageList = bigImages;

            ColumnHeader ch = new ColumnHeader("Nume");
            ch.Text = "Nume";
            ch.Width = 200;
            lstView.Columns.Add(ch);

            ch = new ColumnHeader("Fisier");
            ch.Width = 200;
            ch.Text = "Fisier";
            lstView.Columns.Add(ch);

            ch = new ColumnHeader("Cale");
            ch.Width = 200;
            ch.Text = "Cale";
            lstView.Columns.Add(ch);

            ch = new ColumnHeader("Dimensiune");
            ch.Width = 200;
            ch.Text = "Dimensiune";
            lstView.Columns.Add(ch);

            ch = new ColumnHeader(" Tipul imaginii");
            ch.Width = 200;
            ch.Text = "Tipul imaginii";
            lstView.Columns.Add(ch);

            ch = new ColumnHeader("Modified Date");
            ch.Width = 200;
            ch.Text = "Modified Date";
            lstView.Columns.Add(ch);


            lstView.Groups.Add("Categorie1", "Categorie1");
            lstView.Groups.Add("Categorie2", "Categorie2");
            
            //Poza 1
            ListViewItem lvi = new ListViewItem("poza 1", 0);
            lvi.Group = lstView.Groups[0];
            lvi.SubItems.Add("1.jpg");
            lvi.SubItems.Add(@"C:\Users\Alexandra\Pictures");
            
            FileStream file1 = new FileStream(@"C:\Users\Alexandra\Pictures\1.jpg", FileMode.Open);
            String size1 = String.Format("{0}",file1.Length/1024.0);
            file1.Close();
            lvi.SubItems.Add(size1 + "kb");
            string fileName1 = @"C:\Users\Alexandra\Pictures\1.jpg";
            string extention1;
            extention1 = Path.GetExtension(fileName1);
            lvi.SubItems.Add(extention1);
            FileInfo fInfo1 = new FileInfo(@"C:\Users\Alexandra\Pictures\1.jpg");
            String fLastTime1 = String.Format("{0}", fInfo1.LastWriteTime);
            lvi.SubItems.Add(fLastTime1);
            lstView.Items.Add(lvi);

            //Poza 2 
            lvi = new ListViewItem("poza 2", 1);
            lvi.Group = lstView.Groups[0];
            lvi.SubItems.Add("2.jpg");
            lvi.SubItems.Add(@"C:\Users\Alexandra\Pictures");


            FileStream file2 = new FileStream(@"C:\Users\Alexandra\Pictures\2.jpg", FileMode.Open);
            String size2 = String.Format("{0}", file2.Length / 1024.0);
            file2.Close();
            lvi.SubItems.Add(size2 + "kb");
            string fileName2 = @"C:\Users\Alexandra\Pictures\2.jpg";
            string extention2;
            extention2 = Path.GetExtension(fileName2);
            lvi.SubItems.Add(extention2);
            FileInfo fInfo2 = new FileInfo(@"C:\Users\Alexandra\Pictures\2.jpg");
            String fLastTime2 = String.Format("{0}", fInfo2.LastWriteTime);
            lvi.SubItems.Add(fLastTime2);
            lstView.Items.Add(lvi);

            //Poza 3
            lvi = new ListViewItem("poza 3", 2);
            lvi.Group = lstView.Groups[1];
            lvi.SubItems.Add("3.png");
            lvi.SubItems.Add(@"C:\Users\Alexandra\Pictures");

            FileStream file3 = new FileStream(@"C:\Users\Alexandra\Pictures\3.png ", FileMode.Open);
            String size3 = String.Format("{0}", file3.Length / 1024.0);
            file3.Close();
            lvi.SubItems.Add(size3 + "kb");
            string fileName3 = @"C:\Users\Alexandra\Pictures\3.png";
            string extention3;
            extention3 = Path.GetExtension(fileName3);
            lvi.SubItems.Add(extention3);
            FileInfo fInfo3 = new FileInfo(@"C:\Users\Alexandra\Pictures\3.png");
            String fLastTime3 = String.Format("{0}", fInfo3.LastWriteTime);
            lvi.SubItems.Add(fLastTime3);
            lstView.Items.Add(lvi);


            //Poza 4
            lvi = new ListViewItem("poza 4", 3);
            lvi.Group = lstView.Groups[1];
            lvi.SubItems.Add("4.png");
            lvi.SubItems.Add(@"C:\Users\Alexandra\Pictures");


            FileStream file4 = new FileStream(@"C:\Users\Alexandra\Pictures\4.png ", FileMode.Open);
            String size4 = String.Format("{0}", file4.Length / 1024.0);
            lvi.SubItems.Add(size4 + "kb");
            string fileName4 = @"C:\Users\Alexandra\Pictures\4.png";
            file4.Close();
            string extention4;
            extention4 = Path.GetExtension(fileName4);
            lvi.SubItems.Add(extention4);
            FileInfo fInfo4 = new FileInfo(@"C:\Users\Alexandra\Pictures\4.png");
        
            String fLastTime4 = String.Format("{0}", fInfo4.LastWriteTime);
            lvi.SubItems.Add( fLastTime4);
            lstView.Items.Add(lvi);

            lstView.View = View.Details;
        }

    

        private void btnShow_Click(object sender, EventArgs e)
        {
            List<Image> images = new List<Image>();
            foreach(string itemPath in lst.Items)
            {
                images.Add(Image.FromFile(@"C:\Users\Alexandra\Pictures\" + itemPath));
            }
            Form2 frm = new Form2(images);
            frm.Show();
        }

        private void chkLst_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string key = chkLs.Items[e.Index] as string;
            string picture = imagesNameToPath[key];
            if(e.NewValue == CheckState.Checked)
            {
                lst.Items.Add(picture);
            } else if (e.NewValue == CheckState.Unchecked)
            {
                lst.Items.Remove(picture);
            }
        }

        private void ChkLstSelectedIndexChanged(object sender, EventArgs e)
        {
            string key = chkLs.SelectedItem as string;
            string picture = imagesNameToPath[key];
           Image img = Image.FromFile(@"C:\Users\Alexandra\Pictures\" + picture);
           //img.Image = Image.FromFile(@"C:\Users\Alexandra\Pictures\2.jpg");// + picture);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = comboBox1.SelectedIndex;
            switch (i)
            { 
                case 0: lstView.View = View.SmallIcon; break;
                case 1: lstView.View = View.LargeIcon; break;
                case 2: lstView.View = View.Details; break;
                case 3: lstView.View = View.List; break;
                case 4: lstView.View = View.Tile; break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstView.SelectedItems.Count > 0)
            {
                ListViewItem item = lstView.SelectedItems[0];
                string path = item.SubItems[1].Text;
                Image img = Image.FromFile(@" C:\Users\Alexandra\Pictures\" + path);
            }
        }
    }
}

