#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Presentations/University.WebAPI/University.WebAPI/University.WebAPI.csproj", "src/Presentations/University.WebAPI/University.WebAPI/"]
COPY ["src/Infrastructure/University.Persistence/University.Persistence.csproj", "src/Infrastructure/University.Persistence/"]
COPY ["src/Core/University.Application/University.Application.csproj", "src/Core/University.Application/"]
COPY ["src/Core/University.Domain/University.Domain.csproj", "src/Core/University.Domain/"]
RUN dotnet restore "src/Presentations/University.WebAPI/University.WebAPI/University.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/Presentations/University.WebAPI/University.WebAPI"
RUN dotnet build "University.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "University.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "University.WebAPI.dll"]