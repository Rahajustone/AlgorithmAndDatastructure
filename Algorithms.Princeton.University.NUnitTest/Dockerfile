#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Algorithms.Princeton.University.NUnitTest/Algorithms.Princeton.University.NUnitTest.csproj", "Algorithms.Princeton.University.NUnitTest/"]
COPY ["Algorithms.Princeton.Unuversity/Algorithms.Princeton.Unuversity.csproj", "Algorithms.Princeton.Unuversity/"]
RUN dotnet restore "./Algorithms.Princeton.University.NUnitTest/Algorithms.Princeton.University.NUnitTest.csproj"
COPY . .
WORKDIR "/src/Algorithms.Princeton.University.NUnitTest"
RUN dotnet build "./Algorithms.Princeton.University.NUnitTest.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Algorithms.Princeton.University.NUnitTest.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Algorithms.Princeton.University.NUnitTest.dll"]