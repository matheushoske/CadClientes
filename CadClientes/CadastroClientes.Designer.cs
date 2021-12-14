
namespace CadClientes
{
    partial class CadastroClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.lblStatusAPI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(106, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(51, 20);
            this.txtID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(58, 56);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(53, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 75);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(106, 128);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 3;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // dtpNasc
            // 
            this.dtpNasc.Location = new System.Drawing.Point(106, 101);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(100, 20);
            this.dtpNasc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data de Nasc.";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(36, 128);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(28, 13);
            this.lblCEP.TabIndex = 8;
            this.lblCEP.Text = "CEP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(106, 180);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(51, 20);
            this.txtEstado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(106, 206);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(200, 20);
            this.txtLogradouro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(106, 154);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 20);
            this.txtCidade.TabIndex = 5;
            this.txtCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(213, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(295, 12);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(72, 25);
            this.btnConfig.TabIndex = 15;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(161, 287);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Text = "Pesquisar ID";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button2_Click);
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(107, 289);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(50, 20);
            this.nudID.TabIndex = 17;
            // 
            // lblStatusAPI
            // 
            this.lblStatusAPI.AutoSize = true;
            this.lblStatusAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusAPI.ForeColor = System.Drawing.Color.Red;
            this.lblStatusAPI.Location = new System.Drawing.Point(58, 18);
            this.lblStatusAPI.Name = "lblStatusAPI";
            this.lblStatusAPI.Size = new System.Drawing.Size(214, 13);
            this.lblStatusAPI.TabIndex = 18;
            this.lblStatusAPI.Text = "Sem conexão com a API, configure: ";
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.lblStatusAPI);
            this.Controls.Add(this.nudID);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.Label lblStatusAPI;
    }
}

