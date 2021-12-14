using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadClientes.Util;

namespace CadClientes
{
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();
            txtURI.Text = Variaveis.URI;
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (RotinasGerais.TestarApi())
            {
                MessageBox.Show("Conexão realizada com sucesso!","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Não foi possível estabelecer a conexão com a API, verifique!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Variaveis.URI = txtURI.Text;
            //CadastroClientes frmCC = new CadastroClientes();
           // frmCC.ShowDialog();
            this.Hide();
            var frmCC = new CadastroClientes();
            frmCC.Closed += (s, args) => this.Close();
            frmCC.Show();
            
        }
    }
}
