FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["chef-app-backend-dotnet/chef-app-backend-dotnet.csproj", "chef-app-backend-dotnet/"]
RUN dotnet restore "chef-app-backend-dotnet/chef-app-backend-dotnet.csproj"
COPY . .
WORKDIR "/src/chef-app-backend-dotnet"
RUN dotnet build "chef-app-backend-dotnet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "chef-app-backend-dotnet.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "chef-app-backend-dotnet.dll"]
