using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WCFWEB
{
    public partial class ConsultaCitasPorPaciente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttBBuscar_Click(object sender, EventArgs e)
        {
            string strDni = txtDni.Text;
            ProxyCitasService.CitasServiceClient proxy = new ProxyCitasService.CitasServiceClient();
            DataSet ds = new DataSet();
            ds = proxy.ObtenerCitaPorPacientes(strDni);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            gdvConsulta.DataSource = dt;
            gdvConsulta.DataBind();
        }
    }
}