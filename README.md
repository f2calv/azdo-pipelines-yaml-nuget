# Publish Multi-Targeted NuGet Package w/Azure DevOps YAML Pipeline

[![Build Status](https://dev.azure.com/f2calv/github/_apis/build/status/f2calv.azdo-pipelines-yaml-nuget?branchName=master)](https://dev.azure.com/f2calv/github/_build/latest?definitionId=4&branchName=master)
[![NuGet Version](https://img.shields.io/nuget/v/MyPkgLib.svg?style=flat)](https://www.nuget.org/packages/MyPkgLib/)
[![NuGet](https://img.shields.io/nuget/dt/MyPkgLib.svg)](https://www.nuget.org/packages/MyPkgLib)

This repository is comprised of three .NET projects, these projects are to help demonstrate the YAML pipeline for publishing the NuGet package;
- 1 x Class Library (i.e. which is packaged and deployed as a public NuGet package)
- 1 x Test Project
- 1 x Console Application (used to test/debug the final package)

The class library multi-targets the following frameworks;
- .NET Framework 2.7.2
- .NET Standard 2.0
- .NET 5.0.

The library includes references to both Entity Framework 6 and Entity Framework Core along with some compiler directives as an example of how to create a multi-targeted package.

The CI/CD YAML pipeline is located in the .azure-pipelines directory of the repository.

The pipeline consists of multiple-steps which when combined;
1) installs key dependencies
2) handles the semantic versioning of the package
3) builds all the projects
4) runs all tests and publishes code coverage report
5) packs the class library and depending on source branch pushes package to either;
  - [NuGet staging feed](https://int.nugettest.org/packages/MyPkgLib/)
  - [NuGet production feed](https://www.nuget.org/packages/MyPkgLib)

The branching strategy of this repository is GitHubFlow and the pipeline uses GitVersion to control/handle the semantic versioning of each public release. When pushing a new public release (from master) the YAML build pipeline itself is tagged with the current SemVersion and a Tag is added at that commit to provide additional traceability.

Resources;
- https://docs.microsoft.com/azure/devops/pipelines/yaml-schema
- https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/nuget
- https://gitversion.net
- http://loudandabrasive.com/effective-nuget-versioning-in-azure-devops
- https://cloudblogs.microsoft.com/industry-blog/en-gb/technetuk/2019/06/18/perfecting-continuous-delivery-of-nuget-packages-for-azure-artifacts/

Additional guidance on including .NET PDB/Symbols and SourceLink;
- https://blog.nuget.org/20181116/Improved-debugging-experience-with-the-NuGet-org-symbol-server-and-snupkg.html
- https://github.com/dotnet/sourcelink#using-source-link-in-net-projects
- https://github.com/NuGet/Home/wiki/NuGet-Package-Debugging-&-Symbols-Improvements
- https://docs.microsoft.com/en-us/nuget/create-packages/symbol-packages-snupkg

Unit test & code coverage solution;
-https://www.meziantou.net/computing-code-coverage-for-a-dotnet-core-project-with-azure-devops-and-coverlet.htm
