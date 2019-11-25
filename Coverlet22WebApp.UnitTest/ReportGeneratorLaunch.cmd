dotnet tool install dotnet-reportgenerator-globaltool --tool-path tools
.\tools\reportgenerator.exe -reports:.\TestResults\coverage.info -targetdir:.\TestResults\
start chrome .\TestResults\index.htm