# xUnit V3 Code Coverage Sample

A sample repository for .NET 10 or later demonstrating code coverage with xUnit v3 and the Microsoft Testing Platform v2.

## Overview

This is a sample repository containing test projects built with **xUnit v3**. The test projects are configured to use the new **Microsoft Testing Platform (MTP v2)** for enhanced testing capabilities.

## Requirements

- .NET 10 or later
- Visual Studio 2026
- Visual Studio 2026 Professional for Code Coverage

## Getting Started

### Cloning and Building the Repository

1. Clone the repository to your local machine.
1. Open the solution file (`.slnx`) in Visual Studio 2026.
1. Restore the NuGet packages.
1. Build the solution.

### Running Tests and Viewing Code Coverage

1. Run the tests using the Test Explorer in Visual Studio.
1. View the code coverage results in the Code Coverage window.

### Reviewing the Sample Code
1. Explore the sample test projects to understand how xUnit v3 and MTP v2 are integrated.
1. See the xUnit v3 mtp2 nuget package reference in the test project files because this makes use of the Microsoft Testing Platform v2 explicitly. See xUnit v3 documentation for more details.
1. See the global.json file to see Microsoft Testing Platform is used for dotnet test. See xUnit v3 documentation for more details.
1. See the runsettings file to see code coverage configuration.

## Code Coverage

The repository is configured to calculate code coverage using the **Microsoft code coverage extension**. For detailed documentation on this extension, see:
- [Microsoft Testing Platform Extensions - Code Coverage](https://learn.microsoft.com/en-us/dotnet/core/testing/microsoft-testing-platform-extensions-code-coverage#microsoft-code-coverage)

### Visual Studio Integration

Code coverage results can be visualized be default with Visual Studio 2026 Professional or Enterprise editions. Previously, the Fine Code Coverage (FCC) extension was used for this purpose. However, with the latest versions of Visual Studio, code coverage visualization is built-in. This project is updated to reflect this change.

## Documentation

This sample repository is based on the official xUnit v3 documentation:
- [xUnit v3 - Code Coverage with MTP](https://xunit.net/docs/getting-started/v3/code-coverage-with-mtp)

