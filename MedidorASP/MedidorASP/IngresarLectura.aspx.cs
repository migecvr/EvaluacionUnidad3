using MedidorASPModel.DAL;
using MedidorASPModel.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
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

            List<Medidor> medidores1 = medidoresDAL.ObtenerMedidores();
            //Int32.TryParse(this.medidorDdl.SelectedItem.Text, out selectMedidor)

            if (medidores1.Count == 0)
            {

                this.Label1.Text = "No hay datos seleccionados/No existen medidores";

            } else if (!comparaFecha()) 
            {
                this.Label2.Text = "Fecha incorrecta";
            }
            else {
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

        protected bool comparaFecha()
        {
            bool valido;
            

            CultureInfo cultura = new CultureInfo("en-US");
            DateTime fechaObjeto;
            string fechaIngresada = this.FechaTxt.Text.Trim();
            valido = (DateTime.TryParseExact(fechaIngresada, "yyyy-MM-dd", cultura, DateTimeStyles.None, out fechaObjeto));
            return valido;
        }
    }
}