#!/bin/bash
token="$(cat sonar.txt)"
dir="$(pwd)"
# https://docs.sonarqube.org/display/SONAR/Analysis+Parameters
dotnet ~/Applications/Sonar/Scanner/msbuild/SonarScanner.MSBuild.dll begin /k:"dein:tddroman" /n:"Number" /v:"1.0.0" /o:"dein" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="${token}" /d:sonar.language="cs" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*" /d:sonar.cs.opencover.reportsPaths="${dir}/lcov.opencover.xml"
dotnet restore
dotnet build
dotnet test Number.Tests/Number.Tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,lcov\" /p:CoverletOutput=../lcov
dotnet ~/Applications/Sonar/Scanner/msbuild/SonarScanner.MSBuild.dll end /d:sonar.login="${token}"