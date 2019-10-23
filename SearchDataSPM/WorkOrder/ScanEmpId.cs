﻿using SPMConnect.UserActionLog;
using SPMConnectAPI;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SearchDataSPM
{
    public partial class ScanEmpId : MetroFramework.Forms.MetroForm
    {
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        WorkOrder connectapi = new WorkOrder();
        int userinputtime = 100;
        bool developer = false;
        log4net.ILog log;
        private UserActions _userActions;
        ErrorHandler errorHandler = new ErrorHandler();

        public ScanEmpId()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(UnhandledException);
            InitializeComponent();
            //connectapi.SPM_Connect();
        }

        public string ValueIWant { get; set; }

        private void JobType_Load(object sender, EventArgs e)
        {
            empid_txtbox.Focus();
            userinputtime = connectapi.getuserinputtime();
            developer = connectapi.Checkdeveloper();
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            log.Info("Opened Scan Emp ID by " + System.Environment.UserName);
            _userActions = new UserActions(this);
        }


        private void empid_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check timing (keystrokes within 100 ms)
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > userinputtime)
                _barcode.Clear();

            // record keystroke & timestamp
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;

            // process barcode
            if (e.KeyChar == 13 && _barcode.Count > 0)
            {
                string msg = new string(_barcode.ToArray());

                _barcode.Clear();
                if (msg != "\r" || developer)
                {

                    if (e.KeyChar == 13)
                    {
                        ValueIWant = empid_txtbox.Text.Trim();
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        Close();
                        e.Handled = true;
                    }
                }
                else
                {

                    MessageBox.Show("System cannot accept keyboard inputs. Scan with barcode reader", "SPM Connect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    empid_txtbox.Clear();
                    empid_txtbox.Focus();
                }
            }
        }

        private void ScanEmpId_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(empid_txtbox.Text.Length > 0))
            {
                // e.Cancel = true;
            }
        }

        private void ScanEmpId_FormClosed(object sender, FormClosedEventArgs e)
        {
            _userActions.FinishLoggingUserActions(this);
            log.Info("Closed Scan Emp ID by " + System.Environment.UserName);
            this.Dispose();
        }

        private void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            errorHandler.EmailExceptionAndActionLogToSupport(sender, t.Exception, _userActions, this);
        }

        private void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            errorHandler.EmailExceptionAndActionLogToSupport(sender, (Exception)e.ExceptionObject, _userActions, this);
        }
    }
}
