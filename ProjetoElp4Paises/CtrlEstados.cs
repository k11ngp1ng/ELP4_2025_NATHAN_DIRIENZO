using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
	internal class CtrlEstados : Controller<Estados>
	{
		ColPaises aColPaises;
		DaoEstados aDaoEstados;

		public CtrlEstados()
		{
			aColPaises = new ColPaises();
			aDaoEstados = new DaoEstados();
		}
		public override string Salvar(object obj)
		{
			//base.Salvar(obj);
			return aDaoEstados.Salvar(obj);
		}
		public override string Excluir(object obj)
		{
			return aDaoEstados.Excluir(obj);
		}
		public override Object CarregaObjeto(int chave)
		{
			return aDaoEstados.CarregaObjeto(chave);
		}
		public override List<Estados> Listar()
		{
			return aDaoEstados.Listar();
		}
	}
}
