using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_RepoDocAsesorados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.Docente profesor = new LogicaNegocio.Docente();
            int cantidadDoc;
            cantidadDoc = profesor.countRowsDocentes();
            lblNumDocentes.Text = Convert.ToString(cantidadDoc);
        }
    }
}