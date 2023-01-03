using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Interfaces;

namespace Projeto.Classes
{
    public abstract class Pessoa: IPessoa
    {
        public string? nome { get; set; }
        public double rendimento {get; set;}
        public Endereco? endereco {get;set;}

        public abstract double CalcularImposto (double rendimento);
    }
}