# Nota_Fiscal_XML
Projeto para gerar planilha de gasto a partir de um NFC-e.

# **Comandos .NET**:
### _Dependencies_:
- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet tool install --global dotnet-aspnet-codegenerator
- dotnet tool update -g Dotnet-aspnet-codegenerator
- dotnet tool install --global dotnet-ef

### _dbcontext scaffold :_
- dotnet ef dbcontext scaffold Name=NFE_IMPORTACAO Microsoft.EntityFrameworkCore.SqlServer -o Models -c NotaFiscalContext
- dotnet ef dbcontext optimize -o Models -n NotaFiscal -c NotaFiscalContext

### _Aspnet CodeGenerator :_
- dotnet aspnet-codegenerator controller -name ImportacaoNotaXmlController -async -api -m ImportacaoNotaXml -dc NotaFiscalContext -outDir Controllers

# **Ambientes**

## Local
- *Banco de Dados Local:* docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=!n0ta_app" -p 1401:1433 --name NFE_IMPORTACAO -d mcr.microsoft.com/mssql/server:2022-latest
- **_Docker Build_**: *docker build --tag nfe-importacao-api --file Dockerfile .*
- _Docker Run:_ docker run -e "ASPNETCORE_ENVIRONMENT=LocalDevelopment" -p 5001:80 --name nfe-api --link NFE_IMPORTACAO nfe-importacao-api
- *Connection string*: **Server=localhost, 1401;Database=master;User Id=sa;Password=!n0ta_app**
- Executar scripts da pasta: ./scripts-migration/nfe-local.sql
- *ASPNETCORE_ENVIRONMENT*=LocalDevelopment
- _swagger local:_ https://localhost:5001/swagger/index.html

## DEV
- *Iniciar app*: docker-compose --file docker-compose-dev.yml -p nfe-DEV up -d --build
- *Connection string*: **Server=localhost, 1402;Database=master;User Id=sa;Password=!n0ta_app**
- Executar scripts da pasta: ./scripts-migration/nfe-dev.sql
- *ASPNETCORE_ENVIRONMENT*=Development
- _swagger DEV:_ http://localhost:5002/swagger/index.html

## STAGE
- *Iniciar app*: docker-compose --file docker-compose-stage.yml -p nfe-STAGE up -d --build
- *Connection string*: **Server=localhost, 1403;Database=master;User Id=sa;Password=!n0ta_app**
- Executar scripts da pasta: ./scripts-migration/nfe-stage.sql
- *ASPNETCORE_ENVIRONMENT*=Staging
- _swagger STAGE:_ http://localhost:5003/swagger/index.html

## PROD
- *Iniciar app*: docker-compose --file docker-compose-prod.yml -p nfe-PROD up -d --build
- *Connection string*: **Server=localhost, 1404;Database=master;User Id=sa;Password=!n0ta_app**
- Executar scripts da pasta: ./scripts-migration/nfe-prod.sql
- *ASPNETCORE_ENVIRONMENT*=Production
