using PCDevLocadora.Models;
using PCDevLocadora.Services;
using System;
using System.Collections.Generic;

namespace PCDevLocadora
   
{
    public class Program
    {
        private static UsuarioServices _usuarioServices = new UsuarioServices();
        private static FilmeServices _filmeServices = new FilmeServices();
        private static SerieServices _serieServices = new SerieServices();


        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a locadora de vídeos");

            bool continuar = true;
            do
            {
                Console.WriteLine("Digite o número da sua opção:");
                Console.WriteLine("1 - Cadastrar usuários");
                Console.WriteLine("2 - Listar usuários");
                Console.WriteLine("3 - Cadastrar filme");
                Console.WriteLine("4 - Listar Filme");
                Console.WriteLine("5 - Cadastrar série");
                Console.WriteLine("6 - Listar sérir");
                Console.WriteLine("7 - Alugar filme");
                Console.WriteLine("8 - Alugar série");
                Console.WriteLine("9 - Devolver filme");
                Console.WriteLine("10 - Devolver série");
                Console.WriteLine("Qualquer outro número para sair");

                int resposta = int.Parse(Console.ReadLine());

                switch (resposta)
                {
                    case 1:
                        _usuarioServices.CadastrarUsuario();
                        break;
                    case 2:
                        _usuarioServices.ListarUsuarios();
                        break;
                    case 3:
                        _filmeServices.CadastrarFilme();
                        break;
                    case 4:
                        _serieServices.ListarSeries();
                        break;
                    case 5:
                        _serieServices.CadastrarSerie();
                        break;

                    default:
                        continuar = false;
                        break;
                }
            } while (continuar);

        }
    }
}
