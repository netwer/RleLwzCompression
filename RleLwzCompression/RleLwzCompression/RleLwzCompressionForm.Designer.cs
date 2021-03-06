﻿namespace RleLwzCompression
{
    partial class RleLwzCompressionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RleLwzCompressionForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLoadedPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxRleDecodePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxLwzDecodePicture = new System.Windows.Forms.PictureBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelLoadedPictureSize = new System.Windows.Forms.Label();
            this.labelLoadedPicturePath = new System.Windows.Forms.Label();
            this.labelLoadedPictureName = new System.Windows.Forms.Label();
            this.labelPicture = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelLPicS = new System.Windows.Forms.Label();
            this.labelLPicP = new System.Windows.Forms.Label();
            this.labelLPicN = new System.Windows.Forms.Label();
            this.labelLwzSize = new System.Windows.Forms.Label();
            this.labelRleSize = new System.Windows.Forms.Label();
            this.labelLWZComressinResult = new System.Windows.Forms.Label();
            this.labelRleComressionResult = new System.Windows.Forms.Label();
            this.labelLwzEncodeCompression = new System.Windows.Forms.Label();
            this.labelRleEncodeCompression = new System.Windows.Forms.Label();
            this.labelLwzEncodeSize = new System.Windows.Forms.Label();
            this.labelRleEncodeSize = new System.Windows.Forms.Label();
            this.groupBoxProgresses = new System.Windows.Forms.GroupBox();
            this.pictureBoxLwzWorking = new System.Windows.Forms.PictureBox();
            this.pictureBoxRleWorking = new System.Windows.Forms.PictureBox();
            this.labelEncodeLwzProgress = new System.Windows.Forms.Label();
            this.labelEncodeRleProgress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRleDecodePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLwzDecodePicture)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxProgresses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLwzWorking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRleWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPictureToolStripMenuItem,
            this.logViewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadPictureToolStripMenuItem
            // 
            this.loadPictureToolStripMenuItem.Name = "loadPictureToolStripMenuItem";
            this.loadPictureToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.loadPictureToolStripMenuItem.Text = "Load Picture";
            // 
            // logViewToolStripMenuItem
            // 
            this.logViewToolStripMenuItem.Name = "logViewToolStripMenuItem";
            this.logViewToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.logViewToolStripMenuItem.Text = "Log View";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBoxLoadedPicture
            // 
            this.pictureBoxLoadedPicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxLoadedPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLoadedPicture.Location = new System.Drawing.Point(40, 60);
            this.pictureBoxLoadedPicture.Name = "pictureBoxLoadedPicture";
            this.pictureBoxLoadedPicture.Size = new System.Drawing.Size(201, 175);
            this.pictureBoxLoadedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadedPicture.TabIndex = 1;
            this.pictureBoxLoadedPicture.TabStop = false;
            // 
            // pictureBoxRleDecodePicture
            // 
            this.pictureBoxRleDecodePicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxRleDecodePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRleDecodePicture.Location = new System.Drawing.Point(272, 60);
            this.pictureBoxRleDecodePicture.Name = "pictureBoxRleDecodePicture";
            this.pictureBoxRleDecodePicture.Size = new System.Drawing.Size(201, 175);
            this.pictureBoxRleDecodePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRleDecodePicture.TabIndex = 2;
            this.pictureBoxRleDecodePicture.TabStop = false;
            // 
            // pictureBoxLwzDecodePicture
            // 
            this.pictureBoxLwzDecodePicture.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxLwzDecodePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLwzDecodePicture.Location = new System.Drawing.Point(504, 60);
            this.pictureBoxLwzDecodePicture.Name = "pictureBoxLwzDecodePicture";
            this.pictureBoxLwzDecodePicture.Size = new System.Drawing.Size(201, 175);
            this.pictureBoxLwzDecodePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLwzDecodePicture.TabIndex = 3;
            this.pictureBoxLwzDecodePicture.TabStop = false;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(81, 353);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 4;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(81, 411);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelLoadedPictureSize
            // 
            this.labelLoadedPictureSize.AutoSize = true;
            this.labelLoadedPictureSize.Location = new System.Drawing.Point(6, 74);
            this.labelLoadedPictureSize.Name = "labelLoadedPictureSize";
            this.labelLoadedPictureSize.Size = new System.Drawing.Size(148, 16);
            this.labelLoadedPictureSize.TabIndex = 2;
            this.labelLoadedPictureSize.Text = "Loaded picture size:";
            // 
            // labelLoadedPicturePath
            // 
            this.labelLoadedPicturePath.AutoSize = true;
            this.labelLoadedPicturePath.Location = new System.Drawing.Point(6, 47);
            this.labelLoadedPicturePath.Name = "labelLoadedPicturePath";
            this.labelLoadedPicturePath.Size = new System.Drawing.Size(150, 16);
            this.labelLoadedPicturePath.TabIndex = 1;
            this.labelLoadedPicturePath.Text = "Loaded picture path:";
            // 
            // labelLoadedPictureName
            // 
            this.labelLoadedPictureName.AutoSize = true;
            this.labelLoadedPictureName.Location = new System.Drawing.Point(6, 18);
            this.labelLoadedPictureName.Name = "labelLoadedPictureName";
            this.labelLoadedPictureName.Size = new System.Drawing.Size(158, 16);
            this.labelLoadedPictureName.TabIndex = 0;
            this.labelLoadedPictureName.Text = "Loaded picture name:";
            // 
            // labelPicture
            // 
            this.labelPicture.AutoSize = true;
            this.labelPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPicture.Location = new System.Drawing.Point(40, 37);
            this.labelPicture.Name = "labelPicture";
            this.labelPicture.Size = new System.Drawing.Size(130, 20);
            this.labelPicture.TabIndex = 8;
            this.labelPicture.Text = "Loaded Picture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "RLE Decode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "LWZ Decode";
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(81, 382);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 11;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelLPicS);
            this.groupBoxInfo.Controls.Add(this.labelLPicP);
            this.groupBoxInfo.Controls.Add(this.labelLPicN);
            this.groupBoxInfo.Controls.Add(this.labelLwzSize);
            this.groupBoxInfo.Controls.Add(this.labelRleSize);
            this.groupBoxInfo.Controls.Add(this.labelLWZComressinResult);
            this.groupBoxInfo.Controls.Add(this.labelRleComressionResult);
            this.groupBoxInfo.Controls.Add(this.labelLoadedPictureSize);
            this.groupBoxInfo.Controls.Add(this.labelLwzEncodeCompression);
            this.groupBoxInfo.Controls.Add(this.labelLoadedPicturePath);
            this.groupBoxInfo.Controls.Add(this.labelRleEncodeCompression);
            this.groupBoxInfo.Controls.Add(this.labelLoadedPictureName);
            this.groupBoxInfo.Controls.Add(this.labelLwzEncodeSize);
            this.groupBoxInfo.Controls.Add(this.labelRleEncodeSize);
            this.groupBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfo.Location = new System.Drawing.Point(244, 254);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(481, 207);
            this.groupBoxInfo.TabIndex = 7;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Info";
            // 
            // labelLPicS
            // 
            this.labelLPicS.AutoSize = true;
            this.labelLPicS.Location = new System.Drawing.Point(170, 74);
            this.labelLPicS.Name = "labelLPicS";
            this.labelLPicS.Size = new System.Drawing.Size(42, 16);
            this.labelLPicS.TabIndex = 15;
            this.labelLPicS.Text = "lSize";
            // 
            // labelLPicP
            // 
            this.labelLPicP.AutoSize = true;
            this.labelLPicP.Location = new System.Drawing.Point(170, 47);
            this.labelLPicP.Name = "labelLPicP";
            this.labelLPicP.Size = new System.Drawing.Size(43, 16);
            this.labelLPicP.TabIndex = 14;
            this.labelLPicP.Text = "lPath";
            // 
            // labelLPicN
            // 
            this.labelLPicN.AutoSize = true;
            this.labelLPicN.Location = new System.Drawing.Point(170, 18);
            this.labelLPicN.Name = "labelLPicN";
            this.labelLPicN.Size = new System.Drawing.Size(53, 16);
            this.labelLPicN.TabIndex = 13;
            this.labelLPicN.Text = "lName";
            // 
            // labelLwzSize
            // 
            this.labelLwzSize.AutoSize = true;
            this.labelLwzSize.Location = new System.Drawing.Point(144, 178);
            this.labelLwzSize.Name = "labelLwzSize";
            this.labelLwzSize.Size = new System.Drawing.Size(39, 16);
            this.labelLwzSize.TabIndex = 11;
            this.labelLwzSize.Text = "lwzS";
            // 
            // labelRleSize
            // 
            this.labelRleSize.AutoSize = true;
            this.labelRleSize.Location = new System.Drawing.Point(142, 153);
            this.labelRleSize.Name = "labelRleSize";
            this.labelRleSize.Size = new System.Drawing.Size(36, 16);
            this.labelRleSize.TabIndex = 10;
            this.labelRleSize.Text = "rleS";
            // 
            // labelLWZComressinResult
            // 
            this.labelLWZComressinResult.AutoSize = true;
            this.labelLWZComressinResult.Location = new System.Drawing.Point(220, 125);
            this.labelLWZComressinResult.Name = "labelLWZComressinResult";
            this.labelLWZComressinResult.Size = new System.Drawing.Size(65, 16);
            this.labelLWZComressinResult.TabIndex = 9;
            this.labelLWZComressinResult.Text = "cmpRes";
            // 
            // labelRleComressionResult
            // 
            this.labelRleComressionResult.AutoSize = true;
            this.labelRleComressionResult.Location = new System.Drawing.Point(220, 99);
            this.labelRleComressionResult.Name = "labelRleComressionResult";
            this.labelRleComressionResult.Size = new System.Drawing.Size(65, 16);
            this.labelRleComressionResult.TabIndex = 8;
            this.labelRleComressionResult.Text = "cmpRes";
            // 
            // labelLwzEncodeCompression
            // 
            this.labelLwzEncodeCompression.AutoSize = true;
            this.labelLwzEncodeCompression.Location = new System.Drawing.Point(6, 125);
            this.labelLwzEncodeCompression.Name = "labelLwzEncodeCompression";
            this.labelLwzEncodeCompression.Size = new System.Drawing.Size(210, 16);
            this.labelLwzEncodeCompression.TabIndex = 7;
            this.labelLwzEncodeCompression.Text = "LZW Encode % compression:";
            // 
            // labelRleEncodeCompression
            // 
            this.labelRleEncodeCompression.AutoSize = true;
            this.labelRleEncodeCompression.Location = new System.Drawing.Point(6, 99);
            this.labelRleEncodeCompression.Name = "labelRleEncodeCompression";
            this.labelRleEncodeCompression.Size = new System.Drawing.Size(208, 16);
            this.labelRleEncodeCompression.TabIndex = 6;
            this.labelRleEncodeCompression.Text = "RLE Encode % compression:";
            // 
            // labelLwzEncodeSize
            // 
            this.labelLwzEncodeSize.AutoSize = true;
            this.labelLwzEncodeSize.Location = new System.Drawing.Point(6, 178);
            this.labelLwzEncodeSize.Name = "labelLwzEncodeSize";
            this.labelLwzEncodeSize.Size = new System.Drawing.Size(132, 16);
            this.labelLwzEncodeSize.TabIndex = 4;
            this.labelLwzEncodeSize.Text = "LZW Encode size:";
            // 
            // labelRleEncodeSize
            // 
            this.labelRleEncodeSize.AutoSize = true;
            this.labelRleEncodeSize.Location = new System.Drawing.Point(6, 153);
            this.labelRleEncodeSize.Name = "labelRleEncodeSize";
            this.labelRleEncodeSize.Size = new System.Drawing.Size(130, 16);
            this.labelRleEncodeSize.TabIndex = 3;
            this.labelRleEncodeSize.Text = "RLE Encode size:";
            // 
            // groupBoxProgresses
            // 
            this.groupBoxProgresses.Controls.Add(this.pictureBoxLwzWorking);
            this.groupBoxProgresses.Controls.Add(this.pictureBoxRleWorking);
            this.groupBoxProgresses.Controls.Add(this.labelEncodeLwzProgress);
            this.groupBoxProgresses.Controls.Add(this.labelEncodeRleProgress);
            this.groupBoxProgresses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProgresses.Location = new System.Drawing.Point(12, 256);
            this.groupBoxProgresses.Name = "groupBoxProgresses";
            this.groupBoxProgresses.Size = new System.Drawing.Size(220, 88);
            this.groupBoxProgresses.TabIndex = 7;
            this.groupBoxProgresses.TabStop = false;
            this.groupBoxProgresses.Text = "Progresses";
            // 
            // pictureBoxLwzWorking
            // 
            this.pictureBoxLwzWorking.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxLwzWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLwzWorking.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLwzWorking.Image")));
            this.pictureBoxLwzWorking.Location = new System.Drawing.Point(173, 53);
            this.pictureBoxLwzWorking.Name = "pictureBoxLwzWorking";
            this.pictureBoxLwzWorking.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxLwzWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLwzWorking.TabIndex = 13;
            this.pictureBoxLwzWorking.TabStop = false;
            this.pictureBoxLwzWorking.Visible = false;
            // 
            // pictureBoxRleWorking
            // 
            this.pictureBoxRleWorking.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBoxRleWorking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRleWorking.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRleWorking.Image")));
            this.pictureBoxRleWorking.Location = new System.Drawing.Point(173, 21);
            this.pictureBoxRleWorking.Name = "pictureBoxRleWorking";
            this.pictureBoxRleWorking.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxRleWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRleWorking.TabIndex = 12;
            this.pictureBoxRleWorking.TabStop = false;
            this.pictureBoxRleWorking.Visible = false;
            // 
            // labelEncodeLwzProgress
            // 
            this.labelEncodeLwzProgress.AutoSize = true;
            this.labelEncodeLwzProgress.Location = new System.Drawing.Point(3, 57);
            this.labelEncodeLwzProgress.Name = "labelEncodeLwzProgress";
            this.labelEncodeLwzProgress.Size = new System.Drawing.Size(166, 16);
            this.labelEncodeLwzProgress.TabIndex = 2;
            this.labelEncodeLwzProgress.Text = "Encode LWZ progress:";
            // 
            // labelEncodeRleProgress
            // 
            this.labelEncodeRleProgress.AutoSize = true;
            this.labelEncodeRleProgress.Location = new System.Drawing.Point(3, 28);
            this.labelEncodeRleProgress.Name = "labelEncodeRleProgress";
            this.labelEncodeRleProgress.Size = new System.Drawing.Size(164, 16);
            this.labelEncodeRleProgress.TabIndex = 1;
            this.labelEncodeRleProgress.Text = "Encode RLE progress:";
            // 
            // RleLwzCompressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(737, 468);
            this.Controls.Add(this.groupBoxProgresses);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPicture);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.pictureBoxLwzDecodePicture);
            this.Controls.Add(this.pictureBoxRleDecodePicture);
            this.Controls.Add(this.pictureBoxLoadedPicture);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "RleLwzCompressionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RLE LWZ Compression";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRleDecodePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLwzDecodePicture)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxProgresses.ResumeLayout(false);
            this.groupBoxProgresses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLwzWorking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRleWorking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLoadedPicture;
        private System.Windows.Forms.PictureBox pictureBoxRleDecodePicture;
        private System.Windows.Forms.PictureBox pictureBoxLwzDecodePicture;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ToolStripMenuItem logViewToolStripMenuItem;
        private System.Windows.Forms.Label labelPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLoadedPictureSize;
        private System.Windows.Forms.Label labelLoadedPicturePath;
        private System.Windows.Forms.Label labelLoadedPictureName;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelLwzEncodeCompression;
        private System.Windows.Forms.Label labelRleEncodeCompression;
        private System.Windows.Forms.Label labelLwzEncodeSize;
        private System.Windows.Forms.Label labelRleEncodeSize;
        private System.Windows.Forms.GroupBox groupBoxProgresses;
        private System.Windows.Forms.Label labelEncodeLwzProgress;
        private System.Windows.Forms.Label labelEncodeRleProgress;
        private System.Windows.Forms.Label labelLPicS;
        private System.Windows.Forms.Label labelLPicP;
        private System.Windows.Forms.Label labelLPicN;
        private System.Windows.Forms.Label labelLwzSize;
        private System.Windows.Forms.Label labelRleSize;
        private System.Windows.Forms.Label labelLWZComressinResult;
        private System.Windows.Forms.Label labelRleComressionResult;
        private System.Windows.Forms.PictureBox pictureBoxLwzWorking;
        private System.Windows.Forms.PictureBox pictureBoxRleWorking;
    }
}

