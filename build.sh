#!/usr/bin/env bash

#exit if any command fails
set -e

artifactsFolder="./artifacts"

if [ -d $artifactsFolder ]; then  
  rm -R $artifactsFolder
fi

dotnet restore

# Ideally we would use the 'dotnet test' command to test netcoreapp and net451 so restrict for now 
# but this currently doesn't work due to https://github.com/dotnet/cli/issues/3073 so restrict to netcoreapp

dotnet test ./test/HRCore.Staff.Tests -c Release -f netcoreapp1.0

# Instead, run directly with mono for the full .net version 
dotnet build ./test/HRCore.Staff.Tests -c Release -f net451

mono \  
./test/HRCore.Staff.Tests/bin/Release/net451/*/dotnet-test-xunit.exe \
./test/HRCore.Staff.Tests/bin/Release/net451/*/HRCore.Staff.Tests.dll

revision=${TRAVIS_JOB_ID:=1}  
revision=$(printf "%04d" $revision) 

dotnet pack ./src/HRCore.Staff -c Release -o ./artifacts --version-suffix=$revision 