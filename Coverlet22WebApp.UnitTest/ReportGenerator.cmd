dotnet tool install dotnet-reportgenerator-globaltool --tool-path tools
.\tools\reportgenerator.exe -reports:.\TestResults\coverage.cobertura.xml -targetdir:.\TestResults\
