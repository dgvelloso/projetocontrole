using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Interfaces
{
    //métodos que devem ser implementados por outras classes
    public interface IController
    {
        void Cadastrar();
        void Atualizar();
        void Excluir();
        void Consultar();
    }
}
