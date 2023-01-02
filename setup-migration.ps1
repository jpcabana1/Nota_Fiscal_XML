param([string] $nomeContainer, [string] $initDB)

Write-Host "nomeContainer: $nomeContainer"

switch ($initDB) {
    'S' { 
        docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=!n0ta_app" -p 1401:1433 --name $nomeContainer -d mcr.microsoft.com/mssql/server:2022-latest
        Write-Host "Iniciando Banco de Dados..."
        Start-Sleep -Seconds 6
     }
    'N' { 
        Write-Host "Copiando arquivos para o container $nomeContainer..."
        Start-Sleep -Seconds 4
     }
    Default { 
        Write-Host "Copiando arquivos para o container $nomeContainer..."
        Start-Sleep -Seconds 4
     }
}



Write-Host "Copiando o arquivo CreateDatabaseDDL.sql para o container $nomeContainer..."
docker cp ./database/scripts-migration/CreateDatabaseDDL.sql  "${nomeContainer}:/var/opt/mssql/data/"
Write-Host "Copiando o arquivo CreateUserDCL.sql para o container $nomeContainer..."
docker cp ./database/scripts-migration/CreateUserDCL.sql  "${nomeContainer}:/var/opt/mssql/data/" 
Write-Host "Copiando o arquivo CreateSchemaDDL.sql para o container..."
docker cp ./database/scripts-migration/CreateSchemaDDL.sql  "${nomeContainer}:/var/opt/mssql/data/" 
Write-Host "Copiando o arquivo CreateTablesDDL.sql para o container $nomeContainer..."
docker cp ./database/scripts-migration/CreateTablesDDL.sql  "${nomeContainer}:/var/opt/mssql/data/" 
Write-Host "Copiando o arquivo CreateViewDDL.sql para o container $nomeContainer..."
docker cp ./database/scripts-migration/CreateViewDDL.sql  "${nomeContainer}:/var/opt/mssql/data/"
Write-Host "Copiando o arquivo ScriptsSQL.sh para o container $nomeContainer..."
docker cp ./database/scripts-migration/ScriptsSQL.sh  "${nomeContainer}:/var/opt/mssql/data/" 

Write-Host "Iniciando migração do Banco de Dados..."
docker exec -it $nomeContainer "bash" /var/opt/mssql/data/ScriptsSQL.sh
Read-Host -Prompt "Pressione Enter para sair..."
