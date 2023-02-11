using ProjetoAula04.Entities;
using ProjetoAula04.Interfaces;
using ProjetoAula04.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAula04.Controllers
{
    public class PlanoController : IController
    {
        //atributo
        private PlanoRepository _planoRepository;

        //construtor pra inicializar o repository e injetar dependências
        public PlanoController()
        {
            _planoRepository =  new PlanoRepository();
        }

        public void Atualizar()
        {
            try
            {
                Console.WriteLine("\n *** Atualização de Plano *** \n");
                Console.Write("INFORME O ID DO PLANO......");

                var id = Guid.Parse(Console.ReadLine());
                var plano = _planoRepository.GetById(id);

                if (plano != null)
                {
                    Console.WriteLine("Altere o nome do plano:......");
                    plano.Nome = Console.ReadLine();

                    _planoRepository.Update(plano);
                    Console.WriteLine("\n Plano atualizado com sucesso");
                }
                else
                {
                    Console.WriteLine("\n PLANO NÃO ENCONTRADO");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao atualizar plano: {e.Message}");
            }
        }

        public void Cadastrar()
        {
            try
            {
                Console.WriteLine("\n *** Cadastro de Plano *** \n");
                var plano = new Plano();
                Console.Write("NOME DO PLANO......");
                plano.Nome = Console.ReadLine();

                _planoRepository.Add(plano);

                Console.WriteLine("\n PLANO CADASTRADO COM SUCESSO!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao cadastrar plano: {e.Message}");
            }

        }

        public void Consultar()
        {
            try
            {
                Console.WriteLine("\n *** Consulta de Plano *** \n");

                var planos = _planoRepository.GetAll();

                foreach ( var plano in planos ) {
                    Console.WriteLine($"ID DO PLANO......: {plano.Id}");
                    Console.WriteLine($"NOME DO PLANO......: {plano.Nome}");
                    Console.WriteLine(".....");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao consultar plano: {e.Message}");
            }
        }

        public void Excluir()
        {
            try
            {
                Console.WriteLine("\n*** EXCLUSÃO DE PLANO ***\n");

                Console.Write("INFORME O ID DO PLANO...: ");
                var id = Guid.Parse(Console.ReadLine());

                var plano = _planoRepository.GetById(id);

                if (plano != null)
                {
                    _planoRepository.Delete(plano);
                    Console.WriteLine("\nPLANO EXCLUÍDO COM SUCESSO!");
                }
                else
                {
                    Console.WriteLine("\nPLANO NÃO ENCONTRADO!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Falha ao excluir plano: {e.Message}");
            }
        }

    }
}
