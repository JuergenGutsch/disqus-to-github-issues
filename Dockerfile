FROM mcr.microsoft.com/dotnet/core/sdk:3.1

COPY . /app

WORKDIR /app/DisqusToGithubIssues
ENTRYPOINT [ "dotnet" ]