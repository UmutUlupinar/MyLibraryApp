FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MyLibrary.MVC/MyLibrary.MVC.csproj", "MyLibrary.MVC/"]
RUN dotnet restore "MyLibrary.MVC/MyLibrary.MVC.csproj"
COPY . .
WORKDIR "/src/MyLibrary.MVC"
RUN dotnet build "MyLibrary.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyLibrary.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyLibrary.MVC.dll"]
