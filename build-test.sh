#!/usr/bin/env bash 

# dotnet test Core.Shogi.Tests/Core.Shogi.Tests.csproj

mono ./packages/opencover/4.6.519/tools/OpenCover.Console.exe -target:"dotnet.exe" -targetargs:"test Core.Shogi.Tests/Core.Shogi.Tests.csproj" -output:coverage.xml -register:user -filter:"+[*]* -[xunit*]* -[*.Program]*" -oldStyle -log:Off