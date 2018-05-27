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
                    + $"{Color.White} {_version}"
                    + $"{Reset.All}"
            );
        }
    }
}
