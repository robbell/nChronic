set solutionDir="."
pushd %solutionDir%

call dotnet build /v:normal /target:Build /p:Configuration=%1 src\Chronic.sln

@popd
