# myGameScore
<p>É um projeto web no qual jogadores de basquete podem registrar suas partidas, através do menu "Lancar pontos", inserindo a data da partida e a pontuação, para então acompanhar suas estatísticas através do menu "Ver resultados", no qual poderá ver dados como quantidade de jogos disputados, total de pontos marcados na temporada, média de pontos por jogo, maior e menor pontuação por jogo e quantidade de vezes que bateu o próprio recorde.</p>
<p>Além disso, jogadores podem ver seu histórico de partidas através do menu "Ver partidas", no qual podem também editar ou excluir partidas, e ver uma tabela contendo as 10 maiores pontuações entre todos os players, através do menu "Quadro de pontuações".</p>
<p>Dessa forma, incluindo as opções de "Ver partidas" e "Quadro de pontuações" o jogador não precisa se preocupar em lembrar de todas as suas pontuações quando for analisar suas estatísticas e também pode comparar suas pontuações com as dos demais jogadores, sendo também um incentivo para buscar pontuações maiores, afim de colocar seu nome no topo da lista de maiores pontuações.</p>
<p>Para desenvolvimento do projeto foram utilizadas as tecnologias:</p>
<h2>Front-end:</h2>
<ul>
  <li>Single Page Aplication (SPA) com ReactJS</li>
  <li>Desenvolvimento de componentes de interfaces com Bootstrap</li>
  <li>Consumo de API com Axios</li>
  <li><a href="https://github.com/Thiago-Gonzalez/MyGameScore.Front">Link do repositório do Front-end</a></li>
</ul>
<h2>Back-end:</h2>
<ul>
  <li>Linguagem C#</li>
  <li>.NET Core 6</li>
  <li>Desenvolvimento de API Rest com ASP.NET Core</li>
  <li>Utilização dos padrões arquiteturais Clean Architecture (Camadas API, Application, Core e Infrastructure), Command-Query Responsility Segregation (CQRS) para separar as consultas (Queries) das ações que alteram o estado do sistema (Commands) e Padrão Repository para encapsular o acesso a dados, desacoplando detalhes de implementação através de interfaces.</li>
  <li>Validação de APIs com FluentValidation</li>
  <li>Persistência e acesso à dados com Entity Framework Core e SQL Server</li>
  <li>Autenticação e autorização com Json Web Token (JWT)</li>
  <li>Testes Unitários com xUnit</li>
  <li><a href="https://github.com/Thiago-Gonzalez/MyGameScore.WebServices">Link do repositório do Back-end</a></li>
</ul>
<h2>Instruções para obter o repositório e rodar o projeto:</h2>
<ol>
  <li>Requisitos:</li>
    <ul>
      <li>Ter o Git instalado (<a href="https://git-scm.com/">Clique aqui para baixar</a>)</li>
      <li>Ter o Node instalado (<a href="https://nodejs.org/en/">Clique aqui para instalar</a>)</li>
      <li>Ter a .NET SDK e Runtime instaladas (<a href="https://dotnet.microsoft.com/en-us/download">Clique aqui para instalar</a>)</li>
      <li>Ter o Visual Studio Code (<a href="https://code.visualstudio.com/">Clique aqui para instalar o VSCode</a>) e o Visual Studio (<a href="https://visualstudio.microsoft.com/pt-br/downloads/">Clique aqui para instalar o Visual Studio</a>) instalados</li>
      <li>Ter o SQL Server(<a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads">Clique aqui para instalar</a> - Recomendado instalar o Express) e o SQL Sever Management Studio (<a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads">Clique aqui para instalar</a> - Para visualizar as tabelas (Opcional)) instalados</li>
    </ul>
  <li>Criar uma pasta no local desejado para receber os repositórios do projeto</li>
  <li>Abrir um terminal na pasta selecionada (abra a pasta no explorador de arquivos, clique com o botão direito do mouse dentro dela e procure a opção de abrir terminal ou abra o terminal e digite o comando $ cd pathDaPasta)</li>
  <li>No terminal, dentro da pasta específica para receber os repositórios, insira o comando $ git clone https://github.com/Thiago-Gonzalez/MyGameScore.WebServices para clonar o repositório do back-end</li>
  <li>Em seguida, ainda na mesma pasta, insira o comando $ git clone https://github.com/Thiago-Gonzalez/MyGameScore.Front para clonar o projeto do front-end</li>
  <li>Configurações para rodar o projeto do Front-end:</li>
      <p>Abra o terminal na pasta do projeto do front-end (através do VSCode ou via terminal) e insira o seguinte comando $ npm install para instalar as dependências do projeto.</p>
      <p>Para rodar o projeto, insira o seguinte comando $ npm start e então o projeto deve ser aberto na url "https://localhost:3000"</p>
  <li>Configurações para rodar o projeto do Back-end:</li>
      <p>Para abrir o projeto do back-end, abra a pasta do projeto no exporador de arquivos e abra o arquivo solução (.sln)</p>
      <p>No terminal, inserir o seguinte comando $ dotnet tool install --global dotnet-ef para instalar o EF Core globalmente</p>
      <p>Em seguida, com o projeto aberto no terminal na pasta MyGameScore.Infrastructre, inserir o seguinte comando (ex: MyGameScore.WebServices/MyGameScore.Infrastructure (main)) $ dotnet ef database update -s ../MyGameScore.API/MyGameScore.API.csproj para aplicar as migrations no banco</p>
      <p>Nota: Caso ocorra algum problema com o comando anterior, verifique se está na pasta correta, pois isso inflencia no path do csproj da camada API passado como parâmetro.</p>
      <p>Por fim, rode a aplicação pelo Visual Studio clicando no botão com ícone play de cor verde "MyGameScore.API"</p>
  <li>Com os projetos do back-end e front-end rodando, já é possível realizar requisições para a api através do swagger ou através do front</li>
  <li>OBS.: Caso ainda haja algum problema de na execução do back-end, tente executar os comandos $ dotnet restore / $ dotnet build</li>
