#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Hack29-WebApp/Hack29-WebApp.csproj", "Hack29-WebApp/"]
RUN dotnet restore "Hack29-WebApp/Hack29-WebApp.csproj"
COPY . .
WORKDIR "/src/Hack29-WebApp"
RUN dotnet build "Hack29-WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hack29-WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hack29-WebApp.dll"]