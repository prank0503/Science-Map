#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["ScienceMap.WebServices.Api/ScienceMap.WebServices.Api.csproj", "ScienceMap.WebServices.Api/"]
RUN dotnet restore "ScienceMap.WebServices.Api/ScienceMap.WebServices.Api.csproj"
COPY . .
WORKDIR "/src/ScienceMap.WebServices.Api"
RUN dotnet build "ScienceMap.WebServices.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ScienceMap.WebServices.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ScienceMap.WebServices.Api.dll"]