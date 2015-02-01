# setup stuff
$paths = "build/4.5","build/4.5.1","test/results"
$ts = Get-Date -Format o | %{$_-replace ":","."}
$paths |?{ !( Test-Path $_ ) } |%{ New-Item $_ -Type Directory -Force }

msbuild .\Underscore.cs\Underscore.cs.csproj /p:TargetFrameworkVersion=v4.5.1 /p:Configuration=Release /p:OutputPath=../build/4.5.1
msbuild .\Underscore.Test\Underscore.Test.csproj /p:TargetFrameworkVersion=v4.5.1 /p:Configuration=Release /p:OutputPath=../build/4.5.1
mstest /testcontainer:"./build/4.5.1/Underscore.Test.dll" /resultsfile:"./test/results/result-4.5.1$ts.trx"

msbuild .\Underscore.cs\Underscore.cs.csproj /p:TargetFrameworkVersion=v4.5 /p:Configuration=Release /p:OutputPath=../build/4.5
msbuild .\Underscore.Test\Underscore.Test.csproj /p:TargetFrameworkVersion=v4.5 /p:Configuration=Release /p:OutputPath=../build/4.5
mstest /testcontainer:"./build/4.5/Underscore.Test.dll" /resultsfile:"./test/results/result-4.5$ts.trx"
