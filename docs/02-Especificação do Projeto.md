# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

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

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deverá possuir sistema de login OAuth | ALTA | 
|RF-002| O site deverá ter integração com a API do Spotify | ALTA |
|RF-003| O site deverá trazer recomendações de músicas ao usuário, baseadas nas preferências do mesmo | ALTA |
|RF-004| O site deverá trazer métricas a respeito dos gêneros e tipos de músicas preferenciais do usuário | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O frontend deve ser publicado em um ambiente acessível publicamente na Internet | ALTA | 
|RNF-002| O backend deve ser ter seus endpoints disponibilizados em um ambiente acessível publicamente na Internet | MÉDIA |
|RNF-003| O sistema utilizará uma plataforma de Database as a Service em cloud | MÉDIA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo (eixo 2) |
|02| O projeto deverá ser feito utilizando os frameworks da linguagem C# no backend |
|03| O projeto deverá persistir os dados utilizando um banco de dados relacional


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
