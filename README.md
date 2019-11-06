# Download .NET Software Development Kit (SDK)

Note: This is like create-react-app in that it builds the basic project file structure for you.

Go to https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/intro
Click Let's Get Started
Click Download .NET SDK
Click the downloaded file to open
Click Continue
Click Install
--ALT: npm install dotnet?
To confirm, open a NEW tab in Terminal and type dotnet
-If you receive a "command not found" error, the install was unsuccessful
In Terminal, enter the following commands
    dotnet new console -o myApp
    cd myApp
    dotnet run
    --The program should print "Hello World!" to the console.
    dotnet new -l
    dotnet new mvc
In VS Code, install the extension "C# for Visual Studio Code (powered by OmniSharp)"

For CLI tools: https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x 

Close and re-open VS Code
You should see a pop-up to build required assets to the project. Click Yes.

Built using instructions from : https://daveabrock.com/2018/03/05/full-stack-development-in-vs-code-with-asp-net-core/

# Package Manager

dotnet add package is similar to npm install. The official package manager for .Net is NuGet

# Install NPGSQL

Note: This is like pg and JDBC in that it allows C# to use PostgreSQL

Go to https://www.nuget.org/packages/Npgsql/
In Terminal enter the command dotnet add package Npgsql --version 4.1.1

For more information: https://www.npgsql.org/doc/index.html

Go to appsettings.Development.json (not appsettings.json) and add the following:
  "ConnectionStrings": { "DefaultConnection":  "Server=127.0.0.1;Database=database-name;Uid=root;Pwd=root;" }
Update the database-name to match the applicable database


# Set up Database

Create the database as normal in Postico


## Helpful Links

https://medium.com/@alialhaddad/build-a-basic-fullstack-app-using-c-net-core-mysql-and-webpack-react-1-3-73cfb64daeb6

## Terminology

Solution - the project
  Namespace/Library - the file structure
    Class/Model - the feature component

/// <summary>
/// Apparently, this is how you add an XML comment to C# projects...
/// </summary>
/// <param name="sampleVariable">
/// And this is how you document about the parameter of the object
/// </param>