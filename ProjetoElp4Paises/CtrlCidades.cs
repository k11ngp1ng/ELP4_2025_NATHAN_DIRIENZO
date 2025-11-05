using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
	internal class CtrlCidades : Controller<Cidades>
	{
		ColPaises aColPaises;
		DaoCidades aDaoCidades;

		public CtrlCidades()
		{
			//aColPaises = new ColPaises();
			aDaoCidades = new DaoCidades();
		}
		public override string Salvar(object obj)
		{
			//base.Salvar(obj);
			return aDaoCidades.Salvar(obj);
		}
		public override string Excluir(object obj)
		{
			return aDaoCidades.Excluir(obj);
		}
		public List<Paises> TodosPaises()
		{
			return aColPaises.Todos();
		}
	}
}
