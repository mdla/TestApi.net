FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["JWTNet/JWTNet.csproj", "JWTNet/"]
RUN dotnet restore "JWTNet/JWTNet.csproj"
COPY . .
WORKDIR "/src/JWTNet"
RUN dotnet build "JWTNet.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "JWTNet.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "JWTNet.dll"]