﻿using GSharp.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GSharp.Native.Classes
{
    public static class StringTableInterfaceName
    {
        public const string SERVER = "VEngineServerStringTable001";
        public const string CLIENT = "VEngineClientStringTable001";
    }

    [ModuleName("engine")]
    public interface INetworkStringTableContainer
    {

        [VTableOffset(1)]
        IntPtr CreateStringTable(string tableName, int maxentries, int userdatafixedsize = 0, int userdatanetworkbits = 0); //returns INetworkStringTable
        void RemoveAllTables();
        // table infos
        IntPtr FindTable(string tableName); //returns INetworkStringTable
        IntPtr GetTable(int stringTable); //returns INetworkStringTable
        int GetNumTables();

        IntPtr CreateStringTableEx(string tableName, int maxentries, int userdatafixedsize = 0, int userdatanetworkbits = 0, bool bIsFilenames = false); //returns INetworkStringTable
        void SetAllowClientSideAddString(IntPtr INetworkStringTable, bool bAllowClientSideAddString);

    }
}
