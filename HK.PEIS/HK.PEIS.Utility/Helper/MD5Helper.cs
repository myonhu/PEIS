﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace HK.PEIS.Utility.Helper
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public static class MD5Helper
    {
        /// <summary>
        /// 加密MD5
        /// </summary>
        /// <param name="toCryString">toCryString</param>
        /// <returns></returns>
        public static string EncryptionMD5(string toCryString)
        {
            MD5CryptoServiceProvider hashmd5;
            hashmd5 = new MD5CryptoServiceProvider();
            return BitConverter.ToString(hashmd5.ComputeHash(Encoding.UTF8.GetBytes(toCryString))).Replace("-", "").ToLower();
        }

        /// <summary>
        /// 获得MD5哈希值
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetMD5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        /// <summary>
        /// 验证 MD5 哈希值
        /// </summary>
        /// <param name="input"></param>
        /// <param name="hash"></param>
        /// <returns></returns>
        public static bool VerifyMD5Hash(string input, string hash, bool isClearText = true)
        {
            string hashOfInput = string.Empty;
            if (isClearText)
                hashOfInput = GetMD5Hash(input);
            else
                hashOfInput = input;
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            return false;
        }
    }
}
