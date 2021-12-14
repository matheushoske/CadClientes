using System;
using System.Windows.Forms;
using CadClientes.Service;
using CadClientes.Model;
using CadClientes.Util;

namespace CadClientes
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            Variaveis.URI = "https://localhost:44382/api/Clientes";
            
            InitializeComponent();
            if (RotinasGerais.TestarApi()) 
            { 
                lblStatusAPI.Text = ""; 
            }
            CarregaCampos();
            
            dtpNasc.Format = DateTimePickerFormat.Custom;
            dtpNasc.CustomFormat = "dd/MM/yyyy";
            dtpNasc.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtCep.Text.Length == 8)
            {
                ServiceCep ncep = new ServiceCep();
                Cep cepDados = ncep.BuscaCep(txtCep.Text);
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
                MessageBox.Show("CEP INCORRETO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                EventArgs e2 = new EventArgs();
                btnBuscar_Click(sender, e2);
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
            Cliente cli = new Cliente();
            ServiceCliente servCliente = new ServiceCliente();
            cli.nome = txtNome.Text;
            cli.dt_nasc = dtpNasc.Value;
            cli.cep = int.Parse(txtCep.Text);
            cli.cidade = txtCidade.Text;
            cli.logradouro = txtLogradouro.Text;
            cli.estado = txtEstado.Text;

            servCliente.InsereCliente(cli);
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
            ServiceCliente servCliente = new ServiceCliente();
            Cliente cli = new Cliente();
            txtID.Text = servCliente.RetornaUltimoClienteid(1).ToString();
            
        }

        

        private void btnConfig_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            var frmConfig = new Config();
            frmConfig.Closed += (s, args) => this.Close();
            frmConfig.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            ServiceCliente servCliente = new ServiceCliente();
           cli = servCliente.BuscaCliente((int)nudID.Value);
            if (cli != null)
            {
                MessageBox.Show("Nome: " + cli.nome + "\nData de nascimento: " + cli.dt_nasc.ToString("dd/MM/yyyy") + "\nCep: " + cli.cep + "\nCidade: " + cli.cidade + "\nEstado: " + cli.estado + "\nLogradouro: " + cli.logradouro + "", "Informações do cliente: " + nudID.Value + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Não foi possível encontrar o cliente!", "Informações do cliente: " + nudID.Value + "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

           
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
