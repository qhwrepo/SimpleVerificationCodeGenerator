using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificationCodeGenerator
{
    public partial class VerificationCodeGenerator : Form
    {
        const int Digits = 4;
        private string Code;
        public VerificationCodeGenerator()
        {
            InitializeComponent();
            //Generate New V-Code
            Generate();
            
        }

        private void Generate()
        {
            Code = GenerateCodeString();
            Bitmap bm = GenerateImage();
            picBox_Image.Image = bm;
        }

        private Bitmap GenerateImage()
        {
            Pen pen = new Pen(Color.Black);
            Font font = new Font("Arial", 14, FontStyle.Bold);
            Brush brush = null;
            Bitmap bitmap = new Bitmap(picBox_Image.Width, picBox_Image.Height);
            Graphics g = Graphics.FromImage(bitmap);
            SizeF totalSizeF = g.MeasureString(Code, font);
            SizeF curCharSizeF;
            PointF startPointF = new PointF((picBox_Image.Width - totalSizeF.Width) / 2, (picBox_Image.Height - totalSizeF.Height) / 2);
            Random random = new Random();
            g.Clear(Color.White);
            for (int i = 0; i < Digits; i++)
            {
                brush = new LinearGradientBrush(new Point(0, 0), new Point(1, 1), Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)), Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
                g.DrawString(Code[i].ToString(), font, brush, startPointF);
                curCharSizeF = g.MeasureString(Code[i].ToString(), font);
                startPointF.X += curCharSizeF.Width;
            }
            g.Dispose();
            return bitmap;
        }

        private string GenerateCodeString()
        {
            char code;
            string checkcode = string.Empty;
            Random random = new Random();
            for (int i = 0; i < Digits; i++)
            {
                code = random.Next(0, 1) == 0 ? (char)('0' + (char)random.Next(0, 9)) : (char)('A' + (char)random.Next(0, 25));
                checkcode += code.ToString();
            }
            return checkcode;
        }

        private void lbl_Change_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            if (txtBox_Code.Text == Code)
                MessageBox.Show("Verification Code Correct");
            else
                MessageBox.Show("Verification Code Incorrect");
            txtBox_Code.Text = "";
            Generate();
        }

        private void lab_Change_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Generate();
        }
    }
}
