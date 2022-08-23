docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=!n0ta_app" -p 1401:1433 --name NOTA_FISCAL_LOCAL -d mcr.microsoft.com/mssql/server:2022-latest
Write-Host "Iniciando Banco de Dados..."
Start-Sleep -Seconds 6
Write-Host "Copiando o arquivo CreateDatabaseDDL.sql para o container..."
docker cp ./database/scripts-migration/CreateDatabaseDDL.sql  NOTA_FISCAL_LOCAL:/var/opt/mssql/data/ 
Write-Host "Copiando o arquivo CreateUserDCL.sql para o container..."
docker cp ./database/scripts-migration/CreateUserDCL.sql  NOTA_FISCAL_LOCAL:/var/opt/mssql/data/ 
Write-Host "Copiando o arquivo CreateSchemaDDL.sql para o container..."
docker cp ./database/scripts-migration/CreateSchemaDDL.sql  NOTA_FISCAL_LOCAL:/var/opt/mssql/data/ 
Write-Host "Copiando o arquivo CreateTablesDDL.sql para o container..."
docker cp ./database/scripts-migration/CreateTablesDDL.sql  NOTA_FISCAL_LOCAL:/var/opt/mssql/data/ 
Write-Host "Copiando o arquivo CreateViewDDL.sql para o container..."
docker cp ./database/scripts-migration/CreateViewDDL.sql  NOTA_FISCAL_LOCAL:/var/opt/mssql/data/
Write-Host "Copiando o arquivo ScriptsSQL.sh para o container..."
docker cp ./database/scripts-migration/ScriptsSQL.sh  NOTA_FISCAL_LOCAL:/var/opt/mssql/data/ 
Write-Host "Iniciando migração do Banco de Dados..."
docker exec -it NOTA_FISCAL_LOCAL "bash" /var/opt/mssql/data/ScriptsSQL.sh