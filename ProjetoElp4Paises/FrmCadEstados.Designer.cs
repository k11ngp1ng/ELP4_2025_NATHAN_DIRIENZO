namespace ProjetoElp4Paises
{
    partial class FrmCadEstados
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
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblUf = new System.Windows.Forms.Label();
			this.txtEstado = new System.Windows.Forms.TextBox();
			this.txtUf = new System.Windows.Forms.TextBox();
			this.lblCodigoPais = new System.Windows.Forms.Label();
			this.lblPais = new System.Windows.Forms.Label();
			this.txtCodigoPais = new System.Windows.Forms.TextBox();
			this.txtPais = new System.Windows.Forms.TextBox();
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
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(118, 8);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(50, 16);
			this.lblEstado.TabIndex = 10;
			this.lblEstado.Text = "Estado";
			// 
			// lblUf
			// 
			this.lblUf.AutoSize = true;
			this.lblUf.Location = new System.Drawing.Point(271, 9);
			this.lblUf.Name = "lblUf";
			this.lblUf.Size = new System.Drawing.Size(20, 16);
			this.lblUf.TabIndex = 11;
			this.lblUf.Text = "Uf";
			// 
			// txtEstado
			// 
			this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEstado.Location = new System.Drawing.Point(121, 28);
			this.txtEstado.Name = "txtEstado";
			this.txtEstado.Size = new System.Drawing.Size(147, 22);
			this.txtEstado.TabIndex = 0;
			// 
			// txtUf
			// 
			this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUf.Location = new System.Drawing.Point(274, 28);
			this.txtUf.Name = "txtUf";
			this.txtUf.Size = new System.Drawing.Size(45, 22);
			this.txtUf.TabIndex = 1;
			this.txtUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCodigoPais
			// 
			this.lblCodigoPais.AutoSize = true;
			this.lblCodigoPais.Location = new System.Drawing.Point(322, 8);
			this.lblCodigoPais.Name = "lblCodigoPais";
			this.lblCodigoPais.Size = new System.Drawing.Size(51, 16);
			this.lblCodigoPais.TabIndex = 14;
			this.lblCodigoPais.Text = "Codigo";
			// 
			// lblPais
			// 
			this.lblPais.AutoSize = true;
			this.lblPais.Location = new System.Drawing.Point(379, 7);
			this.lblPais.Name = "lblPais";
			this.lblPais.Size = new System.Drawing.Size(34, 16);
			this.lblPais.TabIndex = 15;
			this.lblPais.Text = "Pais";
			// 
			// txtCodigoPais
			// 
			this.txtCodigoPais.Location = new System.Drawing.Point(325, 26);
			this.txtCodigoPais.Name = "txtCodigoPais";
			this.txtCodigoPais.Size = new System.Drawing.Size(48, 22);
			this.txtCodigoPais.TabIndex = 2;
			this.txtCodigoPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtPais
			// 
			this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPais.Location = new System.Drawing.Point(379, 26);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(133, 22);
			this.txtPais.TabIndex = 3;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(518, 25);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(73, 23);
			this.btnBuscar.TabIndex = 10;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// FrmCadEstados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtPais);
			this.Controls.Add(this.txtCodigoPais);
			this.Controls.Add(this.lblPais);
			this.Controls.Add(this.lblCodigoPais);
			this.Controls.Add(this.txtUf);
			this.Controls.Add(this.txtEstado);
			this.Controls.Add(this.lblUf);
			this.Controls.Add(this.lblEstado);
			this.Name = "FrmCadEstados";
			this.Text = "Cadastro de Estados";
			this.Controls.SetChildIndex(this.txtCodigo, 0);
			this.Controls.SetChildIndex(this.btnSair, 0);
			this.Controls.SetChildIndex(this.btnSalvar, 0);
			this.Controls.SetChildIndex(this.lblCodigo, 0);
			this.Controls.SetChildIndex(this.lblEstado, 0);
			this.Controls.SetChildIndex(this.lblUf, 0);
			this.Controls.SetChildIndex(this.txtEstado, 0);
			this.Controls.SetChildIndex(this.txtUf, 0);
			this.Controls.SetChildIndex(this.lblCodigoPais, 0);
			this.Controls.SetChildIndex(this.lblPais, 0);
			this.Controls.SetChildIndex(this.txtCodigoPais, 0);
			this.Controls.SetChildIndex(this.txtPais, 0);
			this.Controls.SetChildIndex(this.btnBuscar, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUf;
        protected System.Windows.Forms.TextBox txtEstado;
        protected System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.Label lblPais;
        protected System.Windows.Forms.TextBox txtCodigoPais;
        protected System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.Button btnBuscar;
    }
}
