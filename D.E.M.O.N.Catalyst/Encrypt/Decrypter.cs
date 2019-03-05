#region Copyright ©  2006 - 2014 D.E.M.O.N.Studio

// -------------------------------------------
//  This File belongs to D.E.M.O.N Studio
//  All rights received.
// 
//  DemonVK@Gmail.com
// -------------------------------------------
// 
//   File Name: Decrypter.cs
//   Project: D.E.M.O.N.Catalyst
//   Solution: Jupiter
// 
// -------------------------------------------
// 
//   Created Date: 6:38 PM 20/02/2014
// 
// -------------------------------------------

#endregion

#region

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using D.E.M.O.N.Catalyst.Workstation;

#endregion

namespace D.E.M.O.N.Catalyst.Encrypt
{
    public class Decrypter
    {
        private const string Key =
            ")(*&^%$#@RTYUIOLKGfjkkjdfhjk~!@l876!@#78u38yt587h3ovuhw2boiy231k'][wert[p453][}{Petwrgfd";

        private const string EKey = "g)fd~j&td%gl$(bj";
        private const string QKey = "9uhp';lko;/lp[";
        private static readonly SymmetricAlgorithm mobjCryptoService = new RijndaelManaged();

        #region Rijndael算法

        /// <summary>
        ///     获得密钥
        /// </summary>
        /// <returns>密钥</returns>
        private static byte[] GetLegalKey()
        {
            string sTemp = Key;
            mobjCryptoService.GenerateKey();
            byte[] bytTemp = mobjCryptoService.Key;
            int KeyLength = bytTemp.Length;
            if (sTemp.Length > KeyLength)
                sTemp = sTemp.Substring(0, KeyLength);
            else if (sTemp.Length < KeyLength)
                sTemp = sTemp.PadRight(KeyLength, ' ');
            return Encoding.ASCII.GetBytes(sTemp);
        }

        /// <summary>
        ///     获得初始向量IV
        /// </summary>
        /// <returns>初试向量IV</returns>
        private static byte[] GetLegalIV()
        {
            string sTemp = "safljkvi235$#%^YHTJMSgspo9065i7ko=-6]]'hRETY$%sgfgh#$%Ebds1!~@#$%^9*&^gdfh";
            mobjCryptoService.GenerateIV();
            byte[] bytTemp = mobjCryptoService.IV;
            int IVLength = bytTemp.Length;
            if (sTemp.Length > IVLength)
                sTemp = sTemp.Substring(0, IVLength);
            else if (sTemp.Length < IVLength)
                sTemp = sTemp.PadRight(IVLength, ' ');
            return Encoding.ASCII.GetBytes(sTemp);
        }

        /// <summary>
        ///     加密方法
        /// </summary>
        /// <param name="Source">待加密的串</param>
        /// <returns>经过加密的串</returns>
        private static string EncryptRijndael(string Source)
        {
            byte[] bytIn = Encoding.UTF8.GetBytes(Source);
            var ms = new MemoryStream();
            mobjCryptoService.Key = GetLegalKey();
            mobjCryptoService.IV = GetLegalIV();
            ICryptoTransform encrypto = mobjCryptoService.CreateEncryptor();
            var cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            ms.Close();
            byte[] bytOut = ms.ToArray();
            return Convert.ToBase64String(bytOut);
        }

        /// <summary>
        ///     解密方法
        /// </summary>
        /// <param name="Source">待解密的串</param>
        /// <returns>经过解密的串</returns>
        private static string DecryptRijndael(string Source)
        {
            byte[] bytIn = Convert.FromBase64String(Source);
            var ms = new MemoryStream(bytIn, 0, bytIn.Length);
            mobjCryptoService.Key = GetLegalKey();
            mobjCryptoService.IV = GetLegalIV();
            ICryptoTransform encrypto = mobjCryptoService.CreateDecryptor();
            var cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
            var sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

        private static string encryptDecryptStr(string p, byte key)
        {
            byte[] bs = Encoding.ASCII.GetBytes(p);
            for (int i = 0; i < bs.Length; i++)
            {
                bs[i] = (byte) (bs[i] ^ key);
            }
            return Encoding.ASCII.GetString(bs);
        }

        private static string CryptString(string HashStr)
        {
            return encryptDecryptStr(HashStr, byte.Parse("7"));
        }

        #endregion

        public Information GetInfoString(string EncryptString)
        {
            var returnValue = new Information();

            string itemp = DecryptRijndael(EncryptString);
            itemp = itemp.Replace(EncryptRijndael(QKey), "");
            itemp = itemp.Replace(CryptString(EKey), "！");
            string[] iArray = Regex.Split(itemp, "！");
            returnValue.PCMacAddress = DecryptRijndael(CryptString(iArray[0]));
            returnValue.PCName = DecryptRijndael(CryptString(iArray[1]));
            returnValue.PCMemorySize = DecryptRijndael(CryptString(iArray[2]));
            returnValue.PCIPAddress = DecryptRijndael(CryptString(iArray[3]));
            returnValue.PCCurrectTime = DecryptRijndael(CryptString(iArray[4]));
            return returnValue;
        }
    }
}