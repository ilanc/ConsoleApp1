# ConsoleApp1

Attempt to get EF6 working in "Console Application (.NET Core)".
Managed to get project.json setup, and code to build, but `Enable-Migrations` produces errors:
```
Exception calling "SetData" with "2" argument(s): "Type 'Microsoft.VisualStudio.ProjectSystem.VS.Implementation.Package.Automation.OAProject' in assembly 'Microsoft.VisualStudio.ProjectSystem.VS.Implementation, Version=14.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' is not marked as serializable." At C:\Users\ilan_\.nuget\packages\EntityFramework\6.1.3\tools\EntityFramework.psm1:718 char:5
```
