# myfinance-web-dotnet
MyFinance - Projeto do Curso de Pós-Graduação em Engenharia de Software da PUC-Minas

## Descrição do Projeto:
O My Finance é uma aplicação que permite ao usuário controlar suas finanças por meio do cadastro de despesas e receitas. Além disso, para melhorar a experiência do usuário, a aplicação possibilita que o usuário possa editar ou excluir cada informação de maneira simples na tela de exibição.

## Informações Técnicas:
### Arquitetura Utilizada
O padrão de arquitetura utilizado para a criação do MyFinance foi o estilo de arquitetura em camadas MVC (Model-View-Controller), o qual foi escolhido para garantir uma aplicação organizada e de fácil manutenibilidade.

### Tecnologias Utilizadas:
**Linguagem:** C#

**Framework:** ASP.NET v.8.0.404

**Banco de Dados**: SQL Server 2022

**IDE utilizada:** Desenvolvido utilizando Visual Studio Code

## Configuração inicial:

1. Fazer o download do Asp.Net através do [link](https://dotnet.microsoft.com/pt-br/).
2. Fazer o download e configurar [Visual Studio](https://visualstudio.microsoft.com/pt-br/) ou [Visual Studio Code](https://code.visualstudio.com/).
3. Caso necessite fazer alguma alteração no banco de dados, pode-se fazer o download do [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads) (a criação do banco de dados se encontra no seguinte [link](https://github.com/enzocl/myfinance-web-dotnet/tree/main/myfinance-web-dotnet/Docs/Databases) contido dentro da pasta da aplicação.
4. Após a configuração, deve-se clonar o repositório através do comando:
``` git clone https://github.com/enzocl/myfinance-web-dotnet.git``` ou `gh repo clone enzocl/myfinance-web-dotnet`
5. Antes da execução da aplicação, recomenda-se instalar o Entity Framework Core e o Entity Framework Core (SQL Server) no Visual Studio Code já configurado com dotnet: `dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0` e `dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.0`. Ambos podem ser encontrados no repositório do site [Nuget](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer)
6. Após a instalação, é necessário acessar a pasta onde está contida a aplicação, isso pode ser realizado através do comando: `cd: /local/de/armazenamento/do/arquivo`.
7. Em seguida, deve-se restaurar as dependências através do comando: `dotnet restore`.
8. Logo após, podemos compilar a aplicação através do comando build: `dotnet build`.
9. Por fim, para executar a aplicação devemos inserir o comando run: `dotnet run` (caso queira ver a aplicação enquanto edita, pode-se utilizar o comando `dotnet watch run`
10. Se tudo ocorrer perfeitamente, será apresentado uma linha contendo o endereço para acesso, fique atento, pois é a linha que contém a palavra `localhost` e o nome da porta.

## Informações Adicionais:
Entre em contato com o desenvolvedor para qualquer dúvida!!
