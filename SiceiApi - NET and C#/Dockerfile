# ===== Build stage =====
# Usamos la imagen oficial del SDK de .NET 8 para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establecemos el directorio de trabajo dentro del contenedor
WORKDIR /source

# Copiamos todos los archivos del proyecto al contenedor "origen" "destino"
COPY . .

# Restauramos las dependencias de .NET (descarga los paquetes necesarios)
# Se usa --disable-parallel para evitar problemas de concurrencia en algunos entornos
RUN dotnet restore "./SiceiApi/SiceiApi.csproj" --disable-parallel

# Compilamos y publicamos la aplicación en modo release dentro del directorio /app
# Se usa --no-restore porque ya se restauraron las dependencias en el paso anterior
RUN dotnet publish "./SiceiApi/SiceiApi.csproj" -c release -o /app --no-restore



# ===== Serve stage =====
# Usamos una imagen más ligera de .NET que solo contiene el runtime (sin SDK)
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Establecemos el directorio de trabajo dentro del contenedor
WORKDIR /app

# Copiamos la aplicación compilada desde la imagen anterior (build stage) a la nueva imagen
COPY --from=build /app ./

# Exponemos el puerto 8080 para que la aplicación esté accesible externamente
EXPOSE 8080

# Configuramos el comando de inicio: ejecutamos la API con `dotnet SiceiApi.dll`
ENTRYPOINT [ "dotnet", "SiceiApi.dll" ]