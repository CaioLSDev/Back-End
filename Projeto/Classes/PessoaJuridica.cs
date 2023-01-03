using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Classes;
using Projeto.Interfaces;

namespace Projeto.obj.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial {get;set;}

        public override double CalcularImposto(double rendimento)
        {
           if (rendimento <= 3000)
            {
                return rendimento *0.03;
            }
            else if (rendimento > 3000 && rendimento <= 6000)
            {
                return rendimento * 0.05;
            }
            else if (rendimento > 6000 && rendimento <= 10000)
            {
                return rendimento * 0.07;
            }
            else
            {
               return rendimento * 0.09;
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}