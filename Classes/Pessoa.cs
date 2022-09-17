using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FS11__UC12_ER2.Interfaces;//importar o namespace de Interfaces

namespace FS11__UC12_ER2.Classes
{
    public class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public string ?endereco { get; set; }
        public double ?rendimento { get; set; }


        // implementando o médoto PagarImposto da IPessoa (seguindo o contrato)
        double IPessoa.PagarImposto(double rendimento)
        {
            throw new NotImplementedException();
        }

        double IPessoa.Teste(double rendimento)
        {
            throw new NotImplementedException();
        }
    }
}