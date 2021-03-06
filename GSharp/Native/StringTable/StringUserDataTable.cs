﻿using GSharp.Native.Classes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GSharp.Native.StringTable
{
    public class StringUserDataTable<TClass>
    {
        private INetworkStringTable table;

        internal StringUserDataTable(INetworkStringTable table)
        {
            this.table = table;
        }

        public TClass GetUserData(int index, IntPtr lengthOut = default(IntPtr))
        {
            var ptr = table.GetStringUserData(index, lengthOut);
            return Marshal.PtrToStructure<TClass>(ptr);
        }

        public int Count()
        {
            return table.GetNumStrings();
        }

        public TClass this[int index]
        {
            get
            {
                return GetUserData(index);
            }
        }
    }
}
