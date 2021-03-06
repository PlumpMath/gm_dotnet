﻿using GSharp;
using GSharp.Native.Classes;
using RGiesecke.DllExport;
using StackExchange.Redis;
using System;
using System.Runtime.InteropServices;

namespace gm_redis
{
    public class Module
    {

        [DllExport("gmod13_open", CallingConvention = CallingConvention.Cdecl)]
        public static int Open(lua_state L)
        {
            var types = Wrapper.GetAllDeclaredTypesUsed(typeof(ConnectionMultiplexer));
            return 0;
        }

        [DllExport("gmod13_close", CallingConvention = CallingConvention.Cdecl)]
        public static int Close(IntPtr L)
        {
            return 0;
        }
    }
}
