FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["API/Agilistas.csproj", "API/"]
RUN dotnet restore "API/Agilistas.csproj"
COPY . .
WORKDIR "/src/API"
RUN dotnet build "Agilistas.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Agilistas.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Agilistas.dll"]
