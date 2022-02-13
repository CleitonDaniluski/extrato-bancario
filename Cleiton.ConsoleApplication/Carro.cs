using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batata
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Barulho { get; set; }

        public string Acelerar()
        {
            return Barulho;
        }
    }
}
