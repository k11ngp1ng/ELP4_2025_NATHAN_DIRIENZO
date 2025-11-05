using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElp4Paises
{
    internal class Controller<T>
    {
        public Controller()
        {

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
