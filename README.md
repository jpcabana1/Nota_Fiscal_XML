# **Nota_Fiscal_XML**
Projeto para gerar planilha de gasto a partir de um NFC-e.

# *Ambientes:*

## Local
- _SQL Server Migration:_ .\setup-migration.ps1 -nomeContainer "nfe-local" -initDB "S"
- *Connection string*: **Server=localhost, 1401;Database=master;User Id=sa;Password=!n0ta_app**
- *ASPNETCORE_ENVIRONMENT*=LocalDevelopment
- _swagger local:_ https://localhost:5001/swagger/index.html

## DEV
- *Iniciar api*: docker-compose --file docker-compose-dev.yml -p nfe-dev up -d --build
- _SQL Server Migration:_ .\setup-migration.ps1 -nomeContainer "nota-fiscal-dev" -initDB "N"
- *Iniciar app*: npm start
- *Connection string*: **Server=localhost, 1402;Database=master;User Id=sa;Password=!n0ta_app**
- *ASPNETCORE_ENVIRONMENT*=Development
- _swagger DEV:_ http://localhost:5002/swagger/index.html

## STAGE
- *Iniciar app*: docker-compose --file docker-compose-stage.yml -p nfe-stage up -d --build
- _SQL Server Migration:_ .\setup-migration.ps1 -nomeContainer "nota-fiscal-stage" -initDB "N"
- *Connection string*: **Server=localhost, 1403;Database=master;User Id=sa;Password=!n0ta_app**
- *ASPNETCORE_ENVIRONMENT*=Staging
- _swagger STAGE:_ http://localhost:5003/swagger/index.html

## PROD
- *Iniciar app*: docker-compose --file docker-compose-prod.yml -p nfe-prod up -d --build
- _SQL Server Migration:_ .\setup-migration.ps1 -nomeContainer "nota-fiscal-prod" -initDB "N"
- *Connection string*: **Server=localhost, 1404;Database=master;User Id=sa;Password=!n0ta_app**
- *ASPNETCORE_ENVIRONMENT*=Production


## **Scripts Úteis:**
- **Autorizar execução no PowerShell:** Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
- **Levantar banco de dados:** .\setup-migration.ps1 -nomeContainer "nome-desejado"
- **_Docker Build:_** docker build --tag nfe-importacao-api --file Dockerfile .
- **_Docker Run Api:_** docker run -e "ASPNETCORE_ENVIRONMENT=LocalDevelopment" -p 5001:80 --name nfe-api --link nomeContainer 



# **Comandos NPM**:
- npm create vite@latest nf-xml-front --template react-ts ou npx create-react-app nf-xml-front --template typescript
- npm install react-router-dom
- npm install react-bootstrap bootstrap
- npm i --save @fortawesome/fontawesome-svg-core
- npm install --save @fortawesome/free-solid-svg-icons
- npm install --save @fortawesome/react-fontawesome
- npm i -D env-cmd
- npm install -g serve
- npm install @reduxjs/toolkit
- npm install redux
- npm install react-redux
- npm install axios
- npm install react-hook-form
- npm install react-datepicker --save
- npm install react-table --save 
- npm i react-vertical-timeline-component

## Levantar ambiente local:
- npm install
- npm run dev

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
- dotnet ef dbcontext scaffold Name=NOTA_FISCAL Microsoft.EntityFrameworkCore.SqlServer -o Models -c NotaFiscalContext
- dotnet ef dbcontext optimize -o Models -n NotaFiscal -c NotaFiscalContext

### _Aspnet CodeGenerator :_
- dotnet aspnet-codegenerator controller -name ImportacaoNotaXmlController -async -api -m ImportacaoNotaXml -dc NotaFiscalContext -outDir Controllers
