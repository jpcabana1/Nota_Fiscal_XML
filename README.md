# Nota_Fiscal_XML
Projeto para gerar planilha de gasto a partir de um NFC-e.

# **.NET commands**:
### _Dependencies_:
- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet tool install --global dotnet-aspnet-codegenerator
- dotnet tool update -g Dotnet-aspnet-codegenerator
- dotnet tool install --global dotnet-ef

### _dbcontext scaffold :_
- dotnet ef dbcontext scaffold Name=NOTA_FISCAL Microsoft.EntityFrameworkCore.SqlServer -o Models -c NotaFiscalContext
- dotnet ef dbcontext optimize -o Models -n NotaFiscal -c NotaFiscalContext

### _Aspnet CodeGenerator :_
- dotnet aspnet-codegenerator controller -name ImportacaoNotaXmlController -async -api -m ImportacaoNotaXml -dc NotaFiscalContext -outDir Controllers

# **Docker commands**:
- *Banco:* docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=password" -p 1401:1433 --name NOTA_FISCAL_DEV -d mcr.microsoft.com/mssql/server:2022-latest
- _Build_: docker build --tag nfe-importacao-api --file Dockerfile-DEV .
- _Run:_ docker run -p 5001:80 --name nfe-api --link NOTA_FISCAL_DEV nfe-importacao-api 

# **Swagger local**:
- via dotnet run: https://localhost:5001/swagger/index.html
- via docker: http://localhost:5001/swagger/index.html