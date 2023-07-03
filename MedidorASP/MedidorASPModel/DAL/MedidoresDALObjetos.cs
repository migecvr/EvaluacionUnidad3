using MedidorASPModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public class MedidoresDALObjetos : IMedidoresDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();
        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
    }
}
