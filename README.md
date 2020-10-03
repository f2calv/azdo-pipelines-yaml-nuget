# Azure DevOps (AzDO)
### Public NuGet Package CI/CD using Azure DevOps YAML Pipeline

[![Build Status](https://dev.azure.com/f2calv/github/_apis/build/status/f2calv.azdo-pipelines-yaml-nuget?branchName=master)](https://dev.azure.com/f2calv/github/_build/latest?definitionId=4&branchName=master)
[![NuGet Version](https://img.shields.io/nuget/v/MyPkgLib.svg?style=flat)](https://www.nuget.org/packages/MyPkgLib/)
[![NuGet](https://img.shields.io/nuget/dt/MyPkgLib.svg)](https://www.nuget.org/packages/MyPkgLib)

This repository is comprised of three .NET projects - each project is *very* basic;
- 1 x Class Library (i.e. which is packaged and deployed as a public NuGet package)
- 1 x Unit Test Project
- 1 x Console Application (used to test/debug the package)

The class library is an example of multi-targeting and targets;
- .NET Framework 2.7.2
- .NET Standard 2.0
- .NET 5.0.

The library includes references to both Entity Framework 6 and Entity Framework Core along with some compiler directives as an example of how to create a multi-targeted package.

The CI/CD YAML pipeline is contained within the repository in the .azure-pipelines directory.

The pipeline consists of a single job which;
1) builds all the projects
2) runs all tests and publishes code coverage report
3) packs the class library and pushes it either to [NuGet staging server](https://int.nugettest.org/packages/MyPkgLib/) or to [NuGet server](https://www.nuget.org/packages/MyPkgLib).

The branching strategy of this repository is GitHubFlow and the pipeline uses GitVersion to control/handle the semantic versioning of each public release. When pushing a new public release (from master) the YAML build pipeline itself is tagged with the current SemVersion and a Tag is added at that commit to provide additional traceability.

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
