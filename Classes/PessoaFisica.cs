using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FS11__UC12_ER2.Interfaces;

namespace FS11__UC12_ER2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string ?cpf { get; set; }
        public DateTime ?dataNascimento { get; set; }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}