#region Copyright ©  2006 - 2014 D.E.M.O.N.Studio

// -------------------------------------------
//  This File belongs to D.E.M.O.N Studio
//  All rights received.
// 
//  DemonVK@Gmail.com
// -------------------------------------------
// 
//   File Name: Observer.cs
//   Project: D.E.M.O.N.Catalyst
//   Solution: Jupiter
// 
// -------------------------------------------
// 
//   Created Date: 9:44 AM 20/02/2014
// 
// -------------------------------------------

#endregion

#region

using System.ServiceModel;

#endregion

namespace D.E.M.O.N.Catalyst.GalaxyService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Observer : StarGate
    {
        public delegate AccountInfo RequestAccountFromClient(string PCName);

        public delegate void UploadFromClient(string value);

        public void UploadInformation(string value)
        {
            if (OnClientConnected != null)
            {
                OnClientConnected(value);
            }
        }

        public AccountInfo RequestAccount(string PCName)
        {
            if (OnAccountRequested != null)
            {
                return OnAccountRequested(PCName);
            }
            return null;
        }

        public event UploadFromClient OnClientConnected;
        public event RequestAccountFromClient OnAccountRequested;


        public ProcessInfo[] GetProcess(IStarGateCallBack iCallback)
        {
            return iCallback.GetProcess();
        }
    }
}