using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using FS11__UC12_ER2.Interfaces;

namespace FS11__UC12_ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        public string? razaoSocial { get; set; }

        public bool ValidarCnpj(string cnpj)
        {

            // 12.222.444/0001-90   - 18
            // 12222444000190       - 14
            //0001

            if (cnpj.Length == 14 || cnpj.Length == 18)
            {
                
                if (Regex.IsMatch(cnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
                {
                    // Fazer if contando a quantidade de caracteres
                    if(cnpj.Substring(11, 4) == "0001"){//18 caracteres
                        return true;
                    } else if(cnpj.Substring(8, 4)  == "0001") {//14 caracteres
                        return true;
                    } else {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            } else {//não contém 14 ou 18 caracteres
                return false;
            }







        }
    }
}