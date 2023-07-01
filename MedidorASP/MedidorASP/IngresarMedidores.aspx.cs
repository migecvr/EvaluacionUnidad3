﻿using MedidorASPModel.DAL;
using MedidorASPModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorASP
{
    public partial class IngresarMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAgregarMedidor_Click(object sender, EventArgs e)
        {

            int numSerie = Convert.ToInt32(this.NumSerie.Text.Trim());

            String tipo = this.Tipo.Text.Trim();

            Medidor medidor = new Medidor()
            {
                NumSerie = numSerie,
                Tipo = tipo

            };
            medidoresDAL.AgregarMedidor(medidor);

            this.mensajeLbl.Text = "medidor ingreso :D";

            Response.Redirect("Default.aspx");
        }
    }
}