# myGameScore
<p>É um projeto web no qual jogadores de basquete podem registrar suas partidas da temporada, através do menu "Lancar pontos", inserindo a data da partida e a pontuação, para então acompanhar suas estatatísticas através do menu "Ver resultados", no qual poderá ver dados como quantidade de jogos disputados, total de pontos marcados na temporada, média de pontos por jogo, maior e menor pontuação por jogo e quantidade de vezes que bateu o próprio recorde.</p>
<p>Além disso, jogadores podem ver seu histórico de partidas através do menu "Ver partidas" e ver uma tabela contendo as maiores pontuações já registradas, através do menu "Quadro de pontuações".</p>
<p>Dessa forma, incluindo as opções de "Ver partidas" e "Quadro de pontuações" o jogador não precisa se preocupar em lembras de todas as suas pontuações quando for analisar suas estatísticas e também pode comparar suas pontuações com as dos demais jogadores, sendo também um incentivo para buscar pontuações maiores, afim de colocar seu nome no topo da lista de maiores pontuações.</p>
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
  <li>Utilização dos padrões arquiteturais Clean Architecture (Camadas API, Application, Core e Infrastructure), Command-Query Responsility Segregation (CQRS) para separa as consultas (Queries) das ações que alterar o estado do sistema (Commands) e Padrão Repository para encapsular o acesso a dados, desacoplando detalhes de implementação através de interfaces.</li>
  <li>Validação de APIs com FluentValidation</li>
  <li>Persistência de dados com Entity Framework Core e SQL Server</li>
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
  <li>Abrir um terminal na pasta selecionada (abra a pasta no explorador de arquivos, clique com o botão direito do mouse dentro dela e procure a opção de abrir terminal ou abra o terminal e digite o comando $ cd pathDapagina)</li>
  <li>No terminal, dentro da pasta específica para receber os repositórios, insira o comando $ git clone https://github.com/Thiago-Gonzalez/MyGameScore.WebServices para clonar o repositório do back-end</li>
  <li>Em seguida, ainda na mesma pasta, insira o comando $ git clone https://github.com/Thiago-Gonzalez/MyGameScore.Front para clonar o projeto do front-end</li>
  <li>Configurações para rodar o projeto do Front-end:</li>
      <p>Abra o terminal na pasta do projeto do front-end (através do VSCode ou via terminal) e insira o seguinte comando $ npm install para instalar as dependências do projeto.</p>
      <p>Para rodar o projeto, insira o seguinte comando $ npm start e então o projeto deve ser aberto na ulr "https://localhost:3000"</p>
      <p>OBS.: Caso ocorra algum problema com o comando $ npm install utilizado anteriormente, tente verificar a versão do seu npm ou verificar se o react está instalado</p>
  <li>Configurações para rodar o projeto do Back-end:</li>
      <p>Para abrir o projeto do back-end, abra a pasta do projeto no exporador de arquivos e abra o arquivo solução (.sln)</p>
      <p>No terminal, inserir o seguinte comando $ dotnet tool install --global dotnet-ef para instalar o EF Core globalmente</p>
      <p>Em seguida, com o projeto aberto no terminal na pasta MyGameScore.Infrastructre, inserir o seguinte comando (ex: MyGameScore.WebServices/MyGameScore.Infrastructure (main)) $ dotnet ef database update -s ../MyGameScore.API/MyGameScore.API.csproj para aplicar as migrations no banco</p>
      <p>Nota: Caso ocorra algum problema com o comando anterior, verifique se está na pasta correta, pois isso inflencia no path do csproj da camada API passado como parâmetro.</p>
      <p>Por fim, rode a aplicação pelo Visual Studio clicando no botão com ícone play de cor verde "MyGameScore.API"</p>
  <li>Com os projetos do back-end e front-end rodando, já é possível realizar requisições para a api através do swagger ou através do front</li>
  <li>OBS.: Caso ainda haja algum problema de conexão no back-end, tente realizar a adição dos pacotes:</li>
      <p>\MyGameScore.WebServices\MyGameScore.Infrastructure> $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer</p>
      <p>\MyGameScore.WebServices\MyGameScore.Infrastructure> $ dotnet add package EntityFrameworkCore.Tools</p>
      <p>\MyGameScore.WebServices\MyGameScore.API> $ dotnet add package Microsoft.EntityFrameworkCore.SqlServer</p>
      <p>\MyGameScore.WebServices\MyGameScore.API> $ dotnet add package EntityFrameworkCore.Tools</p>
</ol>

<p>OBS.: Para o desenvolvimento do projeto, meus maiores desafios foram com o Front-end, no qual tive problemas com redirecionamento de rotas, devido a isso, o Front ainda se encontra com alguns problemas, mas com um pouco de paciência, poderá tirar um bom proveito!</p>
