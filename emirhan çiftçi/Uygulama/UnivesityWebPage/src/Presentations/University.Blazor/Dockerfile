#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app
COPY . ./
#RUN dotnet publish -c Release -o output
RUN dotnet publish "src/Presentations/University.Blazor/University.Blazor.csproj" -c Release -o /app/build

FROM nginx:alpine
WORKDIR /var/www/web
COPY --from=build-env /app/build/wwwroot .
COPY src/Presentations/University.Blazor/nginx.conf /etc/nginx/nginx.conf