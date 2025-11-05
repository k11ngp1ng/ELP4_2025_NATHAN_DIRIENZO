using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
	internal class DaoPaises : DAO<Paises>
	{
		public override string Salvar(object obj)
		{
			Paises oPais = (Paises)obj;
			string mSql = "", mOk = "";
			if (oPais.Codigo == 0)
			{
				mSql = "insert into paises(Pais, Sigla, DDI, Moeda, DatCad, UltAlt) values(@pais, @sigla, @ddi, @moeda, @datcad, @ultalt)";
			}
			else
			{
				mSql = "update paises set pais=@pais, sigla=@sigla, ddi=@ddi, moeda=@moeda, datcad=@datcad, ultalt=@ultalt where codigo=@codigo";
			}
			using (SqlCommand cmd = new SqlCommand(mSql, cnn))
			{
				cmd.Parameters.AddWithValue("@Pais", oPais.Pais);
				cmd.Parameters.AddWithValue("@Sigla", oPais.Sigla);
				cmd.Parameters.AddWithValue("@DDI", oPais.Ddi);
				cmd.Parameters.AddWithValue("@Moeda", oPais.Moeda);
				cmd.Parameters.AddWithValue("@DatCad", oPais.DatCad);
				cmd.Parameters.AddWithValue("@UltAlt", oPais.UltAlt);
				cmd.Parameters.AddWithValue("@Codigo", oPais.Codigo);
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
		public override List<Paises> Listar()
		{
			List<Paises> lista = new List<Paises>();
			string mSql = "select * from paises order by codigo";
			using (SqlCommand cmd = new SqlCommand(mSql, cnn)) 
			{
				using (SqlDataReader dr = cmd.ExecuteReader()) 
				{
					while (dr.Read()) 
					{
						Paises oPais = new Paises();
						oPais.Codigo = Convert.ToInt32(dr["codigo"]);
						oPais.Pais = Convert.ToString(dr["pais"]);
						oPais.Sigla = Convert.ToString(dr["sigla"]);
						oPais.Ddi = Convert.ToString(dr["ddi"]);
						oPais.Moeda = Convert.ToString(dr["moeda"]);
						oPais.DatCad = Convert.ToDateTime(dr["datcad"]);
						oPais.UltAlt = Convert.ToDateTime(dr["ultalt"]);
						lista.Add(oPais);
					}
				}
			}
			return lista;
		}
		public override Object CarregaObjeto(int chave)
		{
			return null;
		}
		public override List<Paises> Pesquisar(string chave)
		{
			return null;
		}
	}
}
