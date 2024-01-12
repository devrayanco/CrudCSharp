# CrudCSharp
Esse é um Crud simples usando C# e SqlServer com o Blazor


# Maneira de uso 
deve-se alterar a conexão com banco de dados no arquivo appsettings.json para as funcionalidades ocorrerem da melhor forma, após a configuração da connectiostring deve-se rodar Add-migration para o framework configurar o banco de dados 

``` json
  "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-O9VE3TV\\SQLEXPRESS; Database=MyCrud; Trusted_connection=true; encrypt=false"
  },
```

server= "seu servidor"
