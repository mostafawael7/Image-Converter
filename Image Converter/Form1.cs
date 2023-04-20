using ImageMagick;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Image_Converter
{
    public partial class Form1 : Form
    {
        //public static string filename;
        public static List<string> images;
        public Form1()
        {
            InitializeComponent();
            images = new List<string>();
        }

        private void pickImage_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.heic)|*.heic";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                //pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
                //filename = open.FileName;
                textBox1.Text = "Success";
                foreach (string file in open.FileNames)
                {
                    images.Add(file);
                }
            }
        }

        private void convertImage_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select an image first");
                return;
            }
            foreach(string file in images)
            {
                var image = new MagickImage(file);
                image.Write(file.Replace("HEIC", "JPG"));
            }
        }
    }
}
