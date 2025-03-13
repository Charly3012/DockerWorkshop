# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./SiceiApi/SiceiApi.csproj" --disable-parallel
RUN dotnet publish "./SiceiApi/SiceiApi.csproj" -c release -o /app --no-restore

# Serve stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app ./

EXPOSE 8080
ENTRYPOINT [ "dotnet", "SiceiApi.dll" ]