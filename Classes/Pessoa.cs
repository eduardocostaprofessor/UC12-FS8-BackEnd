using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FS11__UC12_ER2.Interfaces;//importar o namespace de Interfaces
using FS11__UC12_ER2.Classes;
namespace FS11__UC12_ER2.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string ?nome { get; set; }
        public Endereco? endereco { get; set; }
        public double rendimento { get; set; }

        public abstract double PagarImposto(double rendimento);





        // implementando o médoto PagarImposto da IPessoa (seguindo o contrato)


        double IPessoa.Teste(double rendimento)
        {
            throw new NotImplementedException();
        }
    }
}