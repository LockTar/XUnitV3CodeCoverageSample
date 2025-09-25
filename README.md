# xUnit V3 Code Coverage Sample

A sample repository for .NET 8 or later demonstrating code coverage with xUnit v3 and the Microsoft Testing Platform.

## Overview

This is a sample repository containing test projects built with **xUnit v3**. The test projects are configured to use the new **Microsoft Testing Platform (MTP)** for enhanced testing capabilities.

The best setup for a test project is to look at `Tests2` project file. See known issues at the bottom of this file for more details why.

## Code Coverage

The repository is configured to calculate code coverage using the **Microsoft code coverage extension**. For detailed documentation on this extension, see:
- [Microsoft Testing Platform Extensions - Code Coverage](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-extensions-code-coverage#microsoft-code-coverage)

### Visual Studio Integration

Code coverage results can be visualized using the **Fine Code Coverage (FCC)** Visual Studio extension.

### Configuration Notes

⚠️ **Important**: The `.runsettings` file is currently disabled due to compatibility issues with the Fine Code Coverage (FCC) extension.
The extension is now creating its own `.runsettings` file automatically when running the tests in Visual Studio with the Test Explorer.

## Documentation

This sample repository is based on the official xUnit v3 documentation:
- [xUnit v3 - Code Coverage with MTP](https://xunit.net/docs/getting-started/v3/code-coverage-with-mtp)

## Requirements

- .NET 8 or later
- Visual Studio with Fine Code Coverage extension (optional, for coverage visualization). The extension is using it's default settings. This means that the setting `RunMsCodeCoverage` is set to `true`.

## Known Issues

- The Fine Code Coverage (FCC) extension is not showing the code coverage results of all the 3 test projects. It is showing only the results of the `Project1` and `Tests` projects. This is because of the configuration in the test project files. Test project `Project1` and `Tests` have the following package references:

  ```xml
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.14.1" />
    <PackageReference Include="Microsoft.Testing.Extensions.CodeCoverage" Version="17.14.2" />
    <PackageReference Include="xunit.v3" Version="3.0.1" />
    <PackageReference Include="xunit.runner.visualstudio" Version="3.1.4" />
  ```
  
  The `Tests2` project is missing the `Microsoft.NET.Test.Sdk` and `xunit.runner.visualstudio` package references because they are not needed with MTP.

  After adding these package references to the `Tests2` project, the FCC extension is showing the code coverage results of all 3 test projects.
