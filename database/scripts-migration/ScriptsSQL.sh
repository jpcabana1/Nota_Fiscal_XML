#!/bin/bash\r

cd var/opt/mssql/data/
echo "Diretório de execução: $PWD"
/opt/mssql-tools/bin/sqlcmd  -S localhost -U SA -P '!n0ta_app' -i CreateDatabaseDDL.sql
/opt/mssql-tools/bin/sqlcmd  -S localhost -U SA -P '!n0ta_app' -i CreateUserDCL.sql
/opt/mssql-tools/bin/sqlcmd  -S localhost -U SA -P '!n0ta_app' -i CreateSchemaDDL.sql
/opt/mssql-tools/bin/sqlcmd  -S localhost -U SA -P '!n0ta_app' -i CreateTablesDDL.sql
/opt/mssql-tools/bin/sqlcmd  -S localhost -U SA -P '!n0ta_app' -i CreateViewDDL.sql
