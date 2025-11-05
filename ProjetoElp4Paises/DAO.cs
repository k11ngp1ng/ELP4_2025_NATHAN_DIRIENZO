using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
	internal class DAO<T>
	{
		public SqlConnection cnn;
		public DAO()
		{
			cnn = Banco.Abrir();
		}
		public virtual string Salvar(object obj)
		{
			return null;
		}
		public virtual string Excluir(object obj)
		{
			return null;
		}
		public virtual List<T> Listar()
		{
			return null;
		}
		public virtual Object CarregaObjeto(int chave)
		{
			return null;
		}

		public virtual List<T> Pesquisar(string chave)
		{
			return null;
		}
	}
}
