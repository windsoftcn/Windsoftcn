container_name="app_mp"
container_port=7016

docker stop $container_name  
docker rm $container_name  
docker rmi $container_name  

docker build -t $container_name .

docker run -d -p $container_port:80 --link redis_db:redisDb --restart=on-failure:3 --name=$container_name $container_name 

