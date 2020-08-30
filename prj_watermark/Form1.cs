using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj_watermark
{ 

    public partial class frm_watermark : Form
    {

        String proctype = "watermark";

        public frm_watermark()
        {
            InitializeComponent();
        }

        public void startPhotos(String[] files, String proctype, String txt_watermarkimage, String txt_wposition, String txt_fontsize, String txt_customtext,
                                        String txt_outputdir)
        {

            int totalran = 0;

            foreach (String f in files)
            {
                int x = 0; int y = 0;
                

                try
                {
                    Image image = Image.FromFile(f);
                    
                    if (proctype == "date" || proctype == "customtext")
                    {
                        // create a png watermark first
                        string text = "";
                        if (proctype == "date") text = GetImageDate(f); else text = txt_customtext;

                        DrawText(text, new Font("Arial", int.Parse(txt_fontsize), FontStyle.Bold), Color.Red, image.Width, Directory.GetCurrentDirectory() + "\\temp_watermark.png");
                        txt_watermarkimage = Directory.GetCurrentDirectory() + "\\temp_watermark.png";
                    }
                    
                    using (Image watermarkImage = Image.FromFile(txt_watermarkimage))
                    using (Graphics imageGraphics = Graphics.FromImage(image))

                    using (TextureBrush watermarkBrush = new TextureBrush(watermarkImage))
                    {
                        if (txt_wposition == "Center")
                        {
                            x = (image.Width / 2 - watermarkImage.Width / 2);
                            y = (image.Height / 2 - watermarkImage.Height / 2);
                        }

                        if (txt_wposition == "Top left")
                        {
                            x = 10;
                            y = 10;
                        }

                        if (txt_wposition == "Top right")
                        {
                            x = (image.Width - watermarkImage.Width) - 10;
                            y = 10;
                        }

                        if (txt_wposition == "Bottom right")
                        {
                            x = (image.Width - watermarkImage.Width) - 10;
                            y = (image.Height - watermarkImage.Height) - 10;
                        }

                        if (txt_wposition == "Bottom left")
                        {
                            x = 10;
                            y = (image.Height - watermarkImage.Height) - 10;
                        }

                        watermarkBrush.TranslateTransform(x, y);
                        imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(watermarkImage.Width + 1, watermarkImage.Height)));

                        image.Save(txt_outputdir + "\\" + Path.GetFileName(f));
                    }

                    outputlog.Invoke(new Action(() => outputlog.AppendText(DateTime.Now.ToString("hh:mm:ss").ToString() + " - File: " + Path.GetFileName(f) + " [DONE]" + Environment.NewLine) ));
                }
                catch (Exception ex)
                {
                    outputlog.Invoke(new Action(() => outputlog.AppendText(DateTime.Now.ToString("hh:mm:ss").ToString() + " - File: " + Path.GetFileName(f) + " [ERROR]" + ex.Message + Environment.NewLine)));
                }

                totalran++;
                int totalperc = (totalran * 100) / files.Length;
                progressBar1.Invoke(new Action(() => progressBar1.Value = totalperc));

            }

            // delete temp watermark
            if (File.Exists(Directory.GetCurrentDirectory() + "\\temp_watermark.png")) File.Delete(Directory.GetCurrentDirectory() + "\\temp_watermark.png");

            btn_start.Invoke(new Action(() => btn_start.Enabled = true));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputlog.Clear();
            progressBar1.Value = 0;

            if (!Directory.Exists(txt_imagesdir.Text))
            {
                MessageBox.Show("Images directory does not exist or must be selected");
                return;
            }
            if (!Directory.Exists(txt_outputdir.Text))
            {
                MessageBox.Show("Output Images directory does not exist or must be selected");
                return;
            }

            btn_start.Enabled = false;
            String[] files = Directory.GetFiles(txt_imagesdir.Text);
            //Thread thread = new Thread(() => startPhotos(files, proctype, txt_watermarkimage, txt_wposition, txt_fontsize, txt_customtext, txt_outputdir));


            String fontsize = txt_fontsize.Text;
            String wposition = txt_wposition.Text;

            ThreadStart starter = () => startPhotos(files, proctype, txt_watermarkimage.Text, wposition, fontsize, txt_customtext.Text, txt_outputdir.Text);
            Thread thread = new Thread(starter);
            thread.Start();


        }

        public static void DrawText(String text, Font font, Color textColor, int maxWidth, String path)
        {
            // from naveedmurtuza/TextToImage.cs
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);
            SizeF textSize = drawing.MeasureString(text, font, maxWidth);

            //set the stringformat flags to rtl
            StringFormat sf = new StringFormat();
            //uncomment the next line for right to left languages
            //sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            sf.Trimming = StringTrimming.Word;
            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap((int)textSize.Width, (int)textSize.Height);

            drawing = Graphics.FromImage(img);
            //Adjust for high quality
            drawing.CompositingQuality = CompositingQuality.HighQuality;
            drawing.InterpolationMode = InterpolationMode.HighQualityBilinear;
            drawing.PixelOffsetMode = PixelOffsetMode.HighQuality;
            drawing.SmoothingMode = SmoothingMode.HighQuality;
            drawing.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            //paint the background
            drawing.Clear(Color.Transparent);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, new RectangleF(0, 0, textSize.Width, textSize.Height), sf);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();
            img.Save(path, ImageFormat.Png);
            img.Dispose();

        }

        public static String GetImageDate(string filePath)
        {
            System.Drawing.Image myImage = Image.FromFile(filePath);
            String date = "  ";
            try
            {
                System.Drawing.Imaging.PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = new System.Text.RegularExpressions.Regex(":").Replace(System.Text.Encoding.UTF8.GetString(propItem.Value), "-", 2);
                date = System.DateTime.Parse(dateTaken).ToString();
            }
            catch (Exception e) { }

            return date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            image_watermark.ShowDialog();
        }

        private void image_watermark_FileOk(object sender, CancelEventArgs e)
        {
            txt_watermarkimage.Text = image_watermark.FileName.ToString() ;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (image_folder.ShowDialog() == DialogResult.OK)
            {
                txt_imagesdir.Text = image_folder.SelectedPath.ToString();
                lbl_totalimages.Text = "Total files to run:" + Directory.GetFiles(image_folder.SelectedPath.ToString()).Count().ToString();
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (image_outputfolder.ShowDialog() == DialogResult.OK)
            {
                txt_outputdir.Text = image_outputfolder.SelectedPath.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changePanels();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changePanels();
        }

        public void changePanels()
        {
            panel_watermark.Visible = false;
            panel_customtext.Visible = false;
            panel_textsize.Visible = false;

            if (radioButton1.Checked)
            {
                panel_watermark.Visible = true;
                panel_customtext.Visible = false;
                panel_textsize.Visible = false;
                proctype = "watermark";
            }

            if (radioButton2.Checked)
            {
                panel_watermark.Visible = false;
                panel_customtext.Visible = false;
                panel_textsize.Visible = true;
                proctype = "date";
            }

            if (radioButton3.Checked)
            {
                panel_watermark.Visible = false;
                panel_customtext.Visible = true;
                panel_textsize.Visible = true;
                proctype = "customtext";
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            image_watermark.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_wposition.SelectedIndex = 0;
            txt_fontsize.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
               System.Diagnostics.Process.Start("https://github.com/luizbossoi/image-watermark-helper");
        }

        private void outputlog_TextChanged(object sender, EventArgs e)
        {
            outputlog.SelectionStart = outputlog.Text.Length;
            outputlog.ScrollToCaret();
        }
    }
}
