VERSION=8.0.413

echo "adding asdf dotnet-core plugin"
    asdf plugin add dotnet-core
echo "done"

echo "installing dotnet-core "
    asdf install dotnet-core  $VERSION
echo "done"

echo "set version"
    asdf set dotnet-core  $VERSION
echo "done"

echo "install nuget"
    brew install nuget
echo "done"