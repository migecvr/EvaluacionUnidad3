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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medidorDdl.DataSource = medidores;
                this.medidorDdl.DataTextField = "NumSerie";
                this.medidorDdl.DataValueField = "NumSerie";
                this.medidorDdl.DataBind();
            }
                
        }


        protected void btnIngresarLectura_Click(object sender, EventArgs e)
        {
            


            string medidorValor = this.medidorDdl.SelectedValue;
            //obtiene el valor del Texto del DropDown
            string medidorTexto = this.medidorDdl.SelectedItem.Text;



            String fecha = this.FechaTxt.Text.Trim();

            int hora = Convert.ToInt32(this.HoraTxt.Text.Trim());

            int minuto = Convert.ToInt32(this.MinutoTxt.Text.Trim());

            int consumo = Convert.ToInt32(this.ConsumoTxt.Text.Trim());



            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();

            Medidor medidor = medidores.Find(m => m.NumSerie == Convert.ToInt32(this.medidorDdl.SelectedItem.Value));



            Lectura lectura = new Lectura()
            {
                Medidor = medidor,
                Fecha = fecha,
                Hora = hora,
                Minuto = minuto,
                Consumo = consumo
            };
            lecturasDAL.AgregarLectura(lectura);

            this.mensajeLbl.Text = "Ingesado Correctamente";

            Response.Redirect("VerLecturas.aspx");
        }
    }
}