﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MS_Entity
{
    public static class Byte
    {
        // publics
        #region ToByteArray
        public static byte[] ToByteArray(byte value)
        {
            byte[] bytes = new byte[] { value};
            return bytes;
        }
        #endregion
        #region FromByteArray
        public static byte FromByteArray(byte[] bytes)
        {
            return bytes[0];
        }
        #endregion
    }
}
