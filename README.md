# This project is dead.
You can read the source code of HAP on [home repo](https://github.com/zzzprojects/html-agility-pack).

# HtmlAgilityPack for .NET Core  [![License][License]](LICENSE-2.0.txt)

This project is a port of [HtmlAgilityPack trunk](https://htmlagilitypack.codeplex.com/SourceControl/latest#Trunk/).

[License]: https://img.shields.io/badge/license-Apache_2.0-blue.svg?style=flat-square

## Compatibility Status

+ **.NET 2.0** Fully
+ **.NET 4.0** Fully
+ **.NET 4.5.1** Fully but HtmlWeb is different than the origin.
+ **.NET Standard 1.3**
 - [ ] `HtmlCmdLine`. 'Cause `Environment.GetCommandLineArgs()` is not included.
 - [x] `HtmlNodeNavigator` ([partially](src/DevZH.HtmlAgilityPack/HtmlNodeNavigator.cs#L723-729))
 - [x] `HtmlWeb` (partially). 'Cause `System.Xml.Xsl` ... is not included.
+ **.NET Standard 1.5**
 - [x] `HtmlCmdLine`
 - [x] `HtmlNodeNavigator` ([partially](src/DevZH.HtmlAgilityPack/HtmlNodeNavigator.cs#L723-729))
 - [x] `HtmlWeb` (partially). 'Cause `System.Xml.Xsl` ... is not included.

