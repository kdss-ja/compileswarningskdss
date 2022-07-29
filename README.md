# Komatsu Machine Digital Twin KDDS API

This library contains the KDDS data transfer objects for the Komatsu Machine Digital Twin API.

## Local testing for Nuget

You can build and inspect a Nuget package locally before uploading to a Nuget feed or before running the cloud pipeline that will publish to the Nuget feed.

### Build and Inspect Nuget package
From the command line run:

```
dotnet pack Komatsu.Machine.DigitalTwin.Data.csproj -p:PackageVersion=1.0.0 --configuration Release
```
#### Inspect package from Visual Studio
Manually add a reference in the Visual Studio project by temporarily adding the a Nuget source pointing to your local C: drive and folder where you built the .nupkg file.

> NOTE: As at May/2022 and with VS2022 this method doesn't display the Release Notes information or the README file.

#### NuGet Package Explorer
Install and use the [NuGet Package Explorer](https://github.com/NuGetPackageExplorer/NuGetPackageExplorer) from the Microsoft Store.

This method allows you to see the Release Notes text before you push to a Nuget feed.

> NOTE: To use the NuGet Package Explorer you must authenticate with your @global.komatsu user name and use a [Personal Access Token](https://docs.microsoft.com/en-us/azure/devops/organizations/accounts/use-personal-access-tokens-to-authenticate?view=azure-devops&tabs=Windows) as your password.

## Nuget README

You can [add README file](https://devblogs.microsoft.com/nuget/add-a-readme-to-your-nuget-package/) to a Nuget package. But I have not been able to get Visual Studio 2022 to display a link to the readme.