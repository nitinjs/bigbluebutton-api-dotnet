using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace bigbluebutton
{
    public class HashFx
    {
        public HashFx()
        {

        }
        /// <summary>
        /// returns MD5 hash of a string :-)
        /// </summary>
        /// <param name="strToEncrypt"></param>
        /// <returns></returns>
        public string encryptString(string strToEncrypt)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] bytes = ue.GetBytes(strToEncrypt);

            // encrypt bytes
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);

            // Convert the encrypted bytes back to a string (base 16)
            string hashString = "";

            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.PadLeft(32, '0');
        }

        /// <param name="strToEncryp">the string to hash</param>
        /// <param name="Algorithm">the Algorithm of choice. 0 for MD5, 1 for SHA-1</param>
        /// <returns></returns>
        public string encryptString(string strToEncryp, int Algorithm)
        {
            if (Algorithm == 1)
            {
                System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
                byte[] bytes = ue.GetBytes(strToEncryp);

                // encrypt bytes
                System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                SHA1CryptoServiceProvider SHA = new SHA1CryptoServiceProvider();
                byte[] hashBytes = SHA.ComputeHash(bytes);

                // Convert the encrypted bytes back to a string (base 16)
                string hashString = "";

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
                }

                return hashString.PadLeft(32, '0');
            }
            else
            {
                return encryptString(strToEncryp);
            }
            return null;
        }
        /// <summary>
        /// converts the MD5 of SHA-1 result byte[] to a string representative
        /// </summary>
        /// <param name="RawStringBytes">the Raw bytes to hash</param>
        /// <returns></returns>
        public string encryptString(byte[] RawStringBytes)
        {

            string hashString = "";
            for (int i = 0; i < RawStringBytes.Length; i++)
            {
                hashString += Convert.ToString(RawStringBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.PadLeft(32, '0');

        }
        /// <summary>
        /// For MD5 hashing of files
        /// </summary>
        /// <param name="filepath">the file path of the file to hash</param>
        /// <returns></returns>
        public string Md5File(string filepath)
        {
            FileStream filestrm = new FileStream(filepath, FileMode.Open);
            byte[] md5byte = new byte[filestrm.Length];

            filestrm.Read(md5byte, 0, Convert.ToInt32(filestrm.Length.ToString()));
            byte[] ResultHash = HashByte(md5byte);


            string hashString = "";

            for (int i = 0; i < ResultHash.Length; i++)
            {
                hashString += Convert.ToString(ResultHash[i], 16).PadLeft(2, '0');
            }
            filestrm.Close();
            return hashString.PadLeft(32, '0');

        }




        public byte[] HashByte(byte[] bytes)
        {

            // encrypt bytes
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);

            // Convert the encrypted bytes back to a string (base 16)

            return hashBytes;
        }

        public byte[] HashByte(byte[] bytes, int Algorithm)
        {
            byte[] hashBytes = null;

            if (Algorithm == 0)//MD5
            {

                System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                hashBytes = md5.ComputeHash(bytes);
            }
            else if (Algorithm == 1)//SHA-1
            {//SHA-1
             // Convert the encrypted bytes back to a string (base 16)
                SHA1CryptoServiceProvider SHS = new SHA1CryptoServiceProvider();
                hashBytes = SHS.ComputeHash(bytes);
            }
            else
            {
                return null;
            }
            return hashBytes;
        }

    }
}
