?
## CADASTRO DE CLIENTES (SOLID) - CONSUMINDO API REST .NET MVC
 
 Arquitetura Utilizada
 
 -POO
 -APlic��o de conceitos SOLID
 -Design Patterns
 -Inje��o de depend�ncias
--------------------------------------------

## Projeto cadastro de clientes

Foi desenvolvido em Windows forms / C# utilizando .NET Framework 5.0,
uma ferramenta para o cadastro e consulta de clientes consumindo a API 
https://viacep.com.br/ para a busca de endere�os e consumindo tamb�m a
API "ConsultaAPI", desenvolvida em asp.net Core para a consulta no banco 
de dados em MySQL.

## Projeto API

Foi desenvolvida a API de consulta e inser��o de clientes em asp.net core,
utilizando 2 m�todos GET ( consulta de clientes por id e consulta de ultimo
cliente cadastrado) e 1 m�todo POST para a inser��o de um novo cliente no banco
de dados.

No desenvolvimento da API, foi utilizado o MySQL.
N�o foi utilizado nenhum framework de ORM como o Entity Framework (Em breve).
Tamb�m foi utilizado a Documenta��o Swagger para facilitar os testes de requisi��o.
Acesso swagger em localhost: 
https://localhost:44382/swagger/


## INSTALANDO MYSQL NO SERVIDOR DE API
--------------------------------------
Para o funcionamento correto da API, ser� necess�rio realizar a instala��o e
configura��o do banco de dados MySQL
 * Instalar servi�o do MySQL
 Para a instala��o do servi�o do MySQL ser� necess�rio primeiramente executar
 o instalador MySQL64bits.exe :
   https://1drv.ms/u/s!Ajl_kq6K-uvNyEWbAadJxrqgeioF?e=1SX6nA

 * Instalar o conector do MySQL para .NET
 Execute o instalador "mysql-connector-net.msi" :
   https://1drv.ms/u/s!Ajl_kq6K-uvNyEeYPxFbMN2iDTwI?e=PBUcec

 * Execute as queries para cria��o do Banco
 Para criar o banco de dados, as tabelas e os usu�rios execute o
 script "sql-create.sql":
   https://1drv.ms/u/s!Ajl_kq6K-uvNyEYfqIUhHCcsYddG?e=XMjav9
 ser� realizado a cria��o do usu�rio 'rede' com senha 'rede'

 ## UTILIZA��O DA APLICA��O
 --------------------------
 Ap�s executar e testar a API no servidor, caso esteja funcionando corretamente,
 execute o projeto CadClientes.
Ao abrir, caso n�o exiba nenhuma mensagem de falha de comunica��o com a API, o
cadastro de clientes poder� ser realizado normalmente.
Durante o cadastro do cliente, voc� pode inserir um CEP e buscar por seu endere�o
clicando no bota�o buscar.
Ap�s o cadastro de algum cliente, ser� poss�vel consulta-lo, inserindo seu id e 
clicando no bot�o pesquisar ID.

Caso depare com alguma mensagem de falha de comunica��o com a API, acesse as configura��es
e configure a URI da API corretamente

## COPYRIGHT / CONTATOS
-------------------------
Programa e API desenvolvidos por Matheus Hoske Aguiar
Github: https://github.com/matheushoske
Linkedin: https://www.linkedin.com/in/matheus-hoske/
Contato: matheushoske@gmail.com - (31) 98346-9428
Copyright @ Matheus Hoske - 2021
Todos os direitos reservados*

