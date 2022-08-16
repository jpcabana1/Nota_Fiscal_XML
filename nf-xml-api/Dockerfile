FROM mcr.microsoft.com/dotnet/sdk:latest AS build-env
WORKDIR /app
COPY . ./

RUN dotnet restore
RUN dotnet publish --configuration release --output out

FROM mcr.microsoft.com/dotnet/aspnet:latest
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Production

COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "nf-xml-api.dll"]