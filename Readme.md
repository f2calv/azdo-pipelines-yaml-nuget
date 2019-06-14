# Azure DevOps (AzDO)
### Public NuGet Package CI/CD using YAML Azure DevOps Pipeline

[![Build Status](https://dev.azure.com/f2calv/github/_apis/build/status/f2calv.azdo-pipelines-yaml-nuget?branchName=master)](https://dev.azure.com/f2calv/github/_build/latest?definitionId=4&branchName=master)

[![Build Coverage](https://img.shields.io/azure-devops/coverage/f2calv/github/4.svg)](https://img.shields.io/azure-devops/coverage/f2calv/github/4.svg)

This repository is comprised of three .NET Core 2.2 projects - each project is *very* basic;
- 1 x Class Library (i.e. which is packaged and deployed as a public NuGet package)
- 1 x Unit Test Project
- 1 x Console Application (uses to test debugging of pkg)

The class library is an example of multi-targetting and targets .NET Standard 2.0 and .NET Framework 2.7.2.
The library includes references to both Entity Framework 6 and Entity Framework Core along with some compiler directives in Class1.cs as an example of how to create a multi-targetted package.

All YAML is contained within the repository in the AzurePipelines directory.

The multi-stage pipeline has 3 stages, Build, Test & Deploy(Push) which;
1) build the class library projects
2) run all tests and publish code coverage report
3) pack the class library and push it either [NuGet staging server](https://int.nugettest.org/packages/MyPkgLib/) or [NuGet server](https://www.nuget.org/packages/MyPkgLib).

Sources;
- https://docs.microsoft.com/azure/devops/pipelines/yaml-schema
- https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/nuget
- https://blog.magnusmontin.net/2018/12/11/using-azure-pipelines-to-publish-your-github-project-to-nuget/

Additional guidance on including PDB/Symbols and SourceLink;
- https://blog.nuget.org/20181116/Improved-debugging-experience-with-the-NuGet-org-symbol-server-and-snupkg.html
- https://github.com/dotnet/sourcelink#using-source-link-in-net-projects
- https://github.com/NuGet/Home/wiki/NuGet-Package-Debugging-&-Symbols-Improvements
- https://docs.microsoft.com/en-us/nuget/create-packages/symbol-packages-snupkg

Unit test & code coverage solution;
-https://www.meziantou.net/computing-code-coverage-for-a-dotnet-core-project-with-azure-devops-and-coverlet.htm

Issues;
- I am as yet unable to pass the build project from stage #1 to stage #2 for the tests and then to stage #3 for the publish... so currently the build happens three times over. :(