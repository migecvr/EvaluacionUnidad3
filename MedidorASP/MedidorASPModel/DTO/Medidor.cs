using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DTO
{
    public class Medidor
    {
        private int numSerie;
        private string tipo;

        public int NumSerie { get => numSerie; set => numSerie = value; }
        public string Tipo { get => tipo; set => tipo = value; }



    }
}
