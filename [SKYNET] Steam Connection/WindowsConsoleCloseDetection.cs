using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SKYNET
{
    public class WindowsConsoleCloseDetection
    {
        static List<ConsoleEventDelegate> handlerList = new List<ConsoleEventDelegate>();
        public delegate bool ConsoleEventDelegate(int eventType);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetConsoleCtrlHandler(ConsoleEventDelegate callback, bool add);
        public static void SetCloseHandler(ConsoleEventDelegate handler)
        {
            handlerList.Add(handler);
            SetConsoleCtrlHandler(handler, true);
        }
    }
}