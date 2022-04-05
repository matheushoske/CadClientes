using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadClientes.Interfaces;
namespace CadClientes
{
    public partial class Config : Form, IFormConfig
    {
        private readonly IApiDAO _apiDAO;
        public Config(HttpClient httpClient, IApiDAO apiDAO)
        {
            _apiDAO = apiDAO;
            InitializeComponent();
            txtURI.Text = httpClient.BaseAddress.AbsoluteUri;
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (_apiDAO.Test(txtURI.Text))
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
            Process p = new(){ 
                StartInfo = new ProcessStartInfo() 
                {
                    FileName = Application.ExecutablePath,
                    Arguments = txtURI.Text.EndsWith("/") ? txtURI.Text : string.Concat(txtURI.Text, "/")
                }
            };
            if (p.Start()) { 
                Thread.Sleep(1000);
                Application.Exit();
            }




        }
    }
    public interface IFormConfig :IContainerControl
    {
        event EventHandler Closed;
        void Close();
        void Show();
    }
}
