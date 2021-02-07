# DockerWorkshop

Aim of this Workshop is to demistify basic usage of Docker

Two aim in this workshop :
- Running simple application like Redis / ElasticSearch for POC & learning & local development & tests
- Building your own image with a short Asp.Net API

---

## Using docker for development

### Cheatsheet
```
docker ps // list running containers
docker ps -a // list all containers
docker images // list images
docker start {container id | container name}
docker stop {container id} // can be the two first charaters of the id
docker rm {container id} // remove container by id
```

### Get a specific version of an image

Pull images from Docker Hub
[Docker Hub](https://hub.docker.com/)

<b>Imagename:{version}</b>

[Elasticsearch Dockerhub](https://hub.docker.com/_/elasticsearch)

```
docker pull elasticsearch:7.10.1
```

### Running Elastic image with Docker container

What compose this command line :
- -d for detach process run
- --name {name} for naming contain to run
- p for port binding, left part is the external rule and right side the container internal port
ex: 9200:8200 bind outside port 9200 and container port 8200
- e for environment variable (can be multiple)
- finally the required image name 

```
docker run -d --name elasticsearch -p 127.0.0.1:9200:9200 -p 127.0.0.1:9300:9300 -e "discovery.type=single-node" -e "ES_JAVA_OPTS=-Xmx256m -Xms256m" elasticsearch:7.10.1
```
[localhost cluster route](http://127.0.0.1:9200/)


### Other container with another image

<br>
You can now train the storage you want

Redis [link](https://hub.docker.com/_/redis)

Mssql [link](https://hub.docker.com/_/microsoft-mssql-server)

Postgres [link](https://hub.docker.com/_/postgres)

---

## Building your first (maybe not) Asp.Net API image


### Development vs Runtime

### Building & Running with command line

```
dotnet restore

dotnet publish -c Release -o out

dotnet out/DockerWorkshop.dll
```

Let check your API running [The future is you](http://localhost:8080/api/v0/workshops)

Now check 

### Dockerfile

[Building image documentation](https://docs.docker.com/engine/examples/dotnetcore/)
