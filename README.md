# Cooking-Recipe
A system that allow you to manage all your favorite cooking recipies

Cooking Recipies is a .Net Core application with Blazor

This project  works as an recipe administrator, it work for home localhost.

## With docker compose
You can use docker compose to try this app locally if you have it install

Copy this file to a directory

```
version: '3.1'
services:
    postgres:
        ports:
          - "5434:5432"
        image: postgres:latest
        networks: 
          - net
        restart: unless-stopped
        volumes:
          - postgres-data:/var/lib/postgresql/data
        environment:
          TZ: "America/Sao_Paulo"
          PGTZ: 'America/Sao_Paulo'
          POSTGRES_USER: postgres
          POSTGRES_DB: postgres
          POSTGRES_PASSWORD: postgres

    cooking:
      image: haissamfawaz/cooking-recipe-image:latest
      restart: always
      networks: 
        - net
      ports:
        - 8080:80
volumes:
  postgres-data:
networks: 
  net:
    driver: bridge
```

Than run 
```bash
docker-compose up
```
And docker will pull the public the latest image of the app on DockerHub https://hub.docker.com/repository/docker/haissamfawaz/cooking-recipe-image

### Run the script to set up the database.  

in this repository we have all scripts for the latest version
https://github.com/HaissamHammoud/cooking-recipe-database-scripts

coppy the files and run them inside de container with 

```bash
cat ./<script-name>.sql | docker exec -i <container-id> psql -U postgres -d postgres
```

And the app will be available on localhost:8080

## With Docker and Swarm

First init swarm with
```bash
docker swarm init 
```
Than copy this file on a local directory:
```
version: '3.1'
services:
    postgres:
        ports:
          - "5434:5432"
        image: postgres:latest
        networks: 
          - net
        restart: unless-stopped
        volumes:
          - postgres-data:/var/lib/postgresql/data
        environment:
          TZ: "America/Sao_Paulo"
          PGTZ: 'America/Sao_Paulo'
          POSTGRES_USER: postgres
          POSTGRES_DB: postgres
          POSTGRES_PASSWORD: postgres

    cooking:
      image: haissamfawaz/cooking-recipe-image:latest
      restart: always
      networks: 
        - net
      ports:
        - 8080:80
volumes:
  postgres-data:
networks: 
  net:
    driver: overlay
```

Verify if the service starts correctly with
```bash
docker service ls
```

### Run the script to set up the database.  

in this repository we have all scripts for the latest version
https://github.com/HaissamHammoud/cooking-recipe-database-scripts

coppy the files and run them inside de container with 

```bash
cat ./<script-name>.sql | docker exec -i <container-id> psql -U postgres -d postgres
```

And the app will be available on localhost:8080
