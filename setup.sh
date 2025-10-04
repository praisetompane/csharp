VERSION=8.0.413

echo "adding asdf .NET Core plugin"
    asdf plugin add dotnet-core
echo "done"

echo "Installing .NET Core SDK"
    asdf install dotnet-core  $VERSION
echo "done"

echo "Setting .NET Core SDK global version"
    asdf set dotnet-core  $VERSION
echo "done"

echo "Installing nuget"
    brew install nuget
echo "done"

# echo "Installing .NET runtime"
#     brew install dotnet-runtime
# echo "done"