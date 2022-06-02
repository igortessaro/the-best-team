#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Pokemon.TheBestTeam.Api/Pokemon.TheBestTeam.Api.csproj", "Pokemon.TheBestTeam.Api/"]
RUN dotnet restore "Pokemon.TheBestTeam.Api/Pokemon.TheBestTeam.Api.csproj"
COPY . .
WORKDIR "/src/Pokemon.TheBestTeam.Api"
RUN dotnet build "Pokemon.TheBestTeam.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pokemon.TheBestTeam.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pokemon.TheBestTeam.Api.dll"]
