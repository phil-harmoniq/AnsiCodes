using System;

namespace AnsiCodes
{
    /// <summary> Container class for all available foreground colors </summary>
    public class Color
    {
        /// <summary> Default foreground ANSI code (format strings with it) </summary>
        public const string Default = "\x1B[39m";

        /// <summary> Black foreground ANSI code (format strings with it) </summary>
        public const string Black = "\x1B[30m";

        /// <summary> White foreground ANSI code (format strings with it) </summary>
        public const string White = "\x1B[97m";

        /// <summary> Red foreground ANSI code (format strings with it) </summary>
        public const string Red = "\x1B[31m";

        /// <summary> Green foreground ANSI code (format strings with it) </summary>
        public const string Green = "\x1B[32m";

        /// <summary> Yellow foreground ANSI code (format strings with it) </summary>
        public const string Yellow = "\x1B[33m";

        /// <summary> Blue foreground ANSI code (format strings with it) </summary>
        public const string Blue = "\x1B[34m";

        /// <summary> Magenta foreground ANSI code (format strings with it) </summary>
        public const string Magenta = "\x1B[35m";

        /// <summary> Cyan foreground ANSI code (format strings with it) </summary>
        public const string Cyan = "\x1B[36m";

        /// <summary> Light gray foreground ANSI code (format strings with it) </summary>
        public const string LtGray = "\x1B[37m";

        /// <summary> Dark gray foreground ANSI code (format strings with it) </summary>
        public const string DrkGray = "\x1B[90m";

        /// <summary> Light red foreground ANSI code (format strings with it) </summary>
        public const string LtRed = "\x1B[91m";

        /// <summary> Light green foreground ANSI code (format strings with it) </summary>
        public const string LtGreen = "\x1B[92m";

        /// <summary> Light yellow foreground ANSI code (format strings with it) </summary>
        public const string LtYellow = "\x1B[93m";

        /// <summary> Light blue foreground ANSI code (format strings with it) </summary>
        public const string LtBlue = "\x1B[94m";

        /// <summary> Light magenta foreground ANSI code (format strings with it) </summary>
        public const string LtMagenta = "\x1B[95m";

        /// <summary> Light cyan foreground ANSI code (format strings with it) </summary>
        public const string LtCyan = "\x1B[96m";


        /// <summary> Set foreground color to default without printing </summary>
        public static void Rest() => Console.Write(Default);

        /// <summary> Set foreground color to black without printing </summary>
        public static void SetBlack() => Console.Write(Black);

        /// <summary> Set foreground color to white without printing </summary>
        public static void SetWhite() => Console.Write(White);

        /// <summary> Set foreground color to red without printing </summary>
        public static void SetRed() => Console.Write(Red);

        /// <summary> Set foreground color to green without printing </summary>
        public static void SetGreen() => Console.Write(Green);

        /// <summary> Set foreground color to yellow without printing </summary>
        public static void SetYellow() => Console.Write(Yellow);

        /// <summary> Set foreground color to blue without printing </summary>
        public static void SetBlue() => Console.Write(Blue);

        /// <summary> Set foreground color to magenta without printing </summary>
        public static void SetMagenta() => Console.Write(Magenta);

        /// <summary> Set foreground color to cyan without printing </summary>
        public static void SetCyan() => Console.Write(Cyan);

        /// <summary> Set foreground color to light gray without printing </summary>
        public static void SetLtGray() => Console.Write(LtGray);

        /// <summary> Set foreground color to dark gray without printing </summary>
        public static void SetDrkGray() => Console.Write(DrkGray);

        /// <summary> Set foreground color to light red without printing </summary>
        public static void SetLtRed() => Console.Write(LtRed);

        /// <summary> Set foreground color to light green without printing </summary>
        public static void SetLtGreen() => Console.Write(LtGreen);

        /// <summary> Set foreground color to light yellow without printing </summary>
        public static void SetLtYellow() => Console.Write(LtYellow);

        /// <summary> Set foreground color to light blue without printing </summary>
        public static void SetLtBlue() => Console.Write(LtBlue);

        /// <summary> Set foreground color to light magenta without printing </summary>
        public static void SetLtMagenta() => Console.Write(LtMagenta);

        /// <summary> Set foreground color to light cyan without printing </summary>
        public static void SetLtCyan() => Console.Write(LtCyan);
    }
}