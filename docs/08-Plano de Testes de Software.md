# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Plano de Teste de Software

1. Teste de Login e Cadastro

Testar campos de entrada: Verificar se os campos aceitam os formatos corretos (e-mail, senha).
Testar validação de e-mail e senha: Verificar se o sistema valida corretamente e-mail e senha.
Testar contador de tentativas de login: Certificar que o sistema bloqueia o usuário após três tentativas falhas.
Testar fluxo de cadastro: Verificar se todos os campos (e-mail, nome, idade, senha) são obrigatórios e se há validação para cada um.
Testar resposta a cadastros duplicados: Garantir que o sistema avisa quando o e-mail já está em uso.

2. Teste de Criação de Orçamento

Testar inserção de valores de receitas e despesas: Garantir que os campos aceitem apenas valores numéricos.
Testar cálculo do saldo: Verificar se o saldo é calculado corretamente como receitas menos despesas.
Testar exibição dos resultados: Certificar que os totais e saldo são exibidos corretamente.

3. Teste de Investimentos

Testar entrada de dados do investimento: Verificar se os campos para nome, tipo, valor, taxa, tempo e imposto estão validados corretamente.
Testar cálculos de rendimento e imposto: Garantir que os cálculos estão corretos e consistentes com as entradas.
Testar exibição dos resultados do investimento: Verificar se os resultados são mostrados corretamente.

4. Teste de Gerenciamento de Metas Financeiras

Testar criação e atualização de metas: Verificar a entrada de dados e atualização de valores.
Testar exclusão de meta ao atingir o objetivo: Certificar que a meta é excluída automaticamente quando o valor alvo é atingido.

5. Teste de Exclusão de Conta

Testar processo de exclusão: Verificar se o usuário pode excluir sua conta facilmente.
Testar limpeza de dados após exclusão: Garantir que todos os dados do usuário são removidos do sistema após a exclusão.


Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |

 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
