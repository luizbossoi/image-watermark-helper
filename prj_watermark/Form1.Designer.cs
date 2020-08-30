namespace prj_watermark
{
    partial class frm_watermark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_totalimages = new System.Windows.Forms.Label();
            this.txt_outputdir = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_wposition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_imagesdir = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.image_watermark = new System.Windows.Forms.OpenFileDialog();
            this.image_folder = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_customtext = new System.Windows.Forms.Panel();
            this.txt_customtext = new System.Windows.Forms.TextBox();
            this.lbl_customtext = new System.Windows.Forms.Label();
            this.panel_watermark = new System.Windows.Forms.Panel();
            this.txt_watermarkimage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_textsize = new System.Windows.Forms.Panel();
            this.lbl_fontsizepx = new System.Windows.Forms.Label();
            this.txt_fontsize = new System.Windows.Forms.ComboBox();
            this.lbl_fontsize = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.image_outputfolder = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.outputlog = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_customtext.SuspendLayout();
            this.panel_watermark.SuspendLayout();
            this.panel_textsize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(357, 451);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(133, 40);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_totalimages);
            this.panel1.Controls.Add(this.txt_outputdir);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_wposition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_imagesdir);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 153);
            this.panel1.TabIndex = 1;
            // 
            // lbl_totalimages
            // 
            this.lbl_totalimages.AutoSize = true;
            this.lbl_totalimages.Location = new System.Drawing.Point(257, 37);
            this.lbl_totalimages.Name = "lbl_totalimages";
            this.lbl_totalimages.Size = new System.Drawing.Size(61, 13);
            this.lbl_totalimages.TabIndex = 6;
            this.lbl_totalimages.Text = "                  ";
            // 
            // txt_outputdir
            // 
            this.txt_outputdir.Location = new System.Drawing.Point(117, 65);
            this.txt_outputdir.Name = "txt_outputdir";
            this.txt_outputdir.ReadOnly = true;
            this.txt_outputdir.Size = new System.Drawing.Size(212, 20);
            this.txt_outputdir.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(335, 63);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Select output Directory";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Output Directory:";
            // 
            // txt_wposition
            // 
            this.txt_wposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_wposition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_wposition.FormattingEnabled = true;
            this.txt_wposition.Items.AddRange(new object[] {
            "Center",
            "Top left",
            "Top right",
            "Bottom left",
            "Bottom right"});
            this.txt_wposition.Location = new System.Drawing.Point(117, 91);
            this.txt_wposition.Name = "txt_wposition";
            this.txt_wposition.Size = new System.Drawing.Size(212, 21);
            this.txt_wposition.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Watermark Position:";
            // 
            // txt_imagesdir
            // 
            this.txt_imagesdir.Location = new System.Drawing.Point(117, 15);
            this.txt_imagesdir.Name = "txt_imagesdir";
            this.txt_imagesdir.ReadOnly = true;
            this.txt_imagesdir.Size = new System.Drawing.Size(212, 20);
            this.txt_imagesdir.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Select JPG Directory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Images Directory:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // image_watermark
            // 
            this.image_watermark.Filter = "PNG Images|*.png";
            this.image_watermark.FileOk += new System.ComponentModel.CancelEventHandler(this.image_watermark_FileOk);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Images and Watermark Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Watermark configuration";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel_customtext);
            this.panel2.Controls.Add(this.panel_watermark);
            this.panel2.Controls.Add(this.panel_textsize);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(15, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 115);
            this.panel2.TabIndex = 5;
            // 
            // panel_customtext
            // 
            this.panel_customtext.Controls.Add(this.txt_customtext);
            this.panel_customtext.Controls.Add(this.lbl_customtext);
            this.panel_customtext.Location = new System.Drawing.Point(4, 84);
            this.panel_customtext.Name = "panel_customtext";
            this.panel_customtext.Size = new System.Drawing.Size(467, 28);
            this.panel_customtext.TabIndex = 13;
            this.panel_customtext.Visible = false;
            // 
            // txt_customtext
            // 
            this.txt_customtext.Location = new System.Drawing.Point(110, 2);
            this.txt_customtext.Name = "txt_customtext";
            this.txt_customtext.Size = new System.Drawing.Size(212, 20);
            this.txt_customtext.TabIndex = 16;
            // 
            // lbl_customtext
            // 
            this.lbl_customtext.AutoSize = true;
            this.lbl_customtext.Location = new System.Drawing.Point(33, 5);
            this.lbl_customtext.Name = "lbl_customtext";
            this.lbl_customtext.Size = new System.Drawing.Size(65, 13);
            this.lbl_customtext.TabIndex = 15;
            this.lbl_customtext.Text = "Custom text:";
            // 
            // panel_watermark
            // 
            this.panel_watermark.Controls.Add(this.txt_watermarkimage);
            this.panel_watermark.Controls.Add(this.button2);
            this.panel_watermark.Controls.Add(this.label1);
            this.panel_watermark.Location = new System.Drawing.Point(3, 47);
            this.panel_watermark.Name = "panel_watermark";
            this.panel_watermark.Size = new System.Drawing.Size(471, 41);
            this.panel_watermark.TabIndex = 6;
            // 
            // txt_watermarkimage
            // 
            this.txt_watermarkimage.Location = new System.Drawing.Point(111, 13);
            this.txt_watermarkimage.Name = "txt_watermarkimage";
            this.txt_watermarkimage.ReadOnly = true;
            this.txt_watermarkimage.Size = new System.Drawing.Size(212, 20);
            this.txt_watermarkimage.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(329, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Watermark image:";
            // 
            // panel_textsize
            // 
            this.panel_textsize.Controls.Add(this.lbl_fontsizepx);
            this.panel_textsize.Controls.Add(this.txt_fontsize);
            this.panel_textsize.Controls.Add(this.lbl_fontsize);
            this.panel_textsize.Location = new System.Drawing.Point(3, 55);
            this.panel_textsize.Name = "panel_textsize";
            this.panel_textsize.Size = new System.Drawing.Size(471, 33);
            this.panel_textsize.TabIndex = 6;
            this.panel_textsize.Visible = false;
            // 
            // lbl_fontsizepx
            // 
            this.lbl_fontsizepx.AutoSize = true;
            this.lbl_fontsizepx.Location = new System.Drawing.Point(151, 8);
            this.lbl_fontsizepx.Name = "lbl_fontsizepx";
            this.lbl_fontsizepx.Size = new System.Drawing.Size(18, 13);
            this.lbl_fontsizepx.TabIndex = 16;
            this.lbl_fontsizepx.Text = "px";
            // 
            // txt_fontsize
            // 
            this.txt_fontsize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_fontsize.FormattingEnabled = true;
            this.txt_fontsize.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "22",
            "26",
            "32"});
            this.txt_fontsize.Location = new System.Drawing.Point(111, 5);
            this.txt_fontsize.Name = "txt_fontsize";
            this.txt_fontsize.Size = new System.Drawing.Size(37, 21);
            this.txt_fontsize.TabIndex = 15;
            // 
            // lbl_fontsize
            // 
            this.lbl_fontsize.AutoSize = true;
            this.lbl_fontsize.Location = new System.Drawing.Point(47, 8);
            this.lbl_fontsize.Name = "lbl_fontsize";
            this.lbl_fontsize.Size = new System.Drawing.Size(52, 13);
            this.lbl_fontsize.TabIndex = 12;
            this.lbl_fontsize.Text = "Font-size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 49);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Watermark Type";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(266, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.Text = "Custom text";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(121, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(139, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.Text = "Image image date taken";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(34, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Custom png";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(468, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Progress";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.outputlog);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Location = new System.Drawing.Point(12, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 87);
            this.panel3.TabIndex = 8;
            // 
            // outputlog
            // 
            this.outputlog.Location = new System.Drawing.Point(4, 4);
            this.outputlog.Name = "outputlog";
            this.outputlog.ReadOnly = true;
            this.outputlog.Size = new System.Drawing.Size(469, 46);
            this.outputlog.TabIndex = 7;
            this.outputlog.Text = "";
            this.outputlog.TextChanged += new System.EventHandler(this.outputlog_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(245, 451);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "Github page";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frm_watermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 502);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_start);
            this.Name = "frm_watermark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_customtext.ResumeLayout(false);
            this.panel_customtext.PerformLayout();
            this.panel_watermark.ResumeLayout(false);
            this.panel_watermark.PerformLayout();
            this.panel_textsize.ResumeLayout(false);
            this.panel_textsize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog image_watermark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_imagesdir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog image_folder;
        private System.Windows.Forms.ComboBox txt_wposition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_outputdir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog image_outputfolder;
        private System.Windows.Forms.Label lbl_totalimages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel_watermark;
        private System.Windows.Forms.TextBox txt_watermarkimage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_textsize;
        private System.Windows.Forms.Label lbl_fontsizepx;
        private System.Windows.Forms.ComboBox txt_fontsize;
        private System.Windows.Forms.Label lbl_fontsize;
        private System.Windows.Forms.Panel panel_customtext;
        private System.Windows.Forms.TextBox txt_customtext;
        private System.Windows.Forms.Label lbl_customtext;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox outputlog;
    }
}

