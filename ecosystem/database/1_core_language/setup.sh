echo "Installing EF Global Tool"
    dotnet tool install -g dotnet-ef
echo "Done Installing EF Global Tool"

# Useful Commands
# 1. Create Migrations
  # pattern:  dotnet ef migrations add {Migration Name}
dotnet ef migrations add InitialCreate

# 2. Run Migrations
dotnet ef database update