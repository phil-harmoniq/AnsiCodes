using System;
using System.Diagnostics;
using System.Reflection;

namespace AnsiCodes.CliTest
{
    class Program
    {
        private static string _assembly = Assembly.GetExecutingAssembly().Location;
        private static string _version = FileVersionInfo.GetVersionInfo(_assembly).ProductVersion;

        static void Main(string[] args)
        {
            SayHello();
            Console.WriteLine(
                $"This library {Format.Underline}used{Format.UnUnderline} to use {Color.Cyan}{Format.Bold}Shell.NET{Color.Default}!{Reset.All}");
            Console.WriteLine(
                $"{Background.Blue}{Format.Bold}I'm Mr. Meseeks Look at me!{Reset.All}");
            Console.WriteLine(string.Format(
                "{0}{4}C#{5} + {2}{4}*nix{5} = {3}{4}<3{5}",
                Color.Magenta,
                Color.White,
                Color.Green,
                Color.Red,
                Format.Bold,
                Reset.All
            ));
            Console.WriteLine();

            InlineForegroundColorCodes();
            InlineBackgroundColorCodes();
            InlineFormatCodes();
        }

        static void InlineForegroundColorCodes()
        {
            Console.WriteLine("Inline foreground color codes:");
            Console.WriteLine($"{Color.Default}- Default{Color.Default}");
            Console.WriteLine($"{Color.White}- White{Color.Default}");
            Console.WriteLine($"{Color.Black}- Black{Color.Default}");
            Console.WriteLine($"{Color.Blue}- Blue{Color.Default}");
            Console.WriteLine($"{Color.Cyan}- Cyan{Color.Default}");
            Console.WriteLine($"{Color.DrkGray}- DrkGray{Color.Default}");
            Console.WriteLine($"{Color.Green}- Green{Color.Default}");
            Console.WriteLine($"{Color.LtBlue}- LtBlue{Color.Default}");
            Console.WriteLine($"{Color.LtCyan}- LtCyan{Color.Default}");
            Console.WriteLine($"{Color.LtGray}- LtGray{Color.Default}");
            Console.WriteLine($"{Color.LtGreen}- LtGreen{Color.Default}");
            Console.WriteLine($"{Color.LtMagenta}- LtMagenta{Color.Default}");
            Console.WriteLine($"{Color.LtRed}- LtRed{Color.Default}");
            Console.WriteLine($"{Color.LtYellow}- LtYellow{Color.Default}");
            Console.WriteLine($"{Color.Magenta}- Magenta{Color.Default}");
            Console.WriteLine($"{Color.Red}- Red{Color.Default}");
            Console.WriteLine($"{Color.Yellow}- Yellow{Color.Default}");
            Console.WriteLine();
        }

        static void InlineBackgroundColorCodes()
        {
            Console.WriteLine("Inline background color codes:");
            Console.WriteLine($"{Background.Default}- Default{Background.Default}");
            Console.WriteLine($"{Background.White}- White{Background.Default}");
            Console.WriteLine($"{Background.Black}- Black{Background.Default}");
            Console.WriteLine($"{Background.Blue}- Blue{Background.Default}");
            Console.WriteLine($"{Background.Cyan}- Cyan{Background.Default}");
            Console.WriteLine($"{Background.DrkGray}- DrkGray{Background.Default}");
            Console.WriteLine($"{Background.Green}- Green{Background.Default}");
            Console.WriteLine($"{Background.LtBlue}- LtBlue{Background.Default}");
            Console.WriteLine($"{Background.LtCyan}- LtCyan{Background.Default}");
            Console.WriteLine($"{Background.LtGray}- LtGray{Background.Default}");
            Console.WriteLine($"{Background.LtGreen}- LtGreen{Background.Default}");
            Console.WriteLine($"{Background.LtMagenta}- LtMagenta{Background.Default}");
            Console.WriteLine($"{Background.LtRed}- LtRed{Background.Default}");
            Console.WriteLine($"{Background.LtYellow}- LtYellow{Background.Default}");
            Console.WriteLine($"{Background.Magenta}- Magenta{Background.Default}");
            Console.WriteLine($"{Background.Red}- Red{Background.Default}");
            Console.WriteLine($"{Background.Yellow}- Yellow{Background.Default}");
            Console.WriteLine();
        }

        static void InlineFormatCodes()
        {
            Console.WriteLine("Inline format codes:");
            Console.WriteLine($"{Format.Default}- Default{Format.Default}");
            Console.WriteLine($"{Format.Underline}- Underline{Format.UnUnderline}");
            Console.WriteLine($"{Format.Bold}- Bold{Format.UnBold}. This is stillBold?!{Format.Default}");
            Console.WriteLine($"{Format.Dim}- Dim{Format.UnDim}");
            Console.WriteLine($"{Format.Hidden}- Hidden{Format.UnHidden}");
            Console.WriteLine($"{Format.Invert}- Invert{Format.UnInvert}");
            Console.WriteLine();
        }

        static void SayHello()
        {
            Console.WriteLine($"{Format.Bold}"
                    + $"{Color.Red}A"
                    + $"{Color.Yellow}n"
                    + $"{Color.Green}s"
                    + $"{Color.Cyan}i"
                    + $"{Color.Blue}C"
                    + $"{Color.Magenta}o"
                    + $"{Color.Red}d"
                    + $"{Color.Yellow}e"
                    + $"{Color.Green}s"
                    + $"{Color.Default} {_version}"
                    + $"{Reset.All}"
            );
        }
    }
}
