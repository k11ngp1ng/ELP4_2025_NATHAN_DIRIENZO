namespace ProjetoElp4Paises
{
    partial class FrmConsCidades
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
			this.colCidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colCodigoEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// ListV
			// 
			this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCidade,
            this.colDdd,
            this.colCodigoEstado,
            this.colEstado});
			this.ListV.SelectedIndexChanged += new System.EventHandler(this.ListV_SelectedIndexChanged);
			// 
			// colCidade
			// 
			this.colCidade.Text = "Cidade";
			this.colCidade.Width = 200;
			// 
			// colDdd
			// 
			this.colDdd.Text = "DDD";
			this.colDdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// colCodigoEstado
			// 
			this.colCodigoEstado.Text = "código";
			this.colCodigoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// colEstado
			// 
			this.colEstado.Text = "Estado";
			// 
			// FrmConsCidades
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Name = "FrmConsCidades";
			this.Text = "Consulta de Cidades";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ColumnHeader colCidade;
		private System.Windows.Forms.ColumnHeader colDdd;
		private System.Windows.Forms.ColumnHeader colCodigoEstado;
		private System.Windows.Forms.ColumnHeader colEstado;
	}
}
