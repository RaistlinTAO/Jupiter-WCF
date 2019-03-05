#region Copyright ©  2006 - 2014 D.E.M.O.N.Studio

// -------------------------------------------
//  This File belongs to D.E.M.O.N Studio
//  All rights received.
// 
//  DemonVK@Gmail.com
// -------------------------------------------
// 
//   File Name: frmAdvance.cs
//   Project: Jupiter
//   Solution: Jupiter
// 
// -------------------------------------------
// 
//   Created Date: 11:34 PM 22/02/2014
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
    public partial class frmAdvance : XtraForm
    {
        private readonly IStarGateCallBack _iCallBack;

        public frmAdvance(IStarGateCallBack iCallBack)
        {
            InitializeComponent();
            _iCallBack = iCallBack;
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {
            _iCallBack.SendMessage(txtMessage.Text);
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}