# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Persona 1: Marina Santos
Idade: 28 anos
Profissão: Estudante de Direito
Situação Familiar: Solteira, sem filhos
Descrição: Marina é uma estudante universitária no último ano de Direito. Ela busca uma aplicação simples e intuitiva para ajudá-la a equilibrar seus gastos com mensalidades, materiais de estudo e despesas pessoais. Como tem pouco conhecimento sobre finanças, ela valoriza a facilidade de uso e a acessibilidade da aplicação.

Persona 2: João Silva
Idade: 35 anos
Profissão: Engenheiro Civil
Situação Familiar: Casado, com um filho pequeno
Descrição: João é um engenheiro civil com conhecimento intermediário em finanças. Ele deseja uma ferramenta que o ajude a acompanhar seus gastos, planejar despesas familiares e investir para o futuro. João valoriza a confiabilidade e eficiência da aplicação.

Persona 3: Ana Silva
Idade: 30 anos
Profissão: Analista de Marketing
Situação Familiar: Casada, com um filho de 3 anos
Descrição: Ana busca equilibrar sua carreira com responsabilidades familiares. Com algum conhecimento em finanças, ela quer uma ferramenta para organizar gastos, criar orçamentos realistas e acompanhar o crescimento de seu patrimônio. Ana valoriza a praticidade e a segurança na utilização da aplicação.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Eu como usuário    | quero que o aplicativo seja fácil de usar e intuitivo| para facilitar o gerenciamento de minhas finanças |
| Eu como usuário    | desejo ver um resumo de minhas finanças, incluindo despesas e renda  | para entender melhor para onde meu dinheiro está indo  |
| Eu como usuário    | quero ver um gráfico de minhas despesas mensais | para entender melhor para onde meu dinheiro está indo|
| Eu como usuário    | quero ver um gráfico de minha renda versus minhas despesas ao longo do tempo |para avaliar minha saúde financeira geral  |
| Eu como usuário    | quero poder inserir os lucros dos meus últimos investimentos|para poder ver o panorama das minhas ações |
| Eu como usuário    | quero aprender sobre os fundos de investimentos com exemplos reais | para que eu possa ampliar meus conhecimentos e tenha segurança de aplicar na prática |
| Eu como usuário    | entender como está dividido meus gastos de forma clara | saber como organizar minha vida nos próximos meses|
| Eu como usuário    | visualizar barras de progresso das minhas metas| entender como está o andamento dos meus objetivos|
| Eu como usuário    | aprender o básico de educação financeira | direcionar melhor meus gastos |
| Eu como usuário    | desejo que o aplicativo seja seguro e proteja minhas informações financeiras | para evitar fraudes e roubo de identidade                              |
| Eu como usuário    | quero selecionar meu perfil financeiro durante o processo de criação da conta | para ter uma experiência personalizada e conteúdo adaptado às minhas necessidades  |
| Eu como usuário    | quero receber notificações sobre vencimento de contas e metas financeiras | para não perder prazos e manter minha organização financeira |
| Eu como usuário    | desejo poder exportar relatórios das minhas finanças | para fazer análises mais detalhadas e planejamento futuro |
| Eu como usuário    | quero poder cadastrar diferentes fontes de renda e despesas recorrentes | para ter uma visão abrangente de minha situação financeira |
| Eu como usuário    | desejo um sistema de suporte ao cliente eficiente | para esclarecer dúvidas e resolver problemas rapidamente |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

| ID    | Descrição do Requisito                                               | Prioridade |
|-------|-----------------------------------------------------------------------|------------|
| RF-001| A aplicação deve permitir que o usuário crie uma conta                | ALTA       |
| RF-002| A aplicação deve permitir que o usuário faça login utilizando suas credenciais | ALTA |
| RF-003| A aplicação deve permitir que o usuário adicione suas despesas e receitas | ALTA      |
| RF-004| A aplicação deve permitir que o usuário visualize um resumo de suas finanças, incluindo despesas e receitas | ALTA |
| RF-005| A aplicação deve permitir que o usuário visualize gráficos de suas despesas e receitas ao longo do tempo | ALTA |
| RF-006| A aplicação deve permitir que o usuário defina metas financeiras       | MÉDIA      |
| RF-007| A aplicação deve enviar notificações sobre vencimento de contas e metas financeiras | MÉDIA |
| RF-008| A aplicação deve permitir que o usuário exporte relatórios de suas finanças | BAIXA    |

### Requisitos não Funcionais

| ID     | Descrição do Requisito                                                  | Prioridade |
|--------|--------------------------------------------------------------------------|------------|
| RNF-001| A aplicação deve ser responsiva                                         | ALTA       |
| RNF-002| A aplicação deve processar requisições do usuário em no máximo 3 segundos | ALTA       |
| RNF-003| A aplicação deve garantir a segurança dos dados do usuário               | MÉDIA      |
| RNF-004| A aplicação deve ser compatível com os principais navegadores web 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
| 01 | O projeto deve ser desenvolvido utilizando tecnologias web, sem a utilização de tecnologias desktop |
| 02 | A aplicação deve ser compatível com os principais navegadores web, incluindo Chrome, Firefox, Safari e Edge |
|03| O projeto deverá ser implementado utilizando a linguagem de programação C# |
| 04 | O acesso à aplicação deve ser restrito a usuários cadastrados |

## Diagrama de Casos de Uso

<p align="center">
  <img src="docs\img\diagrama-de-casos-de-uso.png" alt="economus-logo" width="180px" height="180px"/>
</p>