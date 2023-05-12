#!/usr/bin/env bash
# a bash script that initializes and builds a new C# project

dotnet new console -n 1-new_project
cd 1-new_project
dotnet build
