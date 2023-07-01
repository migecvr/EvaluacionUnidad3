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
    public partial class Default : System.Web.UI.Page
    {

        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.grillaMedidores.DataSource = medidores;
                this.grillaMedidores.DataBind();
            }

        }

        protected void CargaGrilla()
        {


            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();


        }


        protected void grillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {


        }

    }
}