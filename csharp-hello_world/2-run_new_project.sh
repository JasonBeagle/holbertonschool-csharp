#!/usr/bin/env bash
# a bash script that initializes and builds a new C# project

dotnet new console -n 2-run_new_project
cd 2-run_new_project
dotnet build 2-run_new_project
dotnet run 2-run_new_project
