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
        public string ?dataNascimento { get; set; }

        public override double PagarImposto(double rendimento)
        {
            if( rendimento <= 1500 )
            {
                
                return rendimento; // isento
            } 
            else if( rendimento >= 1501 && rendimento <= 5000)
            {
                
                return rendimento -  (rendimento / 100) * 3; // 3%
            } 

            //quem ganha acima de 5001
            return rendimento - (rendimento / 100) * 5; //5%
        }

        public bool ValidarDataNascimento(string dataNasc)//"1982/07/20"
        {
            DateTime dataConvertida;

            if( DateTime.TryParse(dataNasc, out dataConvertida)  ) {
                // System.Console.WriteLine(dataConvertida);
            
                DateTime dataAtual = DateTime.Today;
                double idade = (dataAtual - dataConvertida).TotalDays / 365;

                if(idade >= 18) {
                    return true;
                } else {
                    return false;
                }
                // System.Console.WriteLine(idade);
            } else {
                return false;
            }
        }
    }
}