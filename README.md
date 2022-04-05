# CadClientes

<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  
  # CADASTRO DE CLIENTES (SOLID) CONSUMINDO API REST .NET MVC
  
  <a href="https://github.com/matheushoske/CadClientes">
    <img src="https://github.com/matheushoske/CadClientes/blob/main/images/program.png" alt="Logo" width="200" height="200">
  </a>



  <p align="center">
  Projeto desenvolvido em C#, utilizando .NET Core 5.0 com Windows Forms,
uma ferramenta para o cadastro e consulta de clientes consumindo a API 
https://viacep.com.br/ para a busca de endereços e consumindo também a
API <a href="">ConsultaAPI</a>, desenvolvida em ASP.NET Core para a consulta no banco 
de dados em MySQL.
    <br />
    <a href="https://github.com/matheushoske/CadClientes"><strong>Explore »</strong></a>
    <br />
    <br />
    <a href="https://github.com/matheushoske/CadClientes">Ver Demo</a>
    ·
    <a href="https://github.com/matheushoske/CadClientes/issues">Report Bug</a>
    ·
    <a href="https://github.com/matheushoske/CadClientes/issues">Requisitar Melhoria</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">Sobre o projeto</a>
      <ul>
        <li><a href="#built-with">Liguagens utilizadas</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>


 
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



### INSTALANDO O PROJETO DA APLICAÇÃO

1. Instale e configure a API CadClientesAPI seguindo a documentação [https://github.com/matheushoske/CadClientesAPI](https://github.com/matheushoske/CadClientesAPI)
2. Clone o repository
   ```sh
   git clone https://github.com/matheushoske/CadClientes.git
   ```
3. Abra o CadClientes.sln e execute o projeto

4. Configure o endereço da API configurada clicando no botão config 
 <img src="https://github.com/matheushoske/CadClientes/blob/main/images/ConfigAPI.png" alt="ConfigAPI">


<p align="right">(<a href="#top">back to top</a>)</p>


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
 
## COPYRIGHT / CONTATOS
-------------------------
Programa e API desenvolvidos por Matheus Hoske Aguiar

[![Github][github-shield]]

[![LinkedIn][linkedin-shield]][linkedin-url]

Contato: matheushoske@gmail.com 

Copyright @ Matheus Hoske - 2021

Todos os direitos reservados*

## License

Distributed under the MIT License. See `LICENSE.txt` for more information.



<!-- USAGE EXAMPLES 
## Usage

Use this space to show useful examples of how a project can be used. Additional screenshots, code examples and demos work well in this space. You may also link to more resources.-->

<p align="right">(<a href="#top">Voltar ao topo</a>)</p>



<!-- ROADMAP 
## Roadmap

See the [open issues](https://github.com/matheushoske/CadClientes/issues) for a full list of proposed features (and known issues).



<!-- CONTRIBUTING 
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>-->



<!-- LICENSE -->





<!-- CONTACT -->




<!-- ACKNOWLEDGMENTS 
## Acknowledgments

* []()
* []()
* []()

<p align="right">(<a href="#top">back to top</a>)</p>-->



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/matheushoske/CadClientes.svg?style=for-the-badge
[contributors-url]: https://github.com/matheushoske/CadClientes/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/matheushoske/CadClientes.svg?style=for-the-badge
[forks-url]: https://github.com/matheushoske/CadClientes/network/members
[stars-shield]: https://img.shields.io/github/stars/matheushoske/CadClientes.svg?style=for-the-badge
[stars-url]: https://github.com/matheushoske/CadClientes/stargazers
[issues-shield]: https://img.shields.io/github/issues/matheushoske/CadClientes.svg?style=for-the-badge
[issues-url]: https://github.com/matheushoske/CadClientes/issues
[license-shield]: https://img.shields.io/github/license/matheushoske/CadClientes.svg?style=for-the-badge
[license-url]: https://github.com/matheushoske/CadClientes/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[github-shield]: https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white
[github-link]: https://github.com/matheushoske
[linkedin-url]: https://www.linkedin.com/in/matheus-hoske/
[product-screenshot]: images/program.png
