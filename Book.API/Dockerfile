﻿FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR ..
COPY ["Book.API.csproj", "Book.API/"]
RUN dotnet restore "Book.API/Book.API.csproj"
COPY . .
WORKDIR "/Book.API"
RUN dotnet build "Book.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Book.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Book.API.dll"]
