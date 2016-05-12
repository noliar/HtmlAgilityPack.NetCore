# HtmlAgilityPack for .NET Core  [![License][License]](LICENSE-2.0.txt)

This project is a port of [HtmlAgilityPack 1.4.0 branch](https://htmlagilitypack.codeplex.com/SourceControl/latest#Branches/1.4.0/).

[License]: https://img.shields.io/badge/license-Apache_2.0-blue.svg?style=flat-square

## Compatibility Status

+ **.NET 4.5.1** Fully
+ **.NET Standard 1.3**
 - [ ] `HtmlCmdLine`. 'Cause `Environment.GetCommandLineArgs()` is not included.
 - [x] `HtmlNodeNavigator` ([partially](src/DevZH.HtmlAgilityPack/HtmlNodeNavigator.cs#L723-729))
 - [ ] `HtmlWeb`. 'Cause `System.Xml.Xsl` is not included.
+ **.NET Standard 1.5**
 - [x] `HtmlCmdLine`
 - [x] `HtmlNodeNavigator` ([partially](src/DevZH.HtmlAgilityPack/HtmlNodeNavigator.cs#L723-729))
 - [ ] `HtmlWeb`. 'Cause `System.Xml.Xsl` is not included.

