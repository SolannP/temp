#!/bin/bash
function GetUsage {
  cat << EOF
  
  Usage: $(basename $0) [OPTIONS]

  Options:
    -d, --docker-compose        reset init and start docker instance
    -h, --help                  show this help
    -c, --clean                 clean all docker data
    -a, --acces                 create sqlcmd connexion
    -r, --ressources            print used ressources
EOF
}

function GetRessources {
  cat << EOF
Basic docker data relativ stuff: 
  - https://hub.docker.com/_/microsoft-mssql-server
More detailed docker stuff: 
  - https://learn.microsoft.com/en-us/sql/linux/sql-server-linux-docker-container-configure?view=sql-server-ver15&pivots=cs1-bash#persist
EOF
}

docker_container_name='SQL_SERVER'
# can be localhost
docker_network_host='fast-typing-db'
sql_admin_user_id='sa'
sql_admin_password='yourStrong(!)Password'

# Sample funciton, not used anymore
docker_name_image='fast-typing-bdd-image'
function CreateDockerComposeFile {
	echo "===================================================================="
	echo "Generate yaml file for docker compose deployement "
	echo "--------------------------------------------------------------------"
	docker_compose='version: "1.0"
services: 
  fast-typing-db:
    # SQL Server Express
    image: "mcr.microsoft.com/mssql/server:2019-latest"
    # Take by default the name : <folder>-<service_name> but can be set bellow when uncomment
    container_name: "$docker_container_name"
    ports:
    - "1433:1433"
    environment:
    - MSSQL_PID=Express
     # system administrator (userid = 'sa') 
    - MSSQL_SA_PASSWORD=yourStrong(!)Password
    - ACCEPT_EULA=Y
    restart: always
    volumes:
    - "./sql/data:/var/opt/mssql"
    #- "./sql/log:/var/opt/mssql/log"
    #- "./sql/secrets:/var/opt/mssql/secrets"'
	echo $docker_compose
	echo $conf_json_angular > ./docker-compose.yml
}


if [[ $1 =~ "-d" ]]
then 
	docker compose down
	docker container remove $(docker ps --filter status=exited -q)
	docker compose up
	exit 1
elif [[ $1 =~ "-c" ]]
then 
	docker builder prune -af
	docker system prune
	docker image prune
	docker volume prune
	exit 0
elif [[ $1 =~ "-a" ]]
then 
	echo docker exec -it $docker_container_name /opt/mssql-tools/bin/sqlcmd -S localhost -U $sql_admin_user_id -P $sql_admin_password
	docker exec -it $docker_container_name /opt/mssql-tools/bin/sqlcmd -S $docker_network_host -U $sql_admin_user_id -P $sql_admin_password
elif [[ $1 =~ "-h" ]]
then 
  GetUsage
  exit 0
elif [[ $1 =~ "-r" ]]
then 
  GetRessources
elif [[ $1 =~ "" ]]
then 
  GetUsage
  exit 0
fi