using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS11__UC12_ER2.Interfaces
{
    public interface IPessoa
    {
      public abstract double PagarImposto(double rendimento);
      public abstract double Teste(double rendimento);  
    }
}