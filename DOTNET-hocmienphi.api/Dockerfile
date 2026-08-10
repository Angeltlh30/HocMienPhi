FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DOTNET-hocmienphi.api/DOTNET-hocmienphi.api.csproj", "DOTNET-hocmienphi.api/"]
COPY ["DOTNET-hocmienphi.service/DOTNET-hocmienphi.service.csproj", "DOTNET-hocmienphi.service/"]
COPY ["DOTNET-hocmienphi.repository/DOTNET-hocmienphi.repository.csproj", "DOTNET-hocmienphi.repository/"]
RUN dotnet restore "DOTNET-hocmienphi.api/DOTNET-hocmienphi.api.csproj"
COPY . .
WORKDIR "/src/DOTNET-hocmienphi.api"
RUN dotnet build "./DOTNET-hocmienphi.api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DOTNET-hocmienphi.api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DOTNET-hocmienphi.api.dll"]
