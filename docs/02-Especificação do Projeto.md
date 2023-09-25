# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A partir da ideia proposta, foram idealizadas personas fictícias para determinar e tratar os pontos mais relevantes. 

## Personas

<strong>Carlos Henrique tem 23 anos</strong>, trabalha em uma empresa de tecnologia no modelo home office. Ele adora praticar esportes como basquete e faz questão de sempre estar utilizando as novas tecnologias disponíveis ao seu favor. Pedro passa grande parte de seu dia ouvindo músicas seja na academia, praticando esportes, estudando, no trabalho, resumidamente música faz parte de seu dia a dia. Ele se frustra quando não consegue encontrar novas músicas que são semelhantes as de sua playlist e marcadas como preferida e principalmente quando são sugeridos sons diferentes de seu gosto.

<strong>Janaina Silva tem 17 anos</strong>, é estudante do ensino médio e uma ótima fotografa em seu tempo livre. A música faz parte de sua vida, atualmente ela produz músicas de diversos estilos como hobbie e sonha em trabalhar com isso no futuro. Janaína se frustra ao não ter sucesso em ampliar sua playlist com novas músicas cativantes, para ela é necessário encontrar novas referências além de seus gostos conhecidos para se inspirar e ter uma referência para produções futuras.

<strong>Guilherme Ribeiro tem 33 anos</strong>, trabalha como organizador de festas e eventos, ele gosta de ambientes diversificados e com muitas pessoas, adora festejar e também de ler livros digitais em seu tempo livre sozinho, sempre ativo e motivado a fazer coisas novas. Guilherme vê os softwares como uma forma de facilitar sua vida e trabalho e se frusta quando tem dificuldade de encontrar e definir quais estilos musicais estão mais influentes atualmente. Guilherme trabalha com diversos púlicos alvo e dentre estes ele precisa definir qual artistas é o melhor investimento, com isso ele pode se preparar para seus novos eventos. 

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA` |QUERO/PRECISO ... `FUNCIONALIDADE`                                  |PARA ... `MOTIVO/VALOR`                                                                                    |
|---------------------|--------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
|Carlos Henrique      | Encontrar sugestões de músicas conforme seus gostos                | Ampliar as músicas do usuário                                                                             |
|Carlos Henrique      | Encontrar sugestões de playlist conforme seus gostos               | Ampliar as playlists do usuário                                                                           |
|Janaina Silva        | Analisar estatísticas de gêneros músicais preferidos de seu perfil | Analisar quais estilos tem menos visibilidade para encontrar mais referências destes para suas produções  |
|Janaina Silva        | Verificar estatísticas de perfil                                   | Analisar de maneira geral seus gostos e utilização da plataforma                                          |
|Guilherme Ribeiro    | Verificar estatísticas de músicas mais ouvidas por região          | Recolher dados para os próximos eventos que o usuário visa organizar                                      |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

ID | Descrição | Prioridade
---|-----------|-----------
RF-01 | O sistema deve permitir ao usuário cadastrar uma conta | Alta
RF-02 | O sistema deve permitir ao usuário fazer login via email e senha | Alta
RF-03 | O sistema deve permitir ao usuário recuperar sua senha | Média
RF-04 | O sistema deve recomendar músicas ao usuário | Alta
RF-05 | O sistema deve recomendar artistas ao usuário | Média
RF-06 | O sistema deve recomendar playlists e mixes de música ao usuário | Baixa
RF-07 | O sistema deverá mostrar as preferências musicais dos amigos do usuário | Média
RF-08 | O sistema deverá trazer o top 5 músicas mais escutadas pelo usuário em um dado intervalo de tempo | Alta
RF-09 | O sistema deve ser capaz de coletar dados de uso do Spotify | Alta
RF-10 | O sistema deve permitir ao usuário fazer login via rede social | Alta

### Requisitos não Funcionais

ID | Descrição | Prioridade
---|-----------|-----------
RNF-01 | O sistema deve estar disponível 24 horas por dia, 7 dias por semana | Alta
RNF-02 | O sistema deve suportar picos de tráfego sem cair | Alta
RNF-03 | O sistema deve suportar ao menos 1000 usuários simultâneos | Alta
RNF-04 | O sistema deve implementar fontes, cores e tamanhos visando um contraste aceitável e adequação aos padrões W3C de acessibilidade | Alta
RNF-05 | O sistema deve ter interface responsiva para dispositivos móveis | Alta
RNF-06 | As telas do sistema devem ter tempo de carregamento de, no máximo, 5 segundos | Alta
RNF-07 | O sistema se aproveitará de um serviço Database as a Service | Alta
RNF-08 | O sistema deverá ter interface web desenvolvida em React | Alta
RNF-09 | O sistema deve salvar chaves privadas de acesso a APIs em variáveis de ambientes escondidas | Alta
RNF-10 | As informações cadastrais do usuário devem ser de visualização única do administrador do banco de dados | Alta

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

ID | Descrição
---|-----------
RE-01 | O projeto deverá ser entregue no final do semestre letivo (eixo 2).
RE-02 | O backend do projeto deverá ser desenvolvido utilizando C# .NET
RE-03 | O projeto deverá persistir os dados em um banco de dados relacional (SQL Server)
RE-04 | O projeto deverá ser hospedado em plataformas gratuitas e disponibilizado publicamente na internet

## Diagrama de Casos de Uso
![usecase drawio](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t8-espotei/assets/61216649/aa7b1cad-58ca-4d23-aeba-4325a2f2154d)

