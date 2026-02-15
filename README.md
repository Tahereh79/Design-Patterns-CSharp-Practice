# Design Patterns Using C# and .NET Core — Practice Repository

> **This is my personal practice repository** based on the Packt video course
> [*Design Patterns Using C# and .NET Core*](https://www.packtpub.com/application-development/design-patterns-using-c-and-net-core-video) by Packt Publishing.
>
> Original source code: [PacktPublishing/Design-Patterns-using-C-and-.NET-Core](https://github.com/PacktPublishing/Design-Patterns-using-C-and-.NET-Core)

## What I Changed

- Updated target framework from `netcoreapp2.0` to `net7.0` so examples compile with modern .NET SDKs
- Replaced the defunct `restcountries.eu` API with hardcoded sample data (Section 1.2 — SRP)
- Wired up a working `Program.cs` for the Open/Closed Principle example (Section 1.3)
- Various small fixes to make all projects runnable on macOS (Apple Silicon)

## Course Topics

| Section | Topic |
|---------|-------|
| 1.2 | Single Responsibility Principle (SRP) |
| 1.3 | Open/Closed Principle (OCP) |
| 1.4 | Liskov Substitution Principle (LSP) |
| 1.5 | Interface Segregation Principle (ISP) |
| 1.6 | Dependency Inversion Principle (DIP) |
| 2.x | Creational Patterns (Singleton, Factory, etc.) |
| 3.x | Structural Patterns |
| 4.x | Behavioral Patterns |
| 5.x | Advanced Patterns |

## How to Run

```bash
cd "Section 1/1.2/SRPExample"
dotnet run
```

Requires [.NET 7 SDK](https://dotnet.microsoft.com/download) or later.

## Credits

All original code and course content by [Packt Publishing](https://www.packtpub.com/).
Modifications and practice notes by [Tahereh79](https://github.com/Tahereh79).
