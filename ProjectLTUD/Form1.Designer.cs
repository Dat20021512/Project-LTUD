
namespace ProjectLTUD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitForm = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHistogram = new System.Windows.Forms.ToolStripMenuItem();
            this.shiwFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.cropImage = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toEDGE = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CvtGray = new System.Windows.Forms.ToolStripMenuItem();
            this.CvtNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.increasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.contracst = new System.Windows.Forms.ToolStripMenuItem();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCropped = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picbox2 = new System.Windows.Forms.PictureBox();
            this.picbox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.increasToolStripMenuItem,
            this.splitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFile,
            this.deleteToolStripMenuItem,
            this.exitForm});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFile
            // 
            this.openFile.Image = ((System.Drawing.Image)(resources.GetObject("openFile.Image")));
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(180, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFile
            // 
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(107, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::ProjectLTUD.Properties.Resources.delete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exitForm
            // 
            this.exitForm.Image = ((System.Drawing.Image)(resources.GetObject("exitForm.Image")));
            this.exitForm.Name = "exitForm";
            this.exitForm.Size = new System.Drawing.Size(107, 22);
            this.exitForm.Text = "Exit";
            this.exitForm.Click += new System.EventHandler(this.exitForm_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHistogram,
            this.shiwFlip,
            this.cropImage});
            this.histogramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("histogramToolStripMenuItem.Image")));
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.histogramToolStripMenuItem.Text = "Edit";
            // 
            // showHistogram
            // 
            this.showHistogram.Image = ((System.Drawing.Image)(resources.GetObject("showHistogram.Image")));
            this.showHistogram.Name = "showHistogram";
            this.showHistogram.Size = new System.Drawing.Size(180, 22);
            this.showHistogram.Text = "Rotate";
            this.showHistogram.Click += new System.EventHandler(this.showHistogram_Click);
            // 
            // shiwFlip
            // 
            this.shiwFlip.Image = ((System.Drawing.Image)(resources.GetObject("shiwFlip.Image")));
            this.shiwFlip.Name = "shiwFlip";
            this.shiwFlip.Size = new System.Drawing.Size(180, 22);
            this.shiwFlip.Text = "Flip";
            this.shiwFlip.Click += new System.EventHandler(this.shiwFlip_Click);
            // 
            // cropImage
            // 
            this.cropImage.Image = global::ProjectLTUD.Properties.Resources._123;
            this.cropImage.Name = "cropImage";
            this.cropImage.Size = new System.Drawing.Size(180, 22);
            this.cropImage.Text = "Crop";
            this.cropImage.Click += new System.EventHandler(this.cropToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toEDGE});
            this.filterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filterToolStripMenuItem.Image")));
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // toEDGE
            // 
            this.toEDGE.Image = ((System.Drawing.Image)(resources.GetObject("toEDGE.Image")));
            this.toEDGE.Name = "toEDGE";
            this.toEDGE.Size = new System.Drawing.Size(102, 22);
            this.toEDGE.Text = "EDGE";
            this.toEDGE.Click += new System.EventHandler(this.toEDGE_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CvtGray,
            this.CvtNegative});
            this.convertToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("convertToolStripMenuItem.Image")));
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.convertToolStripMenuItem.Text = "Convert";
            // 
            // CvtGray
            // 
            this.CvtGray.Image = ((System.Drawing.Image)(resources.GetObject("CvtGray.Image")));
            this.CvtGray.Name = "CvtGray";
            this.CvtGray.Size = new System.Drawing.Size(121, 22);
            this.CvtGray.Text = "Gray";
            this.CvtGray.Click += new System.EventHandler(this.CvtGray_Click);
            // 
            // CvtNegative
            // 
            this.CvtNegative.Image = ((System.Drawing.Image)(resources.GetObject("CvtNegative.Image")));
            this.CvtNegative.Name = "CvtNegative";
            this.CvtNegative.Size = new System.Drawing.Size(121, 22);
            this.CvtNegative.Text = "Negative";
            this.CvtNegative.Click += new System.EventHandler(this.CvtNegative_Click);
            // 
            // increasToolStripMenuItem
            // 
            this.increasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBrightness,
            this.contracst});
            this.increasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("increasToolStripMenuItem.Image")));
            this.increasToolStripMenuItem.Name = "increasToolStripMenuItem";
            this.increasToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.increasToolStripMenuItem.Text = "Increase";
            // 
            // changeBrightness
            // 
            this.changeBrightness.Image = ((System.Drawing.Image)(resources.GetObject("changeBrightness.Image")));
            this.changeBrightness.Name = "changeBrightness";
            this.changeBrightness.Size = new System.Drawing.Size(129, 22);
            this.changeBrightness.Text = "Brightness";
            this.changeBrightness.Click += new System.EventHandler(this.changeBrightness_Click);
            // 
            // contracst
            // 
            this.contracst.Image = ((System.Drawing.Image)(resources.GetObject("contracst.Image")));
            this.contracst.Name = "contracst";
            this.contracst.Size = new System.Drawing.Size(129, 22);
            this.contracst.Text = "Contrast";
            this.contracst.Click += new System.EventHandler(this.contracst_Click);
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.Image = global::ProjectLTUD.Properties.Resources.split;
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.splitToolStripMenuItem.Text = "Split";
            this.splitToolStripMenuItem.Click += new System.EventHandler(this.splitToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // showCropped
            // 
            this.showCropped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCropped.Location = new System.Drawing.Point(744, 540);
            this.showCropped.Name = "showCropped";
            this.showCropped.Size = new System.Drawing.Size(112, 34);
            this.showCropped.TabIndex = 5;
            this.showCropped.Text = "Show_Cropped";
            this.showCropped.UseVisualStyleBackColor = true;
            this.showCropped.Click += new System.EventHandler(this.showCropped_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(930, 540);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(33, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "R";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(969, 540);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(33, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "G";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1008, 540);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "B";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(1046, 540);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(48, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "RGB";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(669, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 34);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(613, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picbox2
            // 
            this.picbox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox2.Location = new System.Drawing.Point(596, 41);
            this.picbox2.Name = "picbox2";
            this.picbox2.Size = new System.Drawing.Size(510, 484);
            this.picbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox2.TabIndex = 2;
            this.picbox2.TabStop = false;
            // 
            // picbox1
            // 
            this.picbox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbox1.ErrorImage = null;
            this.picbox1.InitialImage = null;
            this.picbox1.Location = new System.Drawing.Point(12, 41);
            this.picbox1.Name = "picbox1";
            this.picbox1.Size = new System.Drawing.Size(510, 484);
            this.picbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox1.TabIndex = 1;
            this.picbox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dimensions:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 549);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 549);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // btnResize
            // 
            this.btnResize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResize.Location = new System.Drawing.Point(396, 541);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(112, 34);
            this.btnResize.TabIndex = 5;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-304, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "button3";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1118, 593);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.showCropped);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picbox2);
            this.Controls.Add(this.picbox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Processing Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem exitForm;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHistogram;
        private System.Windows.Forms.ToolStripMenuItem shiwFlip;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toEDGE;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CvtGray;
        private System.Windows.Forms.ToolStripMenuItem CvtNegative;
        private System.Windows.Forms.ToolStripMenuItem increasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBrightness;
        private System.Windows.Forms.ToolStripMenuItem contracst;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox picbox1;
        private System.Windows.Forms.PictureBox picbox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button showCropped;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ToolStripMenuItem cropImage;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button button5;
    }
}

