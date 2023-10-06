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
using System.Drawing.Imaging;

namespace ThemLogoVaoAnh
{
    public partial class FormThemLogoVaoAnh : Form
    {
        public FormThemLogoVaoAnh()
        {
            InitializeComponent();
            this.folderBrowserDialog1.Description =
            "Chọn thư mục chứa ảnh";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
        }

        private void FormThemLogoVaoAnh_Load(object sender, EventArgs e)
        {

            cbxX.Items.Add("Giữa");
            cbxY.Items.Add("Giữa");
            cbxX.Items.Add("Trên");
            cbxY.Items.Add("Trên");
            cbxX.Items.Add("Dưới");
            cbxY.Items.Add("Dưới");
            cbxX.Items.Add("Trái");
            cbxY.Items.Add("Trái");
            cbxX.Items.Add("Phải");
            cbxY.Items.Add("Phải");
            cbxX.Items.Add("Góc Phải Dưới");
            cbxY.Items.Add("Góc Phải Dưới");
            cbxX.Items.Add("Góc Trái Dưới");
            cbxY.Items.Add("Góc Trái Dưới");
            cbxX.Items.Add("Góc Phải Trên");
            cbxY.Items.Add("Góc Phải Trên");
            cbxX.Items.Add("Góc Trái Trên");
            cbxY.Items.Add("Góc Trái Trên");
            cbmau.Items.Add("Red");
            cbmau.Items.Add("Yellow");
            cbmau.Items.Add("White");
            cbmau.Items.Add("Black");
            cbmau.Items.Add("Blue");
            cbmau.Items.Add("Orange");
            cbmau.Items.Add("Green");
            cbmau.Items.Add("Silver");
            cbmau.Items.Add("WhiteSmoke");
            cbmau.Items.Add("Gold");
            cbmau.Items.Add("Gray");
            cbmau.Items.Add("LightGreen");
            cbmau.Items.Add("LightYellow");
            cbmau.SelectedIndex = 0;
            chkauto.Checked = false;
            cbxX.Enabled = false;
            cbxY.Enabled = false;
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "/luu.txt");
                string Line = sr.ReadLine();
                while ((Line != null) && (Line != " "))
                {
                    string[] mang = Line.Split(';');
                    txtchu.Text = mang[0];
                    cbmau.SelectedIndex = int.Parse(mang[1]);
                    txtsize.Text = mang[2];
                    Line = sr.ReadLine();
                }
                sr.Close();
            }
            catch { }

        }
        private void btnthumuc_Click(object sender, EventArgs e)
        {
            if (cbxX.Text != cbxY.Text)
            {
                MessageBox.Show("Vui lòng chọn thông số của X và Y giống nhau");
            }
            else
            {
                string path = String.Empty;
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    path = folderBrowserDialog1.SelectedPath;
                }

                if (path == String.Empty)
                {

                    return;
                }
                Image img = null;
                string fullPath = String.Empty;

                try
                {
                    string[] imgExtension = { "*.png", "*.jpg", "*.jpeg", ".gif", "*.bmp" };
                    List<FileInfo> files = new List<FileInfo>();

                    DirectoryInfo dir = new DirectoryInfo(path);

                    foreach (string ext in imgExtension)
                    {
                        FileInfo[] folder = dir.GetFiles(ext, SearchOption.AllDirectories);
                        foreach (FileInfo file in folder)
                        {
                            FileStream fs = file.OpenRead();
                            fullPath = path + @"\" + file.Name;

                            Stream outputStream = new MemoryStream();
                            AddWatermark(fs, txtchu, outputStream);
                            fs.Close();
                            file.Delete();
                            img = Image.FromStream(outputStream);

                            using (Bitmap savingImage = new Bitmap(img.Width, img.Height, img.PixelFormat))
                            {
                                using (Graphics g = Graphics.FromImage(savingImage))
                                    g.DrawImage(img, new Point(0, 0));
                                savingImage.Save(fullPath, ImageFormat.Jpeg);
                            }
                            img.Dispose();
                        }
                    }
                    MessageBox.Show("Thêm Logo vào hình xong");
                    try
                    {
                        StreamWriter sw = new StreamWriter(Application.StartupPath + "/luu.txt");
                        string Line = "";
                        Line = txtchu.Text + ";" + cbmau.SelectedIndex + ";" + txtsize.Text + ";";
                        sw.WriteLine(Line);
                        sw.Close();
                    }
                    catch
                    { }
                }
                catch
                {
                    MessageBox.Show("Lỗi rồi kiểm tra lại đi, VD: tên màu đúng chưa?");
                }
                finally
                {
                    if (img != null)
                        img.Dispose();
                }
            }
        }
        public void AddWatermark(FileStream fs, TextBox watermarkText, Stream outputStream)
        {
            Image img = Image.FromStream(fs);
            int width;
            int height;
            if (!chkauto.Checked)
            {
                width = Int16.Parse(txtX.Text);
                height = Int16.Parse(txtY.Text);
            }
            else
            {
                if (!checkBox1.Checked)
                {
                    if (cbxX.Text == "Giữa" && cbxY.Text == "Giữa")
                    {
                        width = (img.Width / 2) - 235;
                        height = (img.Height / 2) - 100;
                    }
                    else
                    {
                        width = 500;
                        height = 500;
                    }
                    if (cbxX.Text == "Trên" && cbxY.Text == "Trên")
                    {
                        width = (img.Width / 2) - 235;
                        height = (img.Height / 2) - 1070;
                    }
                    if (cbxX.Text == "Dưới" && cbxY.Text == "Dưới")
                    {
                        width = (img.Width / 2) - 235;
                        height = (img.Height / 2) + 910;
                    }
                    if (cbxX.Text == "Góc Phải Dưới" && cbxY.Text == "Góc Phải Dưới")
                    {
                        width = (img.Width / 2) + 1500;
                        height = (img.Height / 2) + 910;
                    }
                    if (cbxX.Text == "Góc Trái Dưới" && cbxY.Text == "Góc Trái Dưới")
                    {
                        width = (img.Width / 2) - 1900;
                        height = (img.Height / 2) + 910;
                    }
                    if (cbxX.Text == "Trái" && cbxY.Text == "Trái")
                    {
                        width = (img.Width / 2) - 1900;
                        height = (img.Height / 2) - 100;
                    }
                    if (cbxX.Text == "Phải" && cbxY.Text == "Phải")
                    {
                        width = (img.Width / 2) + 1500;
                        height = (img.Height / 2) - 100;
                    }
                    if (cbxX.Text == "Góc Trái Trên" && cbxY.Text == "Góc Trái Trên")
                    {
                        width = (img.Width / 2) - 1900;
                        height = (img.Height / 2) - 1070;
                    }
                    if (cbxX.Text == "Góc Phải Trên" && cbxY.Text == "Góc Phải Trên")
                    {
                        width = (img.Width / 2) + 1500;
                        height = (img.Height / 2) - 1070;
                    }
                }
                else
                {
                    if (cbxX.Text == "Giữa" && cbxY.Text == "Giữa")
                    {
                        width = (img.Width / 2) - 40;
                        height = (img.Height / 2) - 1750;
                    }
                    else
                    {
                        width = 500;
                        height = 500;
                    }
                    if (cbxX.Text == "Trên" && cbxY.Text == "Trên")
                    {
                        width = (img.Width / 2) - 600;
                        height = (img.Height / 2) - 2350;
                    }
                    if (cbxX.Text == "Dưới" && cbxY.Text == "Dưới")
                    {
                        width = (img.Width / 2) - (-550);
                        height = (img.Height / 2) - 1150;
                    }
                    if (cbxX.Text == "Góc Phải Dưới" && cbxY.Text == "Góc Phải Dưới")
                    {
                        width = (img.Width / 2) -(-1850);
                        height = (img.Height / 2) - 2350;
                    }
                    if (cbxX.Text == "Góc Trái Dưới" && cbxY.Text == "Góc Trái Dưới")
                    {
                        width = (img.Width / 2) - 600;
                        height = (img.Height / 2) - 10;
                    }
                    if (cbxX.Text == "Trái" && cbxY.Text == "Trái")
                    {
                        width = (img.Width / 2) + (-1200);
                        height = (img.Height / 2) - 500;
                    }
                    if (cbxX.Text == "Phải" && cbxY.Text == "Phải")
                    {
                        width = (img.Width / 2) - (-1100);
                        height = (img.Height / 2) - 3000;
                    }
                    if (cbxX.Text == "Góc Trái Trên" && cbxY.Text == "Góc Trái Trên")
                    {
                        width = (img.Width / 2) +(-1850);
                        height = (img.Height / 2) - 1150;
                    }
                    if (cbxX.Text == "Góc Phải Trên" && cbxY.Text == "Góc Phải Trên")
                    {
                        width = (img.Width / 2) - (-600);
                        height = (img.Height / 2) - 3500;
                    }
                }
            }

            int size;
            Font font;
            if (chkauto.Checked) size = img.Width * 10 / watermarkText.Width;
            else
                size = int.Parse(txtsize.Text);
            font = new Font("Tamoha", size, FontStyle.Bold, GraphicsUnit.Pixel);
            Color color = Color.FromName(cbmau.SelectedItem.ToString());
            Point pt = new Point(width, height);
            SolidBrush sbrush = new SolidBrush(color);
            Graphics gr = null;
            try
            {
                gr = Graphics.FromImage(img);
            }
            catch
            {
                Image img1 = img;
                img = new Bitmap(img.Width, img.Height);
                gr = Graphics.FromImage(img);
                gr.DrawImage(img1, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel);
                img1.Dispose();
            }
            if (checkBox1.Checked)
            {
                gr.MeasureString(watermarkText.Text.ToString(), font);
                gr.RotateTransform(45);
            }
            gr.DrawString(watermarkText.Text.ToString(), font, sbrush, pt);
            gr.Dispose();
            img.Save(outputStream, ImageFormat.Jpeg);
        }

        private void txtsize_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtsize.Text);
                if (int.Parse(txtsize.Text) <= 0)
                {
                    MessageBox.Show("nhập size không đúng, xem lại đi..");
                    txtsize.Focus();
                }
            }
            catch
            {
                MessageBox.Show("nhập size không đúng, xem lại đi..");
                txtsize.Focus();
            }
        }

        private void chkauto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkauto.Checked)
            {
                txtsize.Clear();
                txtsize.Enabled = false;
                txtX.Enabled = false;
                txtY.Enabled = false;
                cbxX.Enabled = true;
                cbxY.Enabled = true;
            }
            else
            {
                txtsize.Enabled = true;
                txtX.Enabled = true;
                txtY.Enabled = true;
                cbxX.Enabled = false;
                cbxY.Enabled = false;
            }
        }

        private void checkBoxLamMo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}


