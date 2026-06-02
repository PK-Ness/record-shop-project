# 1. Set base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /App

# 3. copy source code and restore dependencies
COPY . ./
RUN dotnet restore

# 4. build and publish the app
RUN dotnet publish -c Release -o out

# 5. Set the working directory to the output folder o
WORKDIR /App/out

# 6. Run the application via the .dll file 
ENTRYPOINT ["dotnet", "RecordShop.dll"]