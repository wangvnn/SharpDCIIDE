// Guids.cs
// MUST match guids.h
using System;

namespace KimHaiQuang.SharpDCIIDE
{
    static class GuidList
    {
        public const string guidSharpDCIIDEPkgString = "dbeb2f20-12b8-45e2-9010-b63802ffa86e";
        public const string guidSharpDCIIDECmdSetString = "6d1606af-0901-4946-b944-f830ac9fbf60";
        public const string guidToolWindowPersistanceString = "47ad6db0-3c31-4eba-9947-162f379ad2a3";

        public static readonly Guid guidSharpDCIIDECmdSet = new Guid(guidSharpDCIIDECmdSetString);
    };
}