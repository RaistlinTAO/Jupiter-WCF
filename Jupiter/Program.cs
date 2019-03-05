#region Copyright ©  2006 - 2014 D.E.M.O.N.Studio

// -------------------------------------------
//  This File belongs to D.E.M.O.N Studio
//  All rights received.
// 
//  DemonVK@Gmail.com
// -------------------------------------------
// 
//   File Name: Program.cs
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
using System.Windows.Forms;
using Jupiter.UI;

#endregion

namespace Jupiter
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}