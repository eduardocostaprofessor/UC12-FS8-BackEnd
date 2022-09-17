using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FS11__UC12_ER2.Interfaces;

namespace FS11__UC12_ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string ?cnpj { get; set; }
        public string ?razaoSocial { get; set; }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}