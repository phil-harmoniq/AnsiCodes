using System;

namespace AnsiCodes
{
    /// <summary> Container class for all available formatting options </summary>
    public class Format
    {
        /// <summary> Bold ANSI code (format strings with it) </summary>
        public static readonly string Bold = "\x1B[1m";

        /// <summary> Dim ANSI code (format strings with it) </summary>
        public static readonly string Dim = "\x1B[2m";

        /// <summary> Underline ANSI code (format strings with it) </summary>
        public static readonly string Underline = "\x1B[4m";

        /// <summary> Invert ANSI code (format strings with it) </summary>
        public static readonly string Invert = "\x1B[7m";

        /// <summary> Hidden ANSI code (format strings with it) </summary>
        public static readonly string Hidden = "\x1B[8m";


        /// <summary> Reset bold ANSI code (format strings with it) </summary>
        public static readonly string UnBold = "\x1B[21m";

        /// <summary> Reset dim ANSI code (format strings with it) </summary>
        public static readonly string UnDim = "\x1B[22m";

        /// <summary> Reset underline ANSI code (format strings with it) </summary>
        public static readonly string UnUnderline = "\x1B[24m";

        /// <summary> Reset invert ANSI code (format strings with it) </summary>
        public static readonly string UnInvert = "\x1B[27m";

        /// <summary> Reset hidden ANSI code (format strings with it) </summary>
        public static readonly string UnHidden = "\x1B[28m";

        /// <summary> Reset all formatting ANSI codes (format strings with it) </summary>
        public static readonly string Default = UnBold + UnDim + UnUnderline + UnInvert + UnHidden;


        /// <summary> Enable bold formatting without printing </summary>
        public static void SetBold() => Console.Write(Bold);

        /// <summary> Enable dim formatting without printing </summary>
        public static void SetDim() => Console.Write(Dim);

        /// <summary> Enable underline formatting without printing </summary>
        public static void SetUnderline() => Console.Write(Underline);

        /// <summary> Enable inverted formatting without printing </summary>
        public static void SetInvert() => Console.Write(Invert);

        /// <summary> Enable hidden formatting without printing </summary>
        public static void SetHidden() => Console.Write(Hidden);


        /// <summary> Disable bold formatting without printing </summary>
        public static void UnsetBold() => Console.Write(UnBold);

        /// <summary> Disable dim formatting without printing </summary>
        public static void UnsetDim() => Console.Write(UnDim);

        /// <summary> Disable underline formatting without printing </summary>
        public static void UnsetUnderline() => Console.Write(UnUnderline);

        /// <summary> Disable inverted formatting without printing </summary>
        public static void UnsetInvert() => Console.Write(UnInvert);

        /// <summary> Disable hidden formatting without printing </summary>
        public static void UnsetHidden() => Console.Write(UnHidden);

        /// <summary> Disable all formatting without printing </summary>
        public static void Reset() => Console.Write(UnBold + UnDim + UnUnderline + UnInvert + UnHidden);
    }
}