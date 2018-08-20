FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 54012
EXPOSE 44368

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["GenerateKey/GenerateKey.csproj", "GenerateKey/"]
RUN dotnet restore "GenerateKey/GenerateKey.csproj"
COPY . .
WORKDIR "/src/GenerateKey"
RUN dotnet build "GenerateKey.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GenerateKey.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GenerateKey.dll"]