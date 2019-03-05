#region Copyright ©  2006 - 2014 D.E.M.O.N.Studio

// -------------------------------------------
//  This File belongs to D.E.M.O.N Studio
//  All rights received.
// 
//  DemonVK@Gmail.com
// -------------------------------------------
// 
//   File Name: frmProcess.cs
//   Project: Jupiter
//   Solution: Jupiter
// 
// -------------------------------------------
// 
//   Created Date: 10:33 PM 22/02/2014
// 
// -------------------------------------------

#endregion

#region

using System;
using System.Windows.Forms;
using D.E.M.O.N.Catalyst;
using DevExpress.XtraEditors;

#endregion

namespace Jupiter.UI.Functions
{
    public partial class frmProcess : XtraForm
    {
        private readonly IStarGateCallBack _CallBack;
        private readonly ProcessInfo[] _ProcessList;

        public frmProcess(ProcessInfo[] ProcessList, IStarGateCallBack iCallBack)
        {
            InitializeComponent();
            _ProcessList = ProcessList;
            _CallBack = iCallBack;
        }

        private void frmProcess_Load(object sender, EventArgs e)
        {
            foreach (ProcessInfo _process in _ProcessList)
            {
                var _item = new ListViewItem {Text = _process.ProcessNameValue};
                _item.SubItems.Add(_process.ProcessNameIDValue);
                _item.SubItems.Add(_process.ProcessHandleNumber.ToString());
                lstProcess.Items.Add(_item);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cmdKill_Click(object sender, EventArgs e)
        {
            if (lstProcess.SelectedItems[0].Text != null)
            {
                if (_CallBack.KillProcess(lstProcess.SelectedItems[0].Text))
                {
                    lstProcess.SelectedItems[0].Remove();
                }
            }
        }
    }
}