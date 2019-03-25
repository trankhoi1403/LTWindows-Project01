using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        #region Properties
        string filePicture = null;     // đường dẫn file hình ảnh
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                filePicture = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(filePicture);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Show();
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Không thể mở file");
            }
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(pictureBox1.ImageLocation == null)
            {
                checkBoxHelp.Enabled = false;
                checkBoxRemote.Enabled = false;
            }
            else
            {
                checkBoxHelp.Enabled = true;
                checkBoxRemote.Enabled = true;
            }
        }

    }
}