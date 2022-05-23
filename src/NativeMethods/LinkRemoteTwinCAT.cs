/*
 * File: LinkRemoteTwinCAT.cs
 * Project: NativeMethods
 * Created Date: 23/05/2022
 * Author: Shun Suzuki
 * -----
 * Last Modified: 23/05/2022
 * Modified By: Shun Suzuki (suzuki@hapis.k.u-tokyo.ac.jp)
 * -----
 * Copyright (c) 2022 Hapis Lab. All rights reserved.
 * 
 */


using System;
using System.Runtime.InteropServices;

namespace AUTD3Sharp.NativeMethods
{
    internal static class LinkRemoteTwinCAT
    {
        [DllImport("autd3capi-link-remote-twincat", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDLinkRemoteTwinCAT(out IntPtr @out, string remoteIpAddr, string remoteAmsNetId, string localAmsNetId, ushort cycleTicks);
    }
}