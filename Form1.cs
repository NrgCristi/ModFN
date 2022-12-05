using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Net;
namespace ModFN
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
            commonOpenFileDialog.Title = "Please select your fornite path";
            commonOpenFileDialog.IsFolderPicker = true;
            commonOpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            commonOpenFileDialog.AddToMostRecentlyUsedList = false;
            commonOpenFileDialog.AllowNonFileSystemItems = false;
            commonOpenFileDialog.DefaultDirectory = "Desktop";
            commonOpenFileDialog.EnsureFileExists = true;
            commonOpenFileDialog.EnsurePathExists = true;
            commonOpenFileDialog.EnsureReadOnly = false;
            commonOpenFileDialog.EnsureValidNames = true;
            commonOpenFileDialog.Multiselect = false;
            commonOpenFileDialog.ShowPlacesList = true;
            if (commonOpenFileDialog.ShowDialog() != CommonFileDialogResult.Ok)
                return;
            string fileName1 = commonOpenFileDialog.FileName;
            string pakspath = fileName1 + "//FortniteGame//Content//Paks";
            if (!System.IO.Directory.Exists(pakspath))
            {
                MessageBox.Show("The path selected does not contain The engine and fortnitegame folders : " + fileName1 + "\\nPlease retry with a correct path");
            }
            if (!System.IO.Directory.Exists(pakspath))
                return;
            CommonOpenFileDialog commonOpenFileDialog1 = new CommonOpenFileDialog();
            commonOpenFileDialog1.Title = "Please select the mod you want to install";
            commonOpenFileDialog1.IsFolderPicker = false;
            commonOpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            commonOpenFileDialog1.AddToMostRecentlyUsedList = false;
            commonOpenFileDialog1.AllowNonFileSystemItems = false;
            commonOpenFileDialog1.DefaultDirectory = "Desktop";
            commonOpenFileDialog1.EnsureFileExists = true;
            commonOpenFileDialog1.EnsurePathExists = true;
            commonOpenFileDialog1.EnsureReadOnly = false;
            commonOpenFileDialog1.EnsureValidNames = true;
            commonOpenFileDialog1.Multiselect = false;
            commonOpenFileDialog1.ShowPlacesList = true;
            commonOpenFileDialog1.DefaultExtension = ".pak, .sig, .ucas, .utoc";
            if (commonOpenFileDialog1.ShowDialog() != CommonFileDialogResult.Ok)
                return;
            string filename2 = commonOpenFileDialog1.FileName;
            System.IO.File.Move(filename2, fileName1 + pakspath);
            MessageBox.Show("Mod succesfully installed");
        }
    }
}
