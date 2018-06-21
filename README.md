# Kata: TDD Arabic to Roman Numbers with C# #

## Project ##

Create a solution with a class and test project

```shell
dotnet new classlib -n Number
cd Number
dotnet restore
cd ..

dotnet new xunit -n Number.Test
cd Number.Test
dotnet add reference ../Number/Number.csproj
dotnet add package Moq
dotnet add package coverlet.msbuild
dotnet restore
cd ..

dotnet new sln -n Number
dotnet sln Number.sln add ./Number/Number.csproj
dotnet sln Number.sln add ./Number.Test/Number.Test.csproj
```

## Requirements ##

* [NET Core SDK](https://www.microsoft.com/net/download)
* [Visual Studio Code](https://code.visualstudio.com/) with some plugins:
  * [.Net Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
  * [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
  * [Coverage Gutter](https://marketplace.visualstudio.com/items?itemName=ryanluker.vscode-coverage-gutters)

## Roman Numbers ##

| Symbol | I | V | X  | C  | D   | M    |
| ------ |:-:|:-:|:--:|:--:|:---:|:----:|
| Value  | 1 | 5 | 10 | 50 | 500 | 1000 |

## Place Value ##

| Expression        | Place            | Europe    |
| ----------------: | :--------------- | :-------- |
|                 1 | ones             |           |
|                10 | tens             |           |
|               100 | tens             |           |
|             1,000 | thousands        |           |
|            10,000 | ten thousands    |           |
|         1,000,000 | ten thousands    |           |
|         1,000,000 | millions         |           |
|        10,000,000 | ten millions     |           |
|       100,000,000 | hundred millions |           |
|     1,000,000,000 | billions         | milliards |
| 1,000,000,000,000 | trillions        | billions  |