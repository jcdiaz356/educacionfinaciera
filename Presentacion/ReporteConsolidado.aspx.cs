using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Presentacion
{
    public partial class ReporteConsolidado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable NumVisitasForSchool;
            int NumColegios,NumMicroredes,NumClase,NumVisitas;
            LogicaNegocio.School colegios = new LogicaNegocio.School();
            LogicaNegocio.Microred microredes = new LogicaNegocio.Microred();
            LogicaNegocio.AconpanaClase clase = new LogicaNegocio.AconpanaClase();
            LogicaNegocio.VisitaIE visitas = new LogicaNegocio.VisitaIE();
            NumColegios = colegios.countRowsSchool();
            lblNumColegios.Text = Convert.ToString(NumColegios);

            NumMicroredes = microredes.countRowsMicroredes();
            lblQFichasMicroredes.Text = Convert.ToString(NumMicroredes);

            NumClase = clase.countRowsAconpanaClase();
            lblQFichasAcomClase.Text = Convert.ToString(NumClase);

            NumVisitas = visitas.countRowsVisitas();
            lblQFichasVisitas.Text = Convert.ToString(NumVisitas);

            NumVisitasForSchool = visitas.getCountVisitsForSchool();
            lblQIEVisits.Text = Convert.ToString(NumVisitasForSchool.Rows.Count);
        }
    }
}