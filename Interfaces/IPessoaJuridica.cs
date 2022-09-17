using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS11__UC12_ER2.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cnpj);
    }
}