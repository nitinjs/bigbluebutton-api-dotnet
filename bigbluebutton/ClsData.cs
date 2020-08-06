//Created by Nitin Sawant<nitin@nitinsawant.com>
//Copyright (c) 2020 zikbee.com
using System;
using System.Collections.Generic;
using System.Text;

namespace bigbluebutton
{
    public class ClsData
    {
        #region "getSha1"        
        /// <summary>
        /// Returns the SHA-1 Value for the InputString
        /// </summary>
        /// <param name="str">InputString</param>
        /// <returns></returns>
        public static string getSha1(string StrValue)
        {
            HashFx md = new HashFx();
            return md.encryptString(StrValue, 1);
        }
        #endregion
    }
}
