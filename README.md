# Amido Testing Core Framework

This is an example framework using Selenium Webdriver and written in C#.

## Getting start

Please ensure you have the [.NET Core 3.1 SDK installed.](https://dotnet.microsoft.com/download) 

_MacOS/Linux: For [Homebrew](https://formulae.brew.sh/) users, `brew cask install dotnet-sdk` will install the long term support version._

Please install [Visual Studio Code](https://code.visualstudio.com/) and ensure the extension [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) (powered by OmniSharp) is installed.

## Build the Solution

In root (*.sln) directory, build the solution using: ) the solution:

```bash
dotnet build
```

_Note: you don't need to run `dotnet restore` because it's run implicitly by all commands that require a restore to occur, such as dotnet new, dotnet build and dotnet run._
