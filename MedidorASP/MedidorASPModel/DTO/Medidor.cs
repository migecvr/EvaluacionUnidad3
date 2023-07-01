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





        //private string nombre;
        //private string codigo;

        //public string Nombre { get => nombre; set => nombre = value; }
        //public string Codigo { get => codigo; set => codigo = value; }
    }
}
