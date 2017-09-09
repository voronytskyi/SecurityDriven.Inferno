﻿using System;
using System.Security.Cryptography;

namespace SecurityDriven.Inferno.Hash
{
    public static class HashFactories
    {
        static readonly Func<SHA1> ManagedSHA1 = () => new SHA1Managed();

        static readonly Func<SHA256> ManagedSHA256 = () => new SHA256Managed();

        static readonly Func<SHA384> ManagedSHA384 = () => new SHA384Managed();

        static readonly Func<SHA512> ManagedSHA512 = () => new SHA512Managed();

        internal static readonly Func<SHA1> SHA1 = ManagedSHA1;
        public static readonly Func<SHA256> SHA256 = ManagedSHA256;
        public static readonly Func<SHA384> SHA384 = ManagedSHA384;
        public static readonly Func<SHA512> SHA512 = ManagedSHA512;
    }// HashFactories class
}//ns