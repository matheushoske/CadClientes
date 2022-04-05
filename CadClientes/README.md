
# CADASTRO DE CLIENTES (SOLID) CONSUMINDO API REST .NET MVC
 
 <h2>Arquitetura Utilizada:</h2>
 
<h3>
 
 -[POO]()
 
 -[Aplicção de conceitos SOLID]()
 
 -[Design Patterns]()
 
 -[Injeção de dependências]()</h3>
 
--------------------------------------------

## Projeto cadastro de clientes

Desenvolvido em C# utilizando .NET Core 5.0 com Windows Forms,
uma ferramenta para o cadastro e consulta de clientes consumindo a API 
https://viacep.com.br/ para a busca de endereços e consumindo também a
API "ConsultaAPI", desenvolvida em asp.net Core para a consulta no banco 
de dados em MySQL.

## Projeto API

Foi desenvolvida a API de consulta e inserção de clientes em asp.net core,
utilizando 2 métodos GET ( consulta de clientes por id e consulta de ultimo
cliente cadastrado) e 1 método POST para a inserção de um novo cliente no banco
de dados.

No desenvolvimento da API, foi utilizado o MySQL.
Não foi utilizado nenhum framework de ORM como o Entity Framework (Em breve).
Também foi utilizado a Documentação Swagger para facilitar os testes de requisição.
Acesso swagger em localhost: 
https://localhost:44382/swagger/


## INSTALANDO MYSQL NO SERVIDOR DE API
--------------------------------------
Para o funcionamento correto da API, será necessário realizar a instalação e
configuração do banco de dados MySQL
 * Instalar serviço do MySQL
 Para a instalação do serviço do MySQL será necessário primeiramente executar
 o instalador MySQL64bits.exe :
   https://1drv.ms/u/s!Ajl_kq6K-uvNyEWbAadJxrqgeioF?e=1SX6nA

 * Instalar o conector do MySQL para .NET
 Execute o instalador "mysql-connector-net.msi" :
   https://1drv.ms/u/s!Ajl_kq6K-uvNyEeYPxFbMN2iDTwI?e=PBUcec

 * Execute as queries para criação do Banco
 Para criar o banco de dados, as tabelas e os usuários execute o
 script "sql-create.sql":
   https://1drv.ms/u/s!Ajl_kq6K-uvNyEYfqIUhHCcsYddG?e=XMjav9
 será realizado a criação do usuário 'rede' com senha 'rede'

 ## UTILIZAÇÃO DA APLICAÇÃO
 --------------------------
 Após executar e testar a API no servidor, caso esteja funcionando corretamente,
 execute o projeto CadClientes.
Ao abrir, caso não exiba nenhuma mensagem de falha de comunicação com a API, o
cadastro de clientes poderá ser realizado normalmente.
Durante o cadastro do cliente, você pode inserir um CEP e buscar por seu endereço
clicando no botaão buscar.
Após o cadastro de algum cliente, será possível consulta-lo, inserindo seu id e 
clicando no botão pesquisar ID.

Caso depare com alguma mensagem de falha de comunicação com a API, acesse as configurações
e configure a URI da API corretamente

## COPYRIGHT / CONTATOS
-------------------------
Programa e API desenvolvidos por Matheus Hoske Aguiar
Github: https://github.com/matheushoske
Linkedin: https://www.linkedin.com/in/matheus-hoske/
Contato: matheushoske@gmail.com - (31) 98346-9428
Copyright @ Matheus Hoske - 2021
Todos os direitos reservados*

