using System;

namespace AnsiCodes
{
    /// <summary> Container class for resetting all formatting and colors </summary>
    public class Reset
    {
        /// <summary> All attribute reset ANSI code (format strings with it) </summary>
        public static string All = "\x1B[0m";

        /// <summary> Disable all formatting and reset colors without printing </summary>
        public static void ResetAll() => Console.Write(All);
    }
}