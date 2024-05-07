FROM mcr.microsoft.com/dotnet/aspnet:8.0 as base
WORKDIR /app

EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80


FROM mcr.microsoft.com/dotnet/sdk:8.0 AS publish
WORKDIR /src
COPY ./ ./
RUN dotnet restore
 # publish to the publish directory in the image --> src/publish
RUN dotnet publish -c Release -o publish


FROM base as final
WORKDIR /app
COPY --from=publish /src/publish .
ENTRYPOINT ["dotnet", "Movies.API.dll"] 