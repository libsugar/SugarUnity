# SugarUnity 

[![NPM](https://img.shields.io/npm/v/com.libsugar.sugar.unity)](https://www.npmjs.com/package/com.libsugar.sugar.unity)
[![Nuget](https://img.shields.io/nuget/v/LibSugar.Unity)](https://www.nuget.org/packages/LibSugar.Unity/)
![MIT](https://img.shields.io/github/license/libsugar/SugarUnity)

类似语法糖，但是是库

## 安装

- [Nuget](https://www.nuget.org/packages/LibSugar.Unity/)
  ```
  dotnet add package LibSugar.Unity --version <version>
  ```
  或
  ```
  <PackageReference Include="LibSugar.Unity" Version="<version>" />
  ```

- Unity Package 由 [npmjs](https://www.npmjs.com/package/com.libsugar.sugar.unity)

  如下编辑你的 `Packages/manifest.json` 文件

  ```json
  {
    "scopedRegistries": [
      {
        "name": "NPM",
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
