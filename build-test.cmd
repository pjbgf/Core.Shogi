copy Core.Shogi.Console\bin\Debug\netcoreapp2.0\*.pdb Core.Shogi.Tests\bin\Debug\netcoreapp2.0\

@call %USERPROFILE%\.nuget\packages\opencover\4.6.519\tools\OpenCover.Console.exe -target:"dotnet.exe" -targetargs:"test Core.Shogi.Tests\Core.Shogi.Tests.csproj" -output:coverage.xml -register:user -filter:"+[*]* -[*]AutoGeneratedProgram -[*]Should" -oldStyle -returntargetcode -log:All