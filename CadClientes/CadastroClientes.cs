using System;
using System.Windows.Forms;
using CadClientes.Service;
using CadClientes.Model;
using CadClientes.Repository;
using CadClientes.DAO;
using CadClientes.Interfaces;
using System.Net.Http;

// <copyright file="CadastroClientes.cs" company="matheushoske">
// Copyright (c) 2022 All Rights Reserved. Para a reutilização do código 
// o Copyright será obrigatório
// </copyright>
// <author>Matheus Hoske Aguiar</author>
// <date>05/04/2022 07:48:58 AM </date>
// <summary>Programa desenvolvido para simular o cadastro de clientes via API, e
// consulta de CEPs com a API viacep. Arquitetura baseada em POO, SOLID e
// Design Patterns.
// </summary>
//---------------------------------------------------------------------
// Saiba mais sobre o projeto: https://github.com/matheushoske/CadClientes
// Projeto aberto à contribuições

namespace CadClientes
{
    public partial class CadastroClientes : Form
    {
        private readonly IClienteService _clienteService;
        private readonly ICepService _cepService;
        private readonly IFormConfig _formConfig;
        public CadastroClientes(IClienteService clienteService, ICepService cepService, IFormConfig formConfig)
        {
            _formConfig = formConfig;
            _clienteService = clienteService;
            _cepService = cepService;
            InitializeComponent();
        }
        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            if (_clienteService.TestarComunicacao())
                lblStatusAPI.Text = "";
            CarregaCampos();

            dtpNasc.Format = DateTimePickerFormat.Custom;
            dtpNasc.CustomFormat = "dd/MM/yyyy";
            dtpNasc.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtCep.Text.Length == 8)
            {
                
                Cep cepDados = _cepService.BuscarCep(txtCep.Text);
                if (cepDados != null)
                {
                    txtLogradouro.Text = cepDados.logradouro;
                    txtEstado.Text = cepDados.uf;
                    txtCidade.Text = cepDados.localidade;
                }
                else
                {
                    MessageBox.Show("Não foi possível encontrar o CEP informado!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("FORMATO DO CEP INCORRETO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))//VALIDA A EXISTÊNCIA DE LETRAS NO Textbox
            {
                e.Handled = true;
            }
            else if (txtCep.Text.Length >= 8 && !char.IsControl(e.KeyChar))//VALIDA A QUANTIDADE DE DIGITOS
            {
                e.Handled = true;
            }
            else if (e.KeyChar.ToString() == "\r") //BUSCA CEP CASO O CLICK SEJA ENTER
            {
                btnBuscar_Click(sender, new());
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtCep.Text != "" && txtCidade.Text != "" && txtLogradouro.Text != "" && txtEstado.Text != "")
            {
                CadastrarCliente();
            }
            else 
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void CadastrarCliente() 
        {
            Cliente cli = new() 
            { 
                nome = txtNome.Text,
                dt_nasc = dtpNasc.Value,
                cep = long.Parse(txtCep.Text),
                cidade = txtCidade.Text,
                logradouro = txtLogradouro.Text,
                estado = txtEstado.Text
            };
            _clienteService.AdicionarCliente(cli);
            MessageBox.Show("Cliente "+cli.nome+" cadastrado com sucesso!", "Cliente cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();

        }

        private void LimparCampos() 
        {
            
            txtNome.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtLogradouro.Text = "";
            txtEstado.Text = "";
            CarregaCampos();
        }

        private void CarregaCampos() 
        {
            txtID.Text = _clienteService.RetornaUltimoClienteid(1).ToString();
        }

        

        private void btnConfig_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            _formConfig.Closed += (s, args) => this.Close();
            _formConfig.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cli = _clienteService.BuscarCliente((int)nudID.Value);
            if (cli != null)
                MessageBox.Show("Nome: " + cli.nome + "\nData de nascimento: " + cli.dt_nasc.ToString("dd/MM/yyyy") + "\nCep: " + cli.cep + "\nCidade: " + cli.cidade + "\nEstado: " + cli.estado + "\nLogradouro: " + cli.logradouro + "", "Informações do cliente: " + nudID.Value + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
                MessageBox.Show("Não foi possível encontrar o cliente!", "Informações do cliente: " + nudID.Value + "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

           
        }


    }
}
