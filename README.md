# Introdução
APIs para cálculo de juros:
- Api que retorna a taxa de juros;
- Api que calcula a taxa de juros com base no valor inicial e quantidade de meses.

---

## Compilando em seu computador
Para compilar este projeto é necessário ter o Microsoft .NET Core 3.1 SDK instalado.
Disponível para download em https://dotnet.microsoft.com/download/dotnet-core/3.1

**SH File e Docker commands**
Na pasta shell deste repositório foram criado os seguintes arquivos:

- 01-full-build.sh que quando executado, aplica o build, gera a imagem docker das APIs e publica no repositório do Docker Hub
- 01-App.yml que é executado através de docker commands citados abaixo, para subir os containers baseado nas imagens que foram criadas no item anterior

```bash
docker-compose -f 01-App.yml -p juros up --no-start 
docker-compose -f 01-App.yml -p juros start
```

Após aplicar o docker compose, as aplicações ficarão nas portas 81 e 82, podendo ser acessadas através dos seguintes links:
http://localhost:81/swagger
http://localhost:82/swagger

Dúvidas, estou à disposição
