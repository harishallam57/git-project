# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# Copy the project file and restore dependencies
COPY ToolKit/ToolKit.csproj ToolKit/
RUN dotnet restore ToolKit/ToolKit.csproj

# Copy the entire project and build it
COPY . .
RUN dotnet publish ToolKit/ToolKit.csproj -c Release -o out

# Use the official .NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

# Expose the port the app runs on
EXPOSE 80
EXPOSE 443

# Start the application
ENTRYPOINT ["dotnet", "ToolKit.dll"]
