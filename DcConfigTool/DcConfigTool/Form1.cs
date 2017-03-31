using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DcConfigTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxMonth.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 2;
            Properties.Settings.Default.Upgrade();
            textBoxOutut.Text = Properties.Settings.Default.oldOtputpath;
            textBoxInput.Text = Properties.Settings.Default.oldInputPath;
            pictureBoxDone.Visible = false;
            textBoxDone.Visible = false;
        }

        private bool validate()
        {
            var _inputPathValid = false;
            var _outputPathValid = false;
            var _statusvalidation = false;
            pictureBoxDone.Visible = false;
            textBoxDone.Visible = false;
            if (radioButtonMahjong.Checked)
            {
                InputParam.GameTypeSet = InputParam.GameType.Mahjong;
            }
            else
            {
                InputParam.GameTypeSet = InputParam.GameType.Solitaire;
            }

            if (System.IO.File.Exists(textBoxInput.Text))
                {
                textBoxInput.BackColor = Color.White;
                InputParam.FilePath = textBoxInput.Text;
                Properties.Settings.Default.oldInputPath = textBoxInput.Text;
                _inputPathValid = true;
                }
            else
                {
                textBoxInput.BackColor = Color.Red;
                }


            if (System.IO.Directory.Exists(textBoxOutut.Text))
            {
                textBoxOutut.BackColor = Color.White;
                InputParam.OutputPath = textBoxOutut.Text;
                Properties.Settings.Default.oldOtputpath = textBoxOutut.Text;
                _outputPathValid = true;
            }
            else
            {
                textBoxOutut.BackColor = Color.Red;
            }


            InputParam.MonthSet = comboBoxMonth.SelectedIndex+1;
            InputParam.YaerSet = int.Parse(comboBoxYear.SelectedItem.ToString());

            if (_inputPathValid | _outputPathValid) _statusvalidation = true;
            Properties.Settings.Default.Save();
            return _statusvalidation;
        }

        private void buttonInpurPath_Click(object sender, EventArgs e)
        {
            openFileDialoginput.FileName = "MonthChallenges"; 
            openFileDialoginput.DefaultExt = ".js"; 
            openFileDialoginput.Filter = "js documents |*.js"; 
            if (openFileDialoginput.ShowDialog() == DialogResult.OK)
            {
                textBoxInput.Text = openFileDialoginput.FileName;
            }     
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogInput.ShowDialog() == DialogResult.OK)
            {
                textBoxOutut.Text = folderBrowserDialogInput.SelectedPath;
            }
        }

        private void buttonMonth_Click(object sender, EventArgs e)
        {
            InputParam.Yeargenerator = false;
            if (validate())
            {
                BaseProcess.Generate();
                pictureBoxDone.Visible = true;
                textBoxDone.Visible = true;
            }
        }

        private void buttonYear_Click(object sender, EventArgs e)
        {
            InputParam.Yeargenerator = true;
            if (validate())
            {
                BaseProcess.Generate();
                pictureBoxDone.Visible = true;
                textBoxDone.Visible = true;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
