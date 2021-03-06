﻿using SPMConnectAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Xml;
using static SPMConnectAPI.ConnectHelper;

namespace SearchDataSPM.Admin_developer
{
    public partial class HelpForm : Form
    {
        private readonly SPMSQLCommands connectapi = new SPMSQLCommands();
        private List<string> filestoAttach = new List<string>();
        private log4net.ILog log;

        public HelpForm()
        {
            InitializeComponent();
        }

        private void Browsebttn_Click(object sender, EventArgs e)
        {
            List<string> filestoattach = Importfilename();

            if (filestoattach.Count > 0)
            {
                label5.Text = "File attached : " + filestoattach.Count;
                //browsebttn.Visible = false;
                filestoAttach = filestoattach;
            }
            else
            {
                label5.Text = "Attach file : ";
                //browsebttn.Visible = true;
            }
        }

        private void Clearall()
        {
            filestoAttach.Clear();
            subtxt.Clear();
            notestxt.Clear();
            label5.Text = "Attach file : ";
            browsebttn.Visible = true;
        }

        private void HelpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("Closed Help Form ");
            this.Dispose();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            // Suspend the layout logic for the form, while the application is initializing
            this.SuspendLayout();
            versionlbl.Text = string.Format("Version - {0}", Getassyversionnumber(true));
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            log.Info("Opened Help Form ");
            if (connectapi.ConnectUser.Dept != Department.Eng)
                sldwrksaddin.Visible = false;
            // Resume the layout logic
            this.ResumeLayout();
        }

        private List<string> Importfilename()
        {
            filestoAttach.Clear();
            List<string> files = new List<string>();
            openFileDialog1.FileName = "";
            openFileDialog1.Filter =
        "Images (*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|" +
        "All files (*.*)|*.*";

            openFileDialog1.Title = "Connect Error Image Browser";
            openFileDialog1.Multiselect = true;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Test result.
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    try
                    {
                        files.Add(file);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
            return files;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/spmconnect/SPM_Connect");
        }

        private void Nametxt_TextChanged(object sender, EventArgs e)
        {
            sendemailbttn.Enabled = notestxt.Text.Length > 0;
        }

        private void Notestxt_TextChanged(object sender, EventArgs e)
        {
            sendemailbttn.Enabled = notestxt.Text.Length > 0;
        }

        private void Sendemailbttn_Click(object sender, EventArgs e)
        {
            Sendemailtodevelopers(connectapi.ConnectUser.Name, filestoAttach, subtxt.Text, notestxt.Text);
            Clearall();
            MessageBox.Show("Email successfully sent to developer.", "SPM Connect - Developer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Sendemailtodevelopers(string requser, List<string> files, string subject, string notes)
        {
            foreach (NameEmail item in connectapi.GetNameEmailByParaValue(UserFields.Developer, "1"))
                connectapi.SendemailListAttachments(item.email, "Connect Error Submitted - " + subject, "Hello " + item.name + "," + Environment.NewLine + requser + " sent this error report." + Environment.NewLine + notes + Environment.NewLine + Environment.NewLine + "Triggered by " + connectapi.ConnectUser.Name, files, "");
        }

        private void Shrtcutbttn_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Diagnostics.Process.Start(@"\\spm-adfs\SDBASE\SPM Connect SQL\ConnectHotKeys.pdf");
                System.Diagnostics.Process.Start("https://shail.gitbook.io/spmconnect/resources/resources-home/keyboard-shortcuts");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sldwrksaddin_Click(object sender, EventArgs e)
        {
            InstallSPMConnectAddin(@"\\spm-adfs\SDBASE\SPM Connect Addin\update.xml", "spm");
        }

        public void InstallSPMConnectAddin(string url, string name)
        {
            XmlDocument x = new XmlDocument();

            try
            {
                x.Load(url);
                XmlNode root = x.DocumentElement;
                if (root.Name != name)
                {
                    throw new XmlException();
                }
                string version = x.SelectSingleNode("descendant::version").InnerText;
                if (version == null)
                {
                    throw new XmlException();
                }

                DialogResult r = MessageBox.Show("Install SPM Connect Addin for Solidworks?", "SPM Connect - Solidworks Addin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    string applicationfolder = @"\\spm-adfs\SDBASE\SPM Connect Addin\" + version + "\\SPMConnectAddin" + version + ".msi";
                    File.Copy(applicationfolder, System.IO.Path.GetTempPath() + "SPMConnectAddin" + version + ".msi", true);
                    Process.Start(System.IO.Path.GetTempPath() + "SPMConnectAddin" + version + ".msi");
                }
            }
            catch (Exception e)
            {
                log.Error(e.Message, e);
            }
        }
    }
}