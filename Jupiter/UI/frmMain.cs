#region Copyright ©  2006 - 2014 D.E.M.O.N.Studio

// -------------------------------------------
//  This File belongs to D.E.M.O.N Studio
//  All rights received.
// 
//  DemonVK@Gmail.com
// -------------------------------------------
// 
//   File Name: frmMain.cs
//   Project: Jupiter
//   Solution: Jupiter
// 
// -------------------------------------------
// 
//   Created Date: 2:45 PM 19/02/2014
// 
// -------------------------------------------

#endregion

#region

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.ServiceModel;
using System.Windows.Forms;
using D.E.M.O.N.Catalyst;
using D.E.M.O.N.Catalyst.Encrypt;
using D.E.M.O.N.Catalyst.GalaxyService;
using D.E.M.O.N.Catalyst.Workstation;
using DevExpress.XtraEditors;
using Jupiter.Properties;
using Jupiter.UI.Functions;

#endregion

namespace Jupiter.UI
{
    public partial class frmMain : XtraForm
    {
        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_MOVE = 0xF010;
        private const int HTCAPTION = 0x0002;
        private readonly List<AccountInfo> AccountList = new List<AccountInfo>();
        private readonly List<Information> ComputerList = new List<Information>();

        private readonly Dictionary<string, IStarGateCallBack> ComputerListDic =
            new Dictionary<string, IStarGateCallBack>();

        //private static List<KeyValuePair<string, IStarGateCallBack>> clientCallbackList = new List<KeyValuePair<string, IStarGateCallBack>>();
        private readonly Decrypter _Crypter = new Decrypter();
        private ServiceHost IStarGate;
        private BackgroundWorker _BGWorker;
        private Observer _service;

        public frmMain()
        {
            InitializeComponent();
            WriteLog("Program initialised");
            WriteLog("Try to check program files");
            WriteLog(File.Exists(Application.StartupPath + "\\D.E.M.O.N.Catalyst.dll")
                ? "Finished! All parts avaliable!"
                : "Warning! Some parts missed!");
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void cmdStart_Click(object sender, EventArgs e)
        {
            WriteLog("Try to start Jupiter Service...");

            _BGWorker = new BackgroundWorker();
            _BGWorker.RunWorkerCompleted += _RunWorkerCompleted;
            _BGWorker.DoWork += _DoWork;

            if (!_BGWorker.IsBusy)
            {
                _BGWorker.RunWorkerAsync();
            }

            //WriteLog(HQServer.StartServer() ? "Server process Online..." : "Server process Offline...");
        }

        private void AddClient(string ClientMessage)
        {
            Information ClientInfo = _Crypter.GetInfoString(ClientMessage);

            if (!ComputerListDic.ContainsKey(ClientInfo.PCName))
            {
                lstLog.Invoke((MethodInvoker) (() => WriteLog(ClientInfo.PCName + " Connected")));

                ComputerListDic.Add(ClientInfo.PCName, OperationContext.Current.GetCallbackChannel<IStarGateCallBack>());
                ComputerList.Add(ClientInfo);
            }

            RefreshList();
        }

        private AccountInfo RequestAccount(string PCName)
        {
            AccountInfo AccountInfo = AccountList.FirstOrDefault(account => account.isAvaliable);
            if (AccountInfo != null)
            {
                AccountInfo.isAvaliable = false;
                lstLog.Invoke((MethodInvoker) delegate
                {
                    WriteLog(AccountInfo.UserNameValue + " has been assigned to " + PCName);
                    WriteLog((int.Parse(txtAccountNumber.Text) - 1) + " available Account(s) left");
                });
                txtAccountNumber.Invoke(
                    (MethodInvoker)
                        delegate { txtAccountNumber.Text = (int.Parse(txtAccountNumber.Text) - 1).ToString(); });

                return AccountInfo;
            }
            return null;
        }

        private void RefreshList()
        {
            lstWorkstations.Invoke((MethodInvoker) (() => lstWorkstations.Items.Clear()));

            int onlineNum = 0;
            int offlineNum = 0;
            foreach (Information iPC in ComputerList)
            {
                if (!string.IsNullOrEmpty(iPC.PCName))
                {
                    Information pc = iPC;
                    lstWorkstations.Invoke((MethodInvoker) delegate
                    {
                        //Code to modify control will go here
                        if (pc.PCStatus == 0)
                        {
                            lstWorkstations.Items.Add(pc.PCName, 0);
                            onlineNum++;
                        }
                        else
                        {
                            lstWorkstations.Items.Add(pc.PCName, 1);
                            offlineNum++;
                        }
                    });
                }
            }
            txtOnline.Invoke((MethodInvoker) delegate { txtOnline.Text = onlineNum.ToString(); });

            txtOffline.Invoke((MethodInvoker) delegate { txtOffline.Text = offlineNum.ToString(); });
        }

        private void _DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                IStarGate = new ServiceHost(_service);
                //IStarGate = new ServiceHost(typeof(D.E.M.O.N.Catalyst.GalaxyService.Observer));
                if (IStarGate.State != CommunicationState.Opened)
                {
                    IStarGate.Open();
                }

                e.Result = "K";
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }

        private void _RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                if (e.Result.ToString() == "K")
                {
                    WriteLog("Jupiter TCP Binding Service started successfully");
                    cmdStart.Enabled = false;
                }
                else
                {
                    WriteLog("Service Failed! Error:" + e.Result);
                }
            }
        }

        private void WriteLog(string Log)
        {
            lstLog.Items.Add(DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" +
                             DateTime.Now.Second.ToString("00") + "   " + Log);
            lstLog.SelectedIndex += 1;
        }

        private void cmdStop_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(Resources.frmMain_cmdStop_Click_Stop_Current_Server__Will_LOST_Current_Unsaved_Data__,
                    Resources.frmMain_cmdStop_Click_Warning, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (IStarGate != null)
                {
                    IStarGate.Abort();
                    IStarGate.Close();
                    IStarGate = null;
                }
                if (_BGWorker != null)
                {
                    //_BGWorker.CancelAsync();
                    _BGWorker.Dispose();
                    _BGWorker = null;
                }


                //HQServer.StopServer();
                Application.Exit();
            }
        }

        private void cmdMinimal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cmdName_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/raistlin.kpp");
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void cmdProcess_Click(object sender, EventArgs e)
        {
            if (lstWorkstations.SelectedIndex >= 0)
            {
                IStarGateCallBack _Callback =
                    ComputerListDic[lstWorkstations.Items[lstWorkstations.SelectedIndex].Value.ToString()];
                ProcessInfo[] ProcessList = _Callback.GetProcess();
                //_service.SendMessage(lstWorkstations.Items[lstWorkstations.SelectedIndex].Value.ToString(),"CCC");
                var xOpen = new frmProcess(ProcessList, _Callback);
                xOpen.ShowDialog();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string AccountFile = File.ReadAllText(Application.StartupPath + "\\Source\\Accounts.dat");
            string[] Accounts = AccountFile.Split('+');
            int AccountNum = 0;
            foreach (string account in Accounts)
            {
                string[] SAccountInfo = account.Split('|');
                var _Account = new AccountInfo
                {
                    UserNameValue = SAccountInfo[0],
                    PasswordValue = SAccountInfo[1],
                    isAvaliable = true
                };
                AccountList.Add(_Account);
                AccountNum++;
            }
            txtAccountNumber.Text = AccountNum.ToString();
            WriteLog(AccountNum + " Account(s) available for use");
            _service = new Observer();
            _service.OnClientConnected += AddClient;
            _service.OnAccountRequested += RequestAccount;
            //ComputerList = new List<Information>();
        }

        private void lstWorkstations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWorkstations.SelectedIndex != -1)
            {
                txtName.Text = ComputerList[lstWorkstations.SelectedIndex].PCName;
                txtIP.Text = ComputerList[lstWorkstations.SelectedIndex].PCIPAddress;
                txtMac.Text = ComputerList[lstWorkstations.SelectedIndex].PCMacAddress;
                txtMemSize.Text = ComputerList[lstWorkstations.SelectedIndex].PCMemorySize + " G";
            }
        }

        private void cmdAdvance_Click(object sender, EventArgs e)
        {
            if (lstWorkstations.SelectedIndex != -1)
            {
                var xOpen =
                    new frmAdvance(
                        ComputerListDic[lstWorkstations.Items[lstWorkstations.SelectedIndex].Value.ToString()]);
                xOpen.ShowDialog();
            }
        }

        private void cmdAccount_Click(object sender, EventArgs e)
        {
            if (lstWorkstations.SelectedIndex != -1)
            {
                var xOpen = new frmAccount();
                xOpen.ShowDialog();
            }
        }
    }
}