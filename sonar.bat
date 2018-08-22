@echo off
set /p token=<sonar.txt
:: https://docs.sonarqube.org/display/SONAR/Analysis+Parameters
dotnet sonarscanner begin /k:"dein:tddroman" /n:"Number" /v:"1.0.0" /o:"dein" /d:sonar.host.url="https://sonarcloud.io" /d:sonar.login="%token%" /d:sonar.language="cs" /d:sonar.exclusions="**/bin/**/*,**/obj/**/*" /d:sonar.coverage.exclusions="Number.Tests/**,**/*Tests.cs" /d:sonar.cs.opencover.reportsPaths="%cd%\lcov.opencover.xml"
dotnet restore
dotnet build
dotnet test Number.Tests/Number.Tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover,lcov\" /p:CoverletOutput=../lcov
dotnet sonarscanner end /d:sonar.login="%token%"
