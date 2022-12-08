using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Classes;
using Projeto.Interfaces;

namespace Projeto.obj.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get;set;}

        public DateTime dataNascimento {get;set;}

        public override double CalcularImposto(double rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                return rendimento * 0.02;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                return rendimento * 0.035;
            }
            else
            {
               return rendimento * 0.05;
            }

        }

        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }

    }
}