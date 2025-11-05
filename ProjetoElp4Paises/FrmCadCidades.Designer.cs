namespace ProjetoElp4Paises
{
    partial class FrmCadCidades
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblDdd = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtDdd = new System.Windows.Forms.TextBox();
			this.lblCodigoEstado = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.txtCodigoEstado = new System.Windows.Forms.TextBox();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.TabIndex = 4;
			// 
			// btnSair
			// 
			this.btnSair.TabIndex = 5;
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(118, 9);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(51, 16);
			this.lblCidade.TabIndex = 10;
			this.lblCidade.Text = "Cidade";
			// 
			// lblDdd
			// 
			this.lblDdd.AutoSize = true;
			this.lblDdd.Location = new System.Drawing.Point(257, 12);
			this.lblDdd.Name = "lblDdd";
			this.lblDdd.Size = new System.Drawing.Size(37, 16);
			this.lblDdd.TabIndex = 11;
			this.lblDdd.Text = "DDD";
			// 
			// txtCidade
			// 
			this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCidade.Location = new System.Drawing.Point(121, 27);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(130, 22);
			this.txtCidade.TabIndex = 0;
			// 
			// txtDdd
			// 
			this.txtDdd.Location = new System.Drawing.Point(257, 27);
			this.txtDdd.Name = "txtDdd";
			this.txtDdd.Size = new System.Drawing.Size(37, 22);
			this.txtDdd.TabIndex = 1;
			this.txtDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCodigoEstado
			// 
			this.lblCodigoEstado.AutoSize = true;
			this.lblCodigoEstado.Location = new System.Drawing.Point(300, 9);
			this.lblCodigoEstado.Name = "lblCodigoEstado";
			this.lblCodigoEstado.Size = new System.Drawing.Size(51, 16);
			this.lblCodigoEstado.TabIndex = 14;
			this.lblCodigoEstado.Text = "Codigo";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(354, 8);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(50, 16);
			this.lblEstado.TabIndex = 15;
			this.lblEstado.Text = "Estado";
			// 
			// txtCodigoEstado
			// 
			this.txtCodigoEstado.Location = new System.Drawing.Point(300, 28);
			this.txtCodigoEstado.Name = "txtCodigoEstado";
			this.txtCodigoEstado.Size = new System.Drawing.Size(51, 22);
			this.txtCodigoEstado.TabIndex = 2;
			this.txtCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtEstado
			// 
			this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEstado.Location = new System.Drawing.Point(357, 27);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(121, 22);
			this.txtEstado.TabIndex = 3;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(484, 27);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 10;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// FrmCadCidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.txtCodigoEstado);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.lblCodigoEstado);
			this.Controls.Add(this.txtDdd);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.lblDdd);
			this.Controls.Add(this.lblCidade);
			this.Name = "FrmCadCidades";
			this.Text = "Cadastro de Cidades";
			this.Controls.SetChildIndex(this.txtCodigo, 0);
			this.Controls.SetChildIndex(this.btnSair, 0);
			this.Controls.SetChildIndex(this.btnSalvar, 0);
			this.Controls.SetChildIndex(this.lblCodigo, 0);
			this.Controls.SetChildIndex(this.lblCidade, 0);
			this.Controls.SetChildIndex(this.lblDdd, 0);
			this.Controls.SetChildIndex(this.txtCidade, 0);
			this.Controls.SetChildIndex(this.txtDdd, 0);
			this.Controls.SetChildIndex(this.lblCodigoEstado, 0);
			this.Controls.SetChildIndex(this.lblEstado, 0);
			this.Controls.SetChildIndex(this.txtCodigoEstado, 0);
			this.Controls.SetChildIndex(this.txtEstado, 0);
			this.Controls.SetChildIndex(this.btnBuscar, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblDdd;
        protected System.Windows.Forms.TextBox txtCidade;
        protected System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.Label lblCodigoEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigoEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnBuscar;
    }
}
