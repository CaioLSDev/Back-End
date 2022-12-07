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

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();
        }
    }
}