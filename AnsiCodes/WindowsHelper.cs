using System;
using System.Runtime.InteropServices;

namespace AnsiCodes
{
    /// <summary>
    /// This hack enables ANSI codes in modern Windows terminals.
    /// Original author: https://www.jerriepelser.com/blog/using-ansi-color-codes-in-net-console-apps/
    /// TODO: Add extra checks to determine if using a modern version of Windows and an ANSI-compatible windows console
    /// </summary>
    internal static class WindowsHelper
    {
        private const int STD_OUTPUT_HANDLE = -11;
        private const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;
        private const uint DISABLE_NEWLINE_AUTO_RETURN = 0x0008;

        [DllImport("kernel32.dll")]
        private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        private static extern uint GetLastError();

        internal static bool IsWindows => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        internal static bool AnsiEnabled { get; private set; } = false;

        static WindowsHelper()
        {
            if (IsWindows)
            {
                var iStdOut = GetStdHandle(STD_OUTPUT_HANDLE);

                if (!GetConsoleMode(iStdOut, out uint outConsoleMode))
                {
                    Console.WriteLine("failed to get output console mode");
                }

                outConsoleMode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING | DISABLE_NEWLINE_AUTO_RETURN;
                if (!SetConsoleMode(iStdOut, outConsoleMode))
                {
                    Console.WriteLine($"failed to set output console mode, error code: {GetLastError()}");
                }

                AnsiEnabled = true;
            }
        }
    }
}