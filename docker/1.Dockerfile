# syntax=docker/dockerfile:1

# 1 Specific base image for build
FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-env

# 2. Copy csproj file to restore needed package
WORKDIR /src
COPY src/TShop.Api/*.csproj ./TShop.Api/
WORKDIR /src/TShop.Api
RUN dotnet restore

# 3. Copy the rest code and build
COPY src/TShop.Api ./TShop.Api/
RUN dotnet publish -c Release -o /publish
 
# 4. Publish code and build
FROM mcr.microsoft.com/dotnet/aspnet:7.0 as runtime
WORKDIR /publish
COPY --from=build-env /publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "TShop.Api.dll"]