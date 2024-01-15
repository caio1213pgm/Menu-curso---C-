using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c__04.Models
{
    public class Pessoa
    {

        // public Pessoa (string nome, string sobrenome)
        // {
        //     Nome = nome;
        //     Sobrenome = sobrenome;
        // }

        private string _nome;
        private int _idade;
        private string _sobrenome;

        public string Nome 
        { 
          get => _nome;
        
          set
          {
            if(value == "")
            {
                throw new ArgumentException("Nome inválido, tente novamente!");
            }
            _nome = value;
          }
        }
        public string Sobrenome 
        {
          get => _sobrenome;
          set
          {
             if(value == "")
            {
                throw new ArgumentException("Sobrenome inválido, tente novamente");
            }
            _sobrenome = value;
          }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade 
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade inválida, tente novamente");
                }
                _idade = value;
            } 
        }

        



        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}.");
        }
    }
}