# HtmlAgilityPack for .NET Core  [![License][License]](LICENSE-2.0.txt)

This project is based on [HtmlAgilityPack 2.0.Experimental branch](https://htmlagilitypack.codeplex.com/SourceControl/latest#Branches/2.0.Experimental/).

[License]: https://img.shields.io/badge/license-Apache_2.0-blue.svg?style=flat-square

## Compatibility Status

+ **.NET 4.5.1** Fully
+ **.NET Standard 1.3**
 - [ ] `HtmlCmdLine`. 'Cause `Environment.GetCommandLineArgs()` is not included.
 - [x] `HtmlNodeNavigator` ([partially](src/DevZH.HtmlAgilityPack/HtmlAgilityPack.cs#L728-734))
 - [ ] `HtmlWeb`. 'Cause `System.Xml.Xsl`, `System.Security.Permissions` ... is not included.
+ **.NET Standard 1.5**
 - [x] `HtmlCmdLine`
 - [x] `HtmlNodeNavigator` ([partially](src/DevZH.HtmlAgilityPack/HtmlAgilityPack.cs#L728-734))
 - [ ] `HtmlWeb`. 'Cause `System.Xml.Xsl`, `System.Security.Permissions` ... is not included.

