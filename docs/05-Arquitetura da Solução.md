# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução.

## Diagrama de Componentes
![ArquiteturaComponentes drawio](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t8-espotei/assets/72924198/1e1c9a26-ca51-47ff-95dd-c991571eecc4)


## Diagrama de Classes & Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
Para mais informações, consulte o microfundamento "Modelagem de Dados".

![ArquiteturaDatabaseEspotei  drawio](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t8-espotei/assets/72924198/e275b79d-2fae-4e17-80cd-2caf8934fb2c)


## Tecnologias Utilizadas

Nesse projeto será utilizado, para o desenvolvimento do front-end, o ecossistema Javascript, mais especificamente, a biblioteca do React.js, uma biblioteca robusta voltada para o desenvolvimento WEB. Para persistência dos dados que forem necessários, dados de login e sessão de usuário, dados de músicas, artistas e recomendações avaliações, dentre outros, será utilizado o sistema de Localstorage do navegador, onde dados podem ser armazenados em formato de texto simples ou JSON. A hospedagem do front-end será feita através da plataforma Vercel, esta possui um plano de hospedagem gratuito e amplamente utilizado.

Para o desenvolvimento do back-end utilizaremos os frameworks .Net Core e o Asp Net Core. Ambos são frameworks cross-platform (MAC, Linux, Windows) utilizados para desenvolvimento de aplicações web e aplicações desktop. O Asp Net Core será utilizado para as tratativas da API e da web, enquanto o .NET e suas funcionalidades seram utilizados para realizar a comunicação com a database, manipulação de dados e gerenciamento de processos internos.

## Hospedagem

O site utiliza a plataforma da Vercel como ambiente de hospedagem do site do projeto.
A publicação do site na Vercel é integrada com o repositório de código no GitHub, de modo que ações de push para a branch main disparam eventos de deploy automáticos.
