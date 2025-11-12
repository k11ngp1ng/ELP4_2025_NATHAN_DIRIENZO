using System;
using System.Collections;
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
			string mSql = "";
			string mOk = "";

			Cidades aCidade = (Cidades)obj;
			mSql = "delete from cidades where codigo = @codigo";
			using (SqlCommand cmd = new SqlCommand(mSql, cnn))
			{
				cmd.Parameters.AddWithValue("@codigo", aCidade.Codigo);
				cmd.ExecuteNonQuery();
				mOk = "Registro excluido com sucesso";
			}
			return mOk;
		}
		public override List<Cidades> Listar()
		{
			List<Cidades> lista = new List<Cidades>();
			string mSql = "select * from cidades order by codigo";
			using (SqlCommand cmd = new SqlCommand(mSql, cnn))
			{
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						Cidades aCidade = new Cidades();
						aCidade.Codigo = Convert.ToInt32(dr["codigo"]);
						aCidade.Cidade = Convert.ToString(dr["cidade"]);
						aCidade.Ddd = Convert.ToString(dr["ddd"]);
						aCidade.OEstado.Codigo = Convert.ToInt32(dr["codigoestado"]);
						aCidade.DatCad = Convert.ToDateTime(dr["datcad"]);
						aCidade.UltAlt = Convert.ToDateTime(dr["ultalt"]);
						lista.Add(aCidade);
					}
				}
			}
			return lista;
		}
		public override Object CarregaObjeto(int chave)
		{
			Cidades aCidade = null;
			string mSql = "select * from cidades where codigo = @codigo";
			using (SqlCommand cmd = new SqlCommand(mSql, cnn))
			{
				cmd.Parameters.AddWithValue("@codigo", chave);
				using (SqlDataReader dr = cmd.ExecuteReader())
				{
					while (dr.Read())
					{
						aCidade = new Cidades();
						aCidade.Codigo = Convert.ToInt32(dr["codigo"]);
						aCidade.Cidade = Convert.ToString(dr["cidade"]);
						aCidade.Ddd = Convert.ToString(dr["ddd"]);
						aCidade.OEstado.Codigo = Convert.ToInt32(dr["codigoestado"]);
						aCidade.DatCad = Convert.ToDateTime(dr["datcad"]);
						aCidade.UltAlt = Convert.ToDateTime(dr["ultalt"]);
					}
				}
			}
			return aCidade;
		}
		public override List<Cidades> Pesquisar(string chave)
		{
			return null;
		}
	}
}
