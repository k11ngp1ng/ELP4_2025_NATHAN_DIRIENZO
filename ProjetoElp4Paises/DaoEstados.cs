using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
	internal class DaoEstados : DAO<Estados>
	{
		public override string Salvar(object obj)
		{
			Estados oEstado = (Estados)obj;
			string mSql = "", mOk = "";
			if (oEstado.Codigo == 0)
			{
				mSql = "insert into estados(Estado, Uf, CodigoPais, DatCad, UltAlt) values(@estado, @uf, @codigopais, @datcad, @ultalt)";
			}
			else
			{
				mSql = "update estados set estado=@estado, uf=@uf, codigopais=@codigopais, datcad=@datcad, ultalt=@ultalt where codigo=@codigo"; 
			}
			using (SqlCommand cmd = new SqlCommand(mSql, cnn))
			{
				cmd.Parameters.AddWithValue("@Estado", oEstado.Estado);
				cmd.Parameters.AddWithValue("@Uf", oEstado.Uf);
				cmd.Parameters.AddWithValue("@CodigoPais", oEstado.OPais.Codigo);
				cmd.Parameters.AddWithValue("@DatCad", oEstado.DatCad);
				cmd.Parameters.AddWithValue("@UltAlt", oEstado.UltAlt);
				cmd.Parameters.AddWithValue("@Codigo", oEstado.Codigo);
				cmd.ExecuteNonQuery();

				cmd.CommandText = "select @@IDENTITY";
				mOk = cmd.ExecuteScalar().ToString();
			}
			return mOk;
		}
		public override string Excluir(object obj)
		{
			return null;
		}
		public override List<Estados> Listar()
		{
			return null;
		}
		public override Object CarregaObjeto(int chave)
		{
			return null;
		}
		public override List<Estados> Pesquisar(string chave)
		{
			return null;
		}
	}
}
