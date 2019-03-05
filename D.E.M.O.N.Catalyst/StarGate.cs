#region Copyright ©  2006 - 2014 D.E.M.O.N.Studio

// -------------------------------------------
//  This File belongs to D.E.M.O.N Studio
//  All rights received.
// 
//  DemonVK@Gmail.com
// -------------------------------------------
// 
//   File Name: StarGate.cs
//   Project: D.E.M.O.N.Catalyst
//   Solution: Jupiter
// 
// -------------------------------------------
// 
//   Created Date: 9:47 AM 20/02/2014
// 
// -------------------------------------------

#endregion

#region

using System.Runtime.Serialization;
using System.ServiceModel;

#endregion

namespace D.E.M.O.N.Catalyst
{
    [ServiceContract(CallbackContract = typeof (IStarGateCallBack))]
    public interface StarGate
    {
        [OperationContract]
        void UploadInformation(string value);

        [OperationContract]
        AccountInfo RequestAccount(string PCName);
    }

    public interface IStarGateCallBack
    {
        [OperationContract(IsOneWay = false)]
        ProcessInfo[] GetProcess();

        [OperationContract(IsOneWay = false)]
        bool KillProcess(string ProcessName);

        [OperationContract(IsOneWay = true)]
        void SendMessage(string Message);
    }

    [DataContract]
    public class AccountInfo
    {
        [DataMember]
        public string UserNameValue { get; set; }

        [DataMember]
        public string PasswordValue { get; set; }

        [DataMember]
        public bool isAvaliable { get; set; }
    }

    [DataContract]
    public class ProcessInfo
    {
        [DataMember]
        public string ProcessNameValue { get; set; }

        [DataMember]
        public string ProcessNameIDValue { get; set; }

        [DataMember]
        public int ProcessHandleNumber { get; set; }
    }
}