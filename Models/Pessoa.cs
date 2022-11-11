using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNET.Models

{
    public class Pessoa
    {
        private string _nome = default!;
        
        public string Nome { get; set; }

        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos.");
        }
    }
}