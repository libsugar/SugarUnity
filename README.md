# SugarUnity 

[![NPM](https://img.shields.io/npm/v/com.libsugar.sugar.unity)](https://www.npmjs.com/package/com.libsugar.sugar.unity)
[![Nuget](https://img.shields.io/nuget/v/LibSugar.Unity)](https://www.nuget.org/packages/LibSugar.Unity/)
![MIT](https://img.shields.io/github/license/libsugar/SugarUnity)

Like syntactic sugar, but is library

## Installation

- [Nuget](https://www.nuget.org/packages/LibSugar.Unity/)
  ```
  dotnet add package LibSugar.Unity --version <version>
  ```
  or
  ```
  <PackageReference Include="LibSugar.Unity" Version="<version>" />
  ```

- Unity Package by [npmjs](https://www.npmjs.com/package/com.libsugar.sugar.unity)

  Edit your `Packages/manifest.json` file like this

  ```json
  {
    "scopedRegistries": [
      {
        "name": "npm",
        "url": "https://registry.npmjs.org",
        "scopes": [
          "com.libsugar"
        ]
      }
    ],
    "dependencies": {
      "com.libsugar.sugar.unity": "<version>"
    }
  }
  ```
  or use gui in unity editor  
  config `Project Settings -> Package Manager -> Scoped Registeries`  
  then add package in package manager  
