using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DTO
{
    public class Lectura
    {
        private Medidor medidor;
        private String fecha;
        private int hora;
        private int minuto;
        private double consumo;
        

        public Medidor Medidor { get => medidor; set => medidor = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Minuto { get => minuto; set => minuto = value; }
        public double Consumo { get => consumo; set => consumo = value; }
    }
}
