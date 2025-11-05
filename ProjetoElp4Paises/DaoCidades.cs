using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
	internal class DaoCidades : DAO<Cidades>
	{
		public override string Salvar(object obj)
		{
			Cidades aCidade = (Cidades)obj;
			string mSql = "", mOk = "";
			if (aCidade.Codigo == 0)
			{
				mSql = "insert into cidades(Cidade, DDD, CodigoEstado, DatCad, UltAlt) values(@cidade, @ddd, @codigoestado, @datcad, @ultalt)";
			}
			else
			{
				mSql = "update cidades set cidades=@cidades, ddd=@ddd, codigoestado=@codigoestado, datcad=@datcad, ultalt=@ultalt where codigo=@codigo"; 
			}
			using (SqlCommand cmd = new SqlCommand(mSql, cnn))
			{
				cmd.Parameters.AddWithValue("@Cidade", aCidade.Cidade);
				cmd.Parameters.AddWithValue("@DDD", aCidade.Ddd);
				cmd.Parameters.AddWithValue("@CodigoEstado", aCidade.OEstado.Codigo);
				cmd.Parameters.AddWithValue("@DatCad", aCidade.DatCad);
				cmd.Parameters.AddWithValue("@UltAlt", aCidade.UltAlt);
				cmd.Parameters.AddWithValue("@Codigo", aCidade.Codigo);
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
		public override List<Cidades> Listar()
		{
			return null;
		}
		public override Object CarregaObjeto(int chave)
		{
			return null;
		}
		public override List<Cidades> Pesquisar(string chave)
		{
			return null;
		}
	}
}
