# Kata: TDD Arabic to Roman Numbers with C# #

[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=dein%3Atddroman&metric=alert_status)](https://sonarcloud.io/dashboard?id=dein%3Atddroman)
[![SonarCloud](https://sonarcloud.io/api/project_badges/measure?project=dein%3Atddroman&metric=coverage)](https://sonarcloud.io/dashboard?id=dein%3Atddroman)

## Project ##

Create a solution with a class and test project

```shell
dotnet new classlib -n Number
cd Number
dotnet restore
cd ..

dotnet new xunit -n Number.Tests
cd Number.Tests
dotnet add reference ../Number/Number.csproj
dotnet add package Moq
dotnet add package coverlet.msbuild
dotnet restore
cd ..

dotnet new sln -n Number
dotnet sln Number.sln add ./Number/Number.csproj
dotnet sln Number.sln add ./Number.Tests/Number.Tests.csproj
```

## Requirements ##

* [NET Core SDK](https://www.microsoft.com/net/download)
* [Visual Studio Code](https://code.visualstudio.com/) with some plugins:
  * [.Net Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
  * [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
  * [Coverage Gutter](https://marketplace.visualstudio.com/items?itemName=ryanluker.vscode-coverage-gutters)

## Roman Numbers ##

### Basic Symbols ###

| 1 | 5 | 10 | 50 | 100 | 500 | 1000 |
| - | - | -- | -- | --- | --- | ---- |
| I | V | X  | L  | C   | D   | M    |

### Basic Combinations ###

| 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
| - | -- | --- | -- | - | -- | --- | ---- | -- |
| I | II | III | IV | V | VI | VII | VIII | IX |

| 10 | 20 | 30 | 40 | 50 | 60 | 70 | 80 | 90 |
| - | -- | --- | -- | - | -- | --- | ---- | -- |
| X | XX | XXX | XL | L | LX | LXX | LXXX | XC |

| 100 | 200 | 300 | 400 | 500 | 600 | 700 | 800 | 900 |
| - | -- | --- | -- | - | -- | --- | ---- | -- |
| C | CC | CCC | CD | D | DC | DCC | DCCC | CM |

### How Convert ###

To convert Roman Numerals we need to split it up into place values (ones, tens, hundreds, etc.). Example 999

| Place Value | Number | Roman Numeral |
| :---------- | -----: | :------------ |
| Hundreds    |    900 | CM            |
| Tens        |     90 | XC            |
| Ones        |      9 | IX            |

You then combine them all together (starting from the top) to get CMXCIX.

## Place Value ##

| Expression        | Place              | Europe    |
| ----------------: | :----------------- | :-------- |
|                 1 | ones               |           |
|                10 | tens               |           |
|               100 | hundreds           |           |
|             1,000 | thousands          |           |
|            10,000 | ten thousands      |           |
|         1,000,000 | hundreds thousands |           |
|         1,000,000 | millions           |           |
|        10,000,000 | ten millions       |           |
|       100,000,000 | hundred millions   |           |
|     1,000,000,000 | billions           | milliards |
| 1,000,000,000,000 | trillions          | billions  |