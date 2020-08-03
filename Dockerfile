#Dockerfile
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build
WORKDIR /src
COPY ./*.sln ./
COPY ./*/*.csproj ./

RUN dotnet restore SportsApparelApp.csproj

RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done

RUN dotnet restore

COPY . .

RUN dotnet publish -o ../publish

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS runtime
WORKDIR /publish
#COPY --from=buid-image /publish .

EXPOSE 80
ENTRYPOINT ["dotnet", "SportsApparelApp.dll"]
