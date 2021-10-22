
set imagetag=docker.io/csharp-sample-api
docker build --rm -t %imagetag% -f Dockerfile .
pause

# docker tag docker.io/csharp-sample-api docker.io/yangliangbin/csharp-sample-api