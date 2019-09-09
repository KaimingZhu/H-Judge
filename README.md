# H::Judge

## Description
This is the official repository for [H::Judge](https://hjudge.com).

## Status
| master | develop |
| ------ | ------- |
| [![Build Status](https://dev.azure.com/hez2010/H-Judge/_apis/build/status/hez2010.H-Judge?branchName=master)](https://dev.azure.com/hez2010/H-Judge/_build/latest?definitionId=10&branchName=master) | [![Build Status](https://dev.azure.com/hez2010/H-Judge/_apis/build/status/hez2010.H-Judge?branchName=develop)](https://dev.azure.com/hez2010/H-Judge/_build/latest?definitionId=10&branchName=develop) |

## Prerequisites
- [.NET Core 3.0](https://www.microsoft.com/net/)
- [SeaweedFs 1.43](https://github.com/chrislusf/seaweedfs/)
- [PostgreSQL 11](https://www.postgresql.org/)
- [Yarn 1.17.3](https://yarnpkg.com/)
- [Rust 1.37.0](https://www.rust-lang.org/)

## Projects
- hjudge.WebHost:
    > The web host for H::Judge using .NET Core. 
- hjudge.JudgeHost:
    > The judge host for H::Judge using .NET Core. 
- hjudge.FileHost:
    > The file host for H::Judge using .NET Core. 
- hjudge.Shared:
    > The shared components used by other projects. 
- hjudge.Core:
    > The core module of H::Judge containing all the necessary configurations and methods for judging a submission. 
- hjudge.Exec.Windows:
    > A module on Microsoft Windows operating system used to run a program and measure time, memory consuming and execution status of the process being created. 
- hjudge.Exec.Linux:
    > A module on Linux operating system used to run a program and measure time, memory consuming and execution status of the process being created. 

## Setup Development Environment
1. Set environment variable 'DOTNET_ENVIRONMENT' to 'Development'

## Development Run
1. Setting your connection string to a PostgreSQL Database in ./hjudge.WebHost/src/appsettings.json (or appsettings.Development.json for development environment)
2. Migrate and update database
    ```
    cd hjudge.WebHost/src
    dotnet ef database update
    ```
3. Run hjudge.JudgeHost (can be skipped if you don't use solution submission in Web)
    ```
    cd hjudge.JudgeHost/src
    dotnet run
    ```
4. Run seaweedfs server (can be skipped if you don't use solution submission in Web)
    ```
    weed server
    ```
5. Run hjudge.FileHost (can be skipped if you don't use solution submission in Web)
    ```
    cd hjudge.FileHost/src
    dotnet run
    ```
6. Run frontend dev-server
    ```
    cd hjudge.WebHost/src/Frontend
    yarn start
    ```
7. Run hjudge.WebHost
    ```
    cd hjudge.WebHost/src
    dotnet run
    ```
8. Run your favourite broswer and nagivate to `http://localhost:5000`

## Production Build
1. `fake run build.fsx -t Build`
2. Copy the hjudge.Exec.Linux/hjudge.Exec.Windows output library file generated in step 1 to the hjudge.JudgeHost output folder.

## Run Test
1. `fake run build.fsx -t Test`