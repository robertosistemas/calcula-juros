#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CalculaJuros.WebApi/CalculaJuros.WebApi.csproj", "CalculaJuros.WebApi/"]
COPY ["CalculaJuros.Application/CalculaJuros.Application.csproj", "CalculaJuros.Application/"]
COPY ["CalculaJuros.Core/CalculaJuros.Core.csproj", "CalculaJuros.Core/"]
RUN dotnet restore "CalculaJuros.WebApi/CalculaJuros.WebApi.csproj"
COPY . .
WORKDIR "/src/CalculaJuros.WebApi"
RUN dotnet build "CalculaJuros.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalculaJuros.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculaJuros.WebApi.dll"]