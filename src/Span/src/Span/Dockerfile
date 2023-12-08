FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Span/src/Span/Span.csproj", "src/Span/src/Span/"]
RUN dotnet restore "src/Span/src/Span/Span.csproj"
COPY . .
WORKDIR "/src/src/Span/src/Span"
RUN dotnet build "Span.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Span.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Span.dll"]