</ol>
<h2>Testando o back-end via Swagger (https://localhost:9000/swagger/index.html (ou qualquer outra plataforma de testes de API)):</h2>
<ol>
  <li>Antes de qualquer coisa, é necessário criar uma conta: realize uma requisição http post para a rota api/players e informe seu nome, email e uma senha contendo pelo menos 8 dígitos, sendo pelos menos um caractere especial, uma letra maiúscula, uma minúscula e um número</li>
  <li>Em seguida, realize o login através do método http put na rota api/players/login, informando seu email e senha, dessa forma será gerado um token, copie-o</li>
  <li>Por fim, para finalizar a autenticação, no Swagger, clique no menu "Authorize" localizado na parte superior direita da página e em "Value" preencha com "Bearer coleAquiOToeken" (sem aspas, apenas para exemplificar => Bearer token), depois clique em Authorize</li>
  <li>Pronto, agora você já está autenticado e já pode realizar quaisquer requisições nas demais rotas da api</li>
</ol>
<h2>Nota: Rodando o back-end em ambiente Linux (necessário versão com suporte ao .NET Core 6 e SQL Server - recomendado Ubuntu 20.04):</h2>
<ui>
  <li>Para rodar o back-end em ambiente linux, é necessário satisfazer os requisitos citados anteriormente (.NET SDK e Runtime, SQL Server e como uma opção ao SQL Server Management Studio, tem-se o Azure Data Studio (<a href="https://docs.microsoft.com/pt-br/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver16">Acesse aqui o guia de instalação</a>)</li>
  <li>Para acessar o banco da aplicação com o Azure Data Studio, deve-se utilizar as credenciais do sql login, criadas ao instalar o sql server, e preencha os seguintes campos ao criar a nova conexão:</li>
    <p>Connection Type: Microsoft SQL Server</p>
    <p><Server: localhost/p>
    <p>Authentication type: SQL Login</p>
    <p>User name: sa</p>
    <p>Password: insira sua senha do sql login</p>
    <p>Clique em Connect</p>
  <li>OBS.: Antes de aplicar as migrations, altere a connectionString no arquivo appsettings.json, substituindo por:</li>
    <p>"ConnectionStrings": {
      "MyGameScoreCs": "Server=localhost;Database=MyGameScore;User Id=sa;Password=suaSenhaDoSQLLogin"
      },
    </p>
  <li>Por fim, realize o apply das migrations ($ dotnet ef database update -s ../MyGameScore.API/MyGameScore.API.csproj)</li>
  <li>Execute a aplicação com $ dotnet run (dentro da pasta MyGameScore.API)</li>
</ui>
  <h2>Preview:</h2>
  </h4>Swagger:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187813320-cb09f630-10ab-4168-a6eb-01d8ccc194ad.png"/>
  
  <h4>Lançar Pontos:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187813563-5c4f95a3-fe6d-4d71-a47c-03f225d365d1.png" />
  
  <h4>Suas Partidas:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187814038-19fdbb3c-7700-444b-a412-7091a3697ea0.png" />
  
  <h4>Ver Resultados:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187814078-3cee5670-d9ad-42c1-aefc-0ba4302a5c50.png" />
  
  <h4>Quadro de Pontuações:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187814146-02d2a1ca-ded5-4f0d-aee1-d785aa41db6e.png" />
  
  <h4>Login:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187813795-0c39b25b-3fbc-492f-8c1a-f4de682f40dd.png" />
  
  <h4>Cadastro:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187813832-19231db9-370a-49c1-b408-43a604f5cbc3.png" />
  
  <h4>NotFound:</h4>
  <img src="https://user-images.githubusercontent.com/80121288/187813966-fbc6aa44-9ec1-4388-8d0f-a544df5d7307.png" />
  
<p align="center">© Thiago González</p>
