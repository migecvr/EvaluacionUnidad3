using MedidorASPModel.DAL;
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

            //if (Page.IsValid)
            //{
            //    this.RequiredFieldValidator1.Text = "debes completar";

            //}
            //else {
            //    this.RequiredFieldValidator1.Text = "Esta vacio";
            //}

            int numSerie = Convert.ToInt32(this.NumSerie.Text.Trim());


            string tipo = this.TipoDdl.SelectedItem.Text;
            //String tipo = this.Tipo.Text.Trim();

            Medidor medidor = new Medidor()
            {
                NumSerie = numSerie,
                Tipo = tipo

            };
            medidoresDAL.AgregarMedidor(medidor);

            this.mensajeLbl.Text = "Se han ingresado los datos";

            Response.Redirect("Default.aspx");
        }
    }
}