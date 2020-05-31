#!/bin/bash
set -eu -o pipefail
echo "in entrypoint-tests file"
sleep 12s

dotnet test ModelTests/ModelTests.csproj

