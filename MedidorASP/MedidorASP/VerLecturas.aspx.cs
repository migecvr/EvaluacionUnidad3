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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;

            this.grillaLecturas.DataBind();


        }

        protected void CargaGrilla()
        {

            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;

            this.grillaLecturas.DataBind();


        }
    }
}