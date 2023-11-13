FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DataOrientedProgramming/DataOrientedProgramming.csproj", "DataOrientedProgramming/"]
RUN dotnet restore "DataOrientedProgramming/DataOrientedProgramming.csproj"
COPY . .
WORKDIR "/src/DataOrientedProgramming"
RUN dotnet build "DataOrientedProgramming.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DataOrientedProgramming.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DataOrientedProgramming.dll"]
