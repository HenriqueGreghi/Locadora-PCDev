﻿using PCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Services
{
    public class UsuarioServices
    {
        private static List<Usuario> _listaUsuarios = new List<Usuario>();

        public void ListarUsuarios()
        {
            Console.WriteLine("NOME     - IDADE    - SALDO      - ÚLTIMO FILME ALUGADO");
            foreach (Usuario usuario in _listaUsuarios)
            {
                Console.WriteLine(usuario.Nome + " - " + usuario.Idade + " - " + usuario.Conta.Saldo);
            }
        }

        public void CadastrarUsuario()
        {
            Console.WriteLine("Digite o nome do usuário:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do usuário:");
            int idade = int.Parse(Console.ReadLine());

            Usuario usuario = new Usuario(idade);
            usuario.Nome = nome;
            Console.WriteLine("Idade: " + usuario.Idade);
            Console.WriteLine("Bem vindo a locadora " + usuario.Nome + ", por ser novo aqui você recebeu um crédito de " + usuario.Conta.ToString() + ".");

            _listaUsuarios.Add(usuario);
        }
    }
}
