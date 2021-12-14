
namespace CadClientes
{
    partial class Config
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
            this.lblURI = new System.Windows.Forms.Label();
            this.txtURI = new System.Windows.Forms.TextBox();
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblURI
            // 
            this.lblURI.AutoSize = true;
            this.lblURI.Location = new System.Drawing.Point(61, 38);
            this.lblURI.Name = "lblURI";
            this.lblURI.Size = new System.Drawing.Size(26, 13);
            this.lblURI.TabIndex = 0;
            this.lblURI.Text = "URI";
            // 
            // txtURI
            // 
            this.txtURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURI.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtURI.Location = new System.Drawing.Point(103, 35);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(250, 20);
            this.txtURI.TabIndex = 1;
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(136, 61);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(75, 23);
            this.btnTestar.TabIndex = 2;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(217, 61);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 91);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.lblURI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURI;
        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Button btnTestar;
        private System.Windows.Forms.Button btnSalvar;
    }
}