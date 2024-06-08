#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["gabrovoultrawebapp.client/nuget.config", "gabrovoultrawebapp.client/"]
COPY ["GabrovoUltraWebApp.Server/GabrovoUltraWebApp.Server.csproj", "GabrovoUltraWebApp.Server/"]
COPY ["gabrovoultrawebapp.client/gabrovoultrawebapp.client.esproj", "gabrovoultrawebapp.client/"]
COPY ["GabrovoUltraWebApp.Core/GabrovoUltraWebApp.Core.csproj", "GabrovoUltraWebApp.Core/"]
COPY ["GabrovoUltraWebApp.Infrastructure/GabrovoUltraWebApp.Infrastructure.csproj", "GabrovoUltraWebApp.Infrastructure/"]
RUN dotnet restore "./GabrovoUltraWebApp.Server/GabrovoUltraWebApp.Server.csproj"
COPY . .
WORKDIR "/src/GabrovoUltraWebApp.Server"
RUN dotnet build "./GabrovoUltraWebApp.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GabrovoUltraWebApp.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GabrovoUltraWebApp.Server.dll"]