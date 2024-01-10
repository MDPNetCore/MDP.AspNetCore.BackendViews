FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /repo
COPY . .
RUN dotnet publish "src/MDP.AspNetCore.BackendViews.Lab/MDP.AspNetCore.BackendViews.Lab.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "MDP.AspNetCore.BackendViews.Lab.dll"]