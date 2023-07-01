﻿using MedidorASPModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }
    }
}
