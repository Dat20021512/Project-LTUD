using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;


namespace ProjectLTUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool choose = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            splitToolStripMenuItem.Enabled = false;
            saveFile.Enabled = false;
            shiwFlip.Enabled = false;
            showHistogram.Enabled = false;
            toEDGE.Enabled = false;
            CvtGray.Enabled = false;
            CvtNegative.Enabled = false;
            changeBrightness.Enabled = false;
            contracst.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            showCropped.Enabled = false;
            cropImage.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            btnResize.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
        Mat src = new Mat();
        Mat img = new Mat();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picbox1.Image = new Bitmap(ofile.FileName);
                splitToolStripMenuItem.Enabled = true;
                saveFile.Enabled = true;
                shiwFlip.Enabled = true;
                showHistogram.Enabled = true;
                toEDGE.Enabled = true;
                CvtGray.Enabled = true;
                CvtNegative.Enabled = true;
                changeBrightness.Enabled = true;
                contracst.Enabled = true;
                cropImage.Enabled = true;
                btnResize.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                string src_img = ofile.FileName;
                img = Cv2.ImRead(src_img);
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPEG files(*.jpeg)|*.jpeg";

            if (DialogResult.OK == save.ShowDialog())
            {
                this.picbox2.Image.Save(save.FileName);
            }
        }

        private void exitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CvtGray_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;

            Mat img_gray = new Mat();
            Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);
            picbox2.Image = img_gray.ToBitmap();
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void CvtNegative_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;

            Mat img_negative = new Mat();
            Cv2.BitwiseNot(img, img_negative);
            picbox2.Image = img_negative.ToBitmap();
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void toEDGE_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;

            Mat imgToEDGE = new Mat();
            Cv2.GaussianBlur(img, img, new OpenCvSharp.Size(3, 3), 2);
            Cv2.Canny(img, imgToEDGE, 50, 120);
            picbox2.Image = imgToEDGE.ToBitmap();
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private int rotationAngle = 0;

        private void showHistogram_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;

            picbox2.Image = ImgSetDlg.RotateImage(picbox1.Image, 0);
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void changeBrightness_Click(object sender, EventArgs e)
        {
            IDD_DLG_SETTING bnForm = new IDD_DLG_SETTING();
            bnForm.ShowDialog();
            Bitmap pic1 = new Bitmap(this.picbox1.Image);
            ImgSetDlg.SetBrightness(bnForm.getBrightness(), pic1);
            picbox2.Image = pic1;
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout abForm = new FormAbout();
            abForm.ShowDialog();
        }

        private void contracst_Click(object sender, EventArgs e)
        {
            FormContrast ContrForm = new FormContrast();
            ContrForm.ShowDialog();
            Bitmap pic1 = new Bitmap(picbox1.Image);
            ImgSetDlg.SetContrast(ContrForm.getContrast(), pic1);
            picbox2.Image = pic1;
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;

            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rotationAngle -= 90;
            if (rotationAngle == 360 || rotationAngle == -360) rotationAngle = 0;
            picbox2.Image = ImgSetDlg.RotateImage(picbox2.Image, rotationAngle);
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rotationAngle += 90;
            if (rotationAngle == 360 || rotationAngle == -360) rotationAngle = 0;
            picbox2.Image = ImgSetDlg.RotateImage(picbox2.Image, rotationAngle);
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void shiwFlip_Click(object sender, EventArgs e)
        {
            picbox2.Image = picbox1.Image;
            picbox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;

            button1.Enabled = true;
            button2.Enabled = true;
        }

        int crpX, crpY, rectW, rectH;
        public Pen crpPen = new Pen(Color.White);

        Mat[] RGB = new Mat[3];
        private void splitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Tách ảnh màu sang 3 kênh
            RGB = Cv2.Split(img);
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            picbox2.Image = img.ToBitmap();
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
            MessageBox.Show("Split sucessful");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            picbox2.Image = RGB[0].ToBitmap();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            picbox2.Image = RGB[1].ToBitmap();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            picbox2.Image = RGB[2].ToBitmap();
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            picbox2.Image = img.ToBitmap();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(picbox1.Image, Int16.Parse(textBox1.Text), Int16.Parse(textBox2.Text));
            picbox2.SizeMode = PictureBoxSizeMode.CenterImage;
            picbox2.Image = bmp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picbox1.Image = null;
            picbox2.Image = null;

            splitToolStripMenuItem.Enabled = false;
            saveFile.Enabled = false;
            shiwFlip.Enabled = false;
            showHistogram.Enabled = false;
            toEDGE.Enabled = false;
            CvtGray.Enabled = false;
            CvtNegative.Enabled = false;
            changeBrightness.Enabled = false;
            contracst.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            showCropped.Enabled = false;
            cropImage.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            btnResize.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picbox1.MouseDown += new MouseEventHandler(picbox1_MouseDown);
            picbox1.MouseMove += new MouseEventHandler(picbox1_MouseMove);
            picbox1.MouseEnter += new EventHandler(picbox1_MouseEnter);
            Controls.Add(picbox1);
            showCropped.Enabled = true;
        }

        private void showCropped_Click(object sender, EventArgs e)
        {
            showCropped.Text = "Show_Cropped";
            Cursor = Cursors.Default;
            //Now we will draw the cropped image into pictureBox2
            Bitmap bmp2 = new Bitmap(picbox1.Width, picbox1.Height);
            picbox1.DrawToBitmap(bmp2, picbox1.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            picbox2.Image = (Image)crpImg;
            picbox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void picbox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                crpX = e.X;
                crpY = e.Y;
            }
        }

        private void picbox1_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                picbox1.Refresh();
                //set width and height for crop rectangle.
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = picbox1.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }

        private void picbox1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }
    }
}
