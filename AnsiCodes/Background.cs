using System;

namespace AnsiCodes
{
    /// <summary> Container class for all available foreground colors </summary>
    public sealed class Background
    {
        /// <summary> Default background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Default = new AnsiCode("\x1B[49m");

        /// <summary> Black background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Black = new AnsiCode("\x1B[40m");

        /// <summary> White background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode White = new AnsiCode("\x1B[107m");

        /// <summary> Red background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Red = new AnsiCode("\x1B[41m");

        /// <summary> Green background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Green = new AnsiCode("\x1B[42m");

        /// <summary> Yellow background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Yellow = new AnsiCode("\x1B[43m");

        /// <summary> Blue background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Blue = new AnsiCode("\x1B[44m");

        /// <summary> Magenta background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Magenta = new AnsiCode("\x1B[45m");

        /// <summary> Cyan background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode Cyan = new AnsiCode("\x1B[46m");

        /// <summary> Light gray background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtGray = new AnsiCode("\x1B[47m");

        /// <summary> Dark gray background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode DrkGray = new AnsiCode("\x1B[100m");

        /// <summary> Light red background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtRed = new AnsiCode("\x1B[101m");

        /// <summary> Light green background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtGreen = new AnsiCode("\x1B[102m");

        /// <summary> Light yellow background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtYellow = new AnsiCode("\x1B[103m");

        /// <summary> Light blue background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtBlue = new AnsiCode("\x1B[104m");

        /// <summary> Light magenta background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtMagenta = new AnsiCode("\x1B[105m");

        /// <summary> Light cyan background ANSI code (format strings with it) </summary>
        public static readonly AnsiCode LtCyan = new AnsiCode("\x1B[106m");


        /// <summary> Set background color to default without printing </summary>
        public static void Reset() => Console.Write(Default);

        /// <summary> Set background color to black without printing </summary>
        public static void SetBlack() => Console.Write(Black);

        /// <summary> Set background color to white without printing </summary>
        public static void SetWhite() => Console.Write(White);

        /// <summary> Set background color to red without printing </summary>
        public static void SetRed() => Console.Write(Red);

        /// <summary> Set background color to green without printing </summary>
        public static void SetGreen() => Console.Write(Green);

        /// <summary> Set background color to yellow without printing </summary>
        public static void SetYellow() => Console.Write(Yellow);

        /// <summary> Set background color to blue without printing </summary>
        public static void SetBlue() => Console.Write(Blue);

        /// <summary> Set background color to magenta without printing </summary>
        public static void SetMagenta() => Console.Write(Magenta);

        /// <summary> Set background color to cyan without printing </summary>
        public static void SetCyan() => Console.Write(Cyan);

        /// <summary> Set background color to light gray without printing </summary>
        public static void SetLtGray() => Console.Write(LtGray);

        /// <summary> Set background color to dark gray without printing </summary>
        public static void SetDrkGray() => Console.Write(DrkGray);

        /// <summary> Set background color to light red without printing </summary>
        public static void SetLtRed() => Console.Write(LtRed);

        /// <summary> Set background color to light green without printing </summary>
        public static void SetLtGreen() => Console.Write(LtGreen);

        /// <summary> Set background color to light yellow without printing </summary>
        public static void SetLtYellow() => Console.Write(LtYellow);

        /// <summary> Set background color to light blue without printing </summary>
        public static void SetLtBlue() => Console.Write(LtBlue);

        /// <summary> Set background color to light magenta without printing </summary>
        public static void SetLtMagenta() => Console.Write(LtMagenta);
    }
}