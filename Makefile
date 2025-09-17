MSBUILD="C:\Program Files\Microsoft Visual Studio\2022\Professional\MSBuild\Current\Bin\MSBuild.exe"
WINDOWS_PROJECT=src/WebApi.Windows/AllInOne.WebApi.Windows.csproj
LINUX_PROJECT=src/WebApi.Linux/AllInOne.WebApi.Linux.csproj
CONFIG=Release

windows:
	$(MSBUILD) $(WINDOWS_PROJECT) /p:Configuration=$(CONFIG)

linux:
	dotnet build $(LINUX_PROJECT) --configuration $(CONFIG)

test:
	dotnet test tests/Domain.UnitTests/AllInOne.Domain.UnitTests.csproj --configuration $(CONFIG)
	dotnet test tests/Application.FunctionalTests/AllInOne.Application.FunctionalTests.csproj --configuration $(CONFIG)
