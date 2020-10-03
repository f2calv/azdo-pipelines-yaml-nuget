
dotnet build -c release -o c:\temp\nuget --nologo -p:Version=1.2.3.4


dotnet build -c release --nologo -p:Version=1.2.3.4
dotnet pack -c release --nologo --include-symbols -o c:\temp\nuget --no-build





dotnet pack -c release --nologo --include-symbols -o c:\temp\nuget --version-suffix "ci-1234"

::PackageVersion overrides version-suffix
dotnet pack -c release --nologo --include-symbols -o c:\temp\nuget -p:PackageVersion=2.1.0 --version-suffix "ci-1234"


dotnet pack -c release --nologo --include-symbols -o c:\temp\nuget -p:VersionPrefix=2.1.0 -p:VersionSuffix=ci-1234



dotnet build --nologo -c release -p:VersionPrefix=2.1.0 -p:VersionSuffix=ci-1234
dotnet test --nologo -c release --no-build
dotnet pack --nologo -c release --no-build --include-symbols -o c:\temp\nuget -p:VersionPrefix=2.1.0 -p:VersionSuffix=ci-1234



dotnet restore
dotnet build --nologo -c release -p:Version=2.1.0-ci-1234
dotnet test --nologo -c release --no-build -p:CollectCoverage=true -p:CoverletOutputFormat=cobertura
dotnet pack --nologo -c release --no-build --include-symbols -o c:\temp\nuget -p:Version=2.1.0-ci-1234



Write-Host "##vso[build.updatebuildnumber]1.0.0.$($env:Build_BuildId)"




dotnet build SmartCodeGenerator.sln -p:VersionPrefix=1.0.3 -p:VersionSuffix=beta -p:SourceRevisionId=7aab58c9171921460aa495a335e1474f4861649c -p:RepositoryUrl=https://github.com/cezarypiatek/SmartCodeGenerator -p:RepositoryType=git -p:RepositoryBranch=develop


https://github.com/GitTools/GitVersion/releases/download/5.3.7/gitversion-ubuntu.16.04-x64-5.3.7.tar.gz


wget https://github.com/GitTools/GitVersion/releases/download/5.3.7/gitversion-ubuntu.18.04-x64-5.3.7.tar.gz
tar -xvf gitversion-ubuntu.18.04-x64-5.3.7.tar.gz
sudo mv gitversion /usr/local/bin
