using System;

namespace AnsiCodes
{
    /// <summary> Container class for all available foreground colors </summary>
    public static class Color
    {
        /// <summary> Default foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Default = new AnsiCode("\x1B[39m");

        /// <summary> Black foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Black = new AnsiCode("\x1B[30m");

        /// <summary> White foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode White = new AnsiCode("\x1B[97m");

        /// <summary> Red foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Red = new AnsiCode("\x1B[31m");

        /// <summary> Green foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Green = new AnsiCode("\x1B[32m");

        /// <summary> Yellow foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Yellow = new AnsiCode("\x1B[33m");

        /// <summary> Blue foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Blue = new AnsiCode("\x1B[34m");

        /// <summary> Magenta foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Magenta = new AnsiCode("\x1B[35m");

        /// <summary> Cyan foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Cyan = new AnsiCode("\x1B[36m");

        /// <summary> Light gray foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtGray = new AnsiCode("\x1B[37m");

        /// <summary> Dark gray foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode DrkGray = new AnsiCode("\x1B[90m");

        /// <summary> Light red foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtRed = new AnsiCode("\x1B[91m");

        /// <summary> Light green foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtGreen = new AnsiCode("\x1B[92m");

        /// <summary> Light yellow foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtYellow = new AnsiCode("\x1B[93m");

        /// <summary> Light blue foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtBlue = new AnsiCode("\x1B[94m");

        /// <summary> Light magenta foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtMagenta = new AnsiCode("\x1B[95m");

        /// <summary> Light cyan foreground ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtCyan = new AnsiCode("\x1B[96m");


        /// <summary> Set foreground color to default without printing </summary>
        public static void Reset() => Console.Write(Default.Code);

        /// <summary> Set foreground color to black without printing </summary>
        public static void SetBlack() => Console.Write(Black.Code);

        /// <summary> Set foreground color to white without printing </summary>
        public static void SetWhite() => Console.Write(White.Code);

        /// <summary> Set foreground color to red without printing </summary>
        public static void SetRed() => Console.Write(Red.Code);

        /// <summary> Set foreground color to green without printing </summary>
        public static void SetGreen() => Console.Write(Green.Code);

        /// <summary> Set foreground color to yellow without printing </summary>
        public static void SetYellow() => Console.Write(Yellow.Code);

        /// <summary> Set foreground color to blue without printing </summary>
        public static void SetBlue() => Console.Write(Blue.Code);

        /// <summary> Set foreground color to magenta without printing </summary>
        public static void SetMagenta() => Console.Write(Magenta.Code);

        /// <summary> Set foreground color to cyan without printing </summary>
        public static void SetCyan() => Console.Write(Cyan.Code);

        /// <summary> Set foreground color to light gray without printing </summary>
        public static void SetLtGray() => Console.Write(LtGray.Code);

        /// <summary> Set foreground color to dark gray without printing </summary>
        public static void SetDrkGray() => Console.Write(DrkGray.Code);

        /// <summary> Set foreground color to light red without printing </summary>
        public static void SetLtRed() => Console.Write(LtRed.Code);

        /// <summary> Set foreground color to light green without printing </summary>
        public static void SetLtGreen() => Console.Write(LtGreen.Code);

        /// <summary> Set foreground color to light yellow without printing </summary>
        public static void SetLtYellow() => Console.Write(LtYellow.Code);

        /// <summary> Set foreground color to light blue without printing </summary>
        public static void SetLtBlue() => Console.Write(LtBlue.Code);

        /// <summary> Set foreground color to light magenta without printing </summary>
        public static void SetLtMagenta() => Console.Write(LtMagenta.Code);

        /// <summary> Set foreground color to light cyan without printing </summary>
        public static void SetLtCyan() => Console.Write(LtCyan.Code);
    }
}