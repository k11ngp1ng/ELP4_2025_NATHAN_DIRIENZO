	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
	internal class CtrlPaises: Controller<Paises>
	{
		ColPaises aColPaises;
		DaoPaises aDaoPaises;

		public CtrlPaises()
		{
			//aColPaises = new ColPaises();
			aDaoPaises = new DaoPaises();
		}
		public override string Salvar(object obj) 
		{
			//base.Salvar(obj);
			return aDaoPaises.Salvar(obj);
		}
		public override string Excluir(object obj) 
		{
			return aDaoPaises.Excluir(obj);
		}
		public override List<Paises> Listar()
		{
			return aDaoPaises.Listar();
		}
		public override Object CarregaObjeto(int chave)
		{
			return null;
		}

		public override List<Paises> Pesquisar(string chave)
		{
			return null;
		}
		/*public List<Paises> TodosPaises() 
		{
			return aColPaises.Todos();
		}*/
	}
}
