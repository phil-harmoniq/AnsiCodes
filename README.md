# C#/.NET Ansi Color Codes [![NuGet](https://img.shields.io/nuget/v/AnsiCodes.svg)](https://preview.nuget.org/packages/AnsiCodes) [![Build Status](https://travis-ci.org/phil-harmoniq/AnsiCodes.svg?branch=master)](https://travis-ci.org/phil-harmoniq/AnsiCodes)

[License]: https://img.shields.io/badge/License-MIT-blue.svg

### (This library is the spritual successor to [ConsoleColors](https://github.com/phil-harmoniq/ConsoleColors))

The new experimental build supports *modern* Windows (8+)

<img src="http://i.imgur.com/fzoBQsG.png" width="287px" height="287px">

## Usage

Use string formatting/interpolation while calling `Console.Write()` or `Console.WriteLine()` to print with colors! Color properties are stored in the `Color` class , formatting properties are in the `Format` class, and background color properties are in the `Background` class. To reset all color/formatting changes, use the `Reset.All` property or call the `Reset.ResetAll()` class method.

## Installation

Use the .NET CLI to get [get this library off of Nuget!](https://www.nuget.org/packages/AnsiCodes)! Prereleases need an explicit version.

```bash
dotnet add package AnsiCodes
```

## Examples

```C#
Console.WriteLine($"This library {Format.Underline}used{Format.UnUnderline} to use {Color.Cyan}{Format.Bold}Shell.NET{Color.Default}!{Reset.All}");
Console.WriteLine($"{Background.Blue}{Format.Bold}I'm Mr. Meseeks Look at me!{Reset.All}");
Console.WriteLine(string.Format(
    "{0}{4}C#{5} + {2}{4}*nix{5} = {3}{4}<3{5}",
    Color.Magenta,
    Color.White,
    Color.Green,
    Color.Red,
    Format.Bold,
    Reset.All
));
```

Note: Remember to use Reset.All() to return back to default colors.

## Color Properties

* Color.Default
* Color.Black
* Color.White
* Color.Red
* Color.Green
* Color.Yellow
* Color.Blue
* Color.Magenta
* Color.Cyan
* Color.LtGray
* Color.DrkGray
* Color.LtRed
* Color.LtGreen
* Color.LtYellow
* Color.LtBlue
* Color.LtMagenta
* Color.LtCyan

Note: All color properties have a corresponding class method. Examples:

* Color.SetBlue()
* Color.Reset()

## Formatting Properties

* Format.Bold
* Format.Dim
* Format.Underline
* Format.Invert
* Format.Hidden
* Format.UnBold
* Format.UnDim
* Format.UnUnderline
* Format.UnInvert
* Format.UnHidden

Note: All formatting properties have corresponding activation *and* deactivation class methods. Examples:

* Format.SetDim()
* Format.ResetDim()
* Format.Underline()
* Format.Reset()

## Reset Utility

* Reset.All
* Reset.ResetAll()

## Background Color Properties

Same colors as the Color class; contained in the Background class. Examples:

* Background.LtGray
* Background.White
* Background.SetBlue()
* Background.Reset()
