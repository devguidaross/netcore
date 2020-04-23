echo ">>> DOTNET API1 BUILD <<<"
echo ""

rm -r "../Api1/bin/Release/netcoreapp3.1"

cd ..

git pull https://github.com/devguidaross/netcore.git

dotnet publish "Api1/Api1.csproj" -c Release -o "./Api1/publish" -f netcoreapp3.1

echo ">>> DOTNET API1 BUILD - CONCLUIDO <<<"
echo ""

echo ">>> DOCKER API1 <<<"
echo ""

echo ">>> DOCKER API1 BUILD <<<"
cd Api1
docker rmi --force guidaross/taxajuros-api:1.0
docker build -t guidaross/taxajuros-api:1.0 .
echo ""

echo ">>> DOCKER API1 BUILD - CONCLUÍDO <<<"
echo ""

echo ">>> DOCKER PUSH API1 <<<"
docker push guidaross/taxajuros-api:1.0
echo ""

cd ../shell





echo ">>> DOTNET API2 BUILD <<<"
echo ""

rm -r "../Api2/bin/Release/netcoreapp3.1"

cd ..

git pull https://github.com/devguidaross/netcore.git

dotnet publish "Api2/Api2.csproj" -c Release -o "./Api2/publish" -f netcoreapp3.1

echo ">>> DOTNET API2 BUILD - CONCLUIDO <<<"
echo ""

echo ">>> DOCKER API2 <<<"
echo ""

echo ">>> DOCKER API2 BUILD <<<"
cd Api2
docker rmi --force guidaross/calculajuros-api:1.0
docker build -t guidaross/calculajuros-api:1.0 .
echo ""

echo ">>> DOCKER API2 BUILD - CONCLUÍDO <<<"
echo ""

echo ">>> DOCKER PUSH API2 <<<"
docker push guidaross/calculajuros-api:1.0
echo ""

cd ../shell