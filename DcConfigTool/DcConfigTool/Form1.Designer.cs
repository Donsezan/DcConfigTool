namespace DcConfigTool
{
    partial class MainForm
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
            this.radioButtonSoliataire = new System.Windows.Forms.RadioButton();
            this.radioButtonMahjong = new System.Windows.Forms.RadioButton();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogInput = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.buttonYear = new System.Windows.Forms.Button();
            this.buttonInpurPath = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.openFileDialoginput = new System.Windows.Forms.OpenFileDialog();
            this.textBoxOutut = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDone = new System.Windows.Forms.PictureBox();
            this.textBoxDone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDone)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonSoliataire
            // 
            this.radioButtonSoliataire.AutoSize = true;
            this.radioButtonSoliataire.Location = new System.Drawing.Point(78, 84);
            this.radioButtonSoliataire.Name = "radioButtonSoliataire";
            this.radioButtonSoliataire.Size = new System.Drawing.Size(80, 21);
            this.radioButtonSoliataire.TabIndex = 0;
            this.radioButtonSoliataire.TabStop = true;
            this.radioButtonSoliataire.Text = "Solitaire";
            this.radioButtonSoliataire.UseVisualStyleBackColor = true;
            // 
            // radioButtonMahjong
            // 
            this.radioButtonMahjong.AutoSize = true;
            this.radioButtonMahjong.Location = new System.Drawing.Point(244, 84);
            this.radioButtonMahjong.Name = "radioButtonMahjong";
            this.radioButtonMahjong.Size = new System.Drawing.Size(83, 21);
            this.radioButtonMahjong.TabIndex = 1;
            this.radioButtonMahjong.TabStop = true;
            this.radioButtonMahjong.Text = "Mahjong";
            this.radioButtonMahjong.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 118);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(250, 22);
            this.textBoxInput.TabIndex = 2;
            // 
            // buttonMonth
            // 
            this.buttonMonth.Location = new System.Drawing.Point(12, 214);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(121, 27);
            this.buttonMonth.TabIndex = 5;
            this.buttonMonth.Text = "Month";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // buttonYear
            // 
            this.buttonYear.Location = new System.Drawing.Point(244, 214);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(121, 27);
            this.buttonYear.TabIndex = 6;
            this.buttonYear.Text = "Year";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // buttonInpurPath
            // 
            this.buttonInpurPath.Location = new System.Drawing.Point(267, 118);
            this.buttonInpurPath.Name = "buttonInpurPath";
            this.buttonInpurPath.Size = new System.Drawing.Size(100, 29);
            this.buttonInpurPath.TabIndex = 8;
            this.buttonInpurPath.Text = "Input File";
            this.buttonInpurPath.UseVisualStyleBackColor = true;
            this.buttonInpurPath.Click += new System.EventHandler(this.buttonInpurPath_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(267, 153);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(98, 25);
            this.buttonOutput.TabIndex = 9;
            this.buttonOutput.Text = "Output path";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(12, 184);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMonth.TabIndex = 10;
            this.comboBoxMonth.Text = "Month";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.comboBoxYear.Location = new System.Drawing.Point(244, 184);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 24);
            this.comboBoxYear.TabIndex = 11;
            this.comboBoxYear.Text = "Year";
            // 
            // openFileDialoginput
            // 
            this.openFileDialoginput.FileName = "openFileDialog";
            // 
            // textBoxOutut
            // 
            this.textBoxOutut.Location = new System.Drawing.Point(12, 156);
            this.textBoxOutut.Multiline = true;
            this.textBoxOutut.Name = "textBoxOutut";
            this.textBoxOutut.Size = new System.Drawing.Size(250, 22);
            this.textBoxOutut.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DcConfigTool.Properties.Resources.Solitaire;
            this.pictureBox2.Location = new System.Drawing.Point(64, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DcConfigTool.Properties.Resources.Mahjong;
            this.pictureBox1.Location = new System.Drawing.Point(244, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxDone
            // 
            this.pictureBoxDone.ErrorImage = global::DcConfigTool.Properties.Resources.done;
            this.pictureBoxDone.Image = global::DcConfigTool.Properties.Resources.done;
            this.pictureBoxDone.InitialImage = global::DcConfigTool.Properties.Resources.done;
            this.pictureBoxDone.Location = new System.Drawing.Point(64, 247);
            this.pictureBoxDone.Name = "pictureBoxDone";
            this.pictureBoxDone.Size = new System.Drawing.Size(233, 170);
            this.pictureBoxDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDone.TabIndex = 12;
            this.pictureBoxDone.TabStop = false;
            // 
            // textBoxDone
            // 
            this.textBoxDone.HideSelection = false;
            this.textBoxDone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxDone.Location = new System.Drawing.Point(64, 423);
            this.textBoxDone.Name = "textBoxDone";
            this.textBoxDone.ReadOnly = true;
            this.textBoxDone.Size = new System.Drawing.Size(242, 22);
            this.textBoxDone.TabIndex = 15;
            this.textBoxDone.Text = "DONE";
            this.textBoxDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 468);
            this.Controls.Add(this.textBoxDone);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxDone);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.buttonInpurPath);
            this.Controls.Add(this.textBoxOutut);
            this.Controls.Add(this.buttonYear);
            this.Controls.Add(this.buttonMonth);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.radioButtonMahjong);
            this.Controls.Add(this.radioButtonSoliataire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "DcConfigTool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSoliataire;
        private System.Windows.Forms.RadioButton radioButtonMahjong;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogInput;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonInpurPath;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.TextBox textBoxOutut;
        private System.Windows.Forms.OpenFileDialog openFileDialoginput;
        private System.Windows.Forms.PictureBox pictureBoxDone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxDone;
    }
}

