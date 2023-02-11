using ProjetoAula04.Controllers;

namespace ProjetoAula04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n *** CONTROLE DE PLANOS E CLIENTES *** \n");
            Console.WriteLine("(1) CADASTRAR");
            Console.WriteLine("(2) ATUALIZAR");
            Console.WriteLine("(3) EXCLUIR");
            Console.WriteLine("(4) CONSULTAR");
            Console.WriteLine("(5) CADASTRAR CLIENTE");
            Console.WriteLine("(6) ATUALIZAR CLIENTE");
            Console.WriteLine("(7) EXCLUIR CLIENTE");
            Console.WriteLine("(8) CONSULTAR CLIENTES");
            Console.WriteLine("(0) SAIR DO PROGRAMA");

            Console.WriteLine("\n DIGITE O Nº DA OPÇÃO DESEJADA....: ");

            var opcao = int.Parse(Console.ReadLine());

            //precisa instanciar a controller pq vai chamar os métodos de lá.

            var planoController = new PlanoController();
            var clienteController = new ClienteController();


            switch (opcao) {
                case 1:
                    planoController.Cadastrar();
                    Main(args); //recursividade. volta pro início do programa.
                    break;
                case 2:;
                    planoController.Atualizar();
                    Main(args); //recursividade. volta pro início do programa.
                    break;
                case 3:
                    planoController.Excluir();
                    Main(args); //recursividade. volta pro início do programa.
                    break;
                case 4:
                    planoController.Consultar();
                    Main(args); //recursividade. volta pro início do programa.
                    break;
                case 5:
                    clienteController.Cadastrar();
                    Main(args); //recursividade
                    break;

                case 6:
                    clienteController.Atualizar();
                    Main(args); //recursividade
                    break;

                case 7:
                    clienteController.Excluir();
                    Main(args); //recursividade
                    break;

                case 8:
                    clienteController.Consultar();
                    Main(args); //recursividade
                    break;

                case 0:
                    Console.WriteLine("\nFIM DO PROGRAMA!");
                    break;
            }
        }
    }
}