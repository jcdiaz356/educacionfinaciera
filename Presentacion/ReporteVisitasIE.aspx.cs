using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Presentacion
{
    public partial class ReporteVisitasIE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable NumVisitasForAsesor, NumVisitasForSchool;
            double NumVisitas, NumVisitAse, PorcAse;
            int school_id;
            string nameSchool;
            LogicaNegocio.VisitaIE visitas = new LogicaNegocio.VisitaIE();
            NumVisitas = visitas.countRowsVisitas();
            lblNumVisitas.Text = Convert.ToString(NumVisitas);
            NumVisitasForAsesor = visitas.getCountVisitsForAgent();
            lblQAsesor.Text = Convert.ToString(NumVisitasForAsesor.Rows.Count);
            foreach (DataRow fila in NumVisitasForAsesor.Rows)
            {
                ModeloNegocio.Asesor asesorMN = new ModeloNegocio.Asesor();
                LogicaNegocio.Asesor asesorLN = new LogicaNegocio.Asesor();

                asesorMN = asesorLN.getAsesorId(Convert.ToInt32(fila["asesor_id"]));
                NumVisitAse = Convert.ToInt32(fila["Cantidad"]);
                PorcAse = (NumVisitAse / NumVisitas) * 100;
                lblNumVisitsForAsesor.Text += "<tr>";
                lblNumVisitsForAsesor.Text += "<td>" + asesorMN.FullName + "</td>";
                lblNumVisitsForAsesor.Text += "<td>" + fila["Cantidad"].ToString() + "</td>";
                lblNumVisitsForAsesor.Text += "<td>" + String.Format("{0:0.00}", PorcAse) + "</td>";
                lblNumVisitsForAsesor.Text += "</tr>";
            }

            NumVisitasForSchool = visitas.getCountVisitsForSchool();
            lblQSchoolVisit.Text = Convert.ToString(NumVisitasForSchool.Rows.Count);
            foreach (DataRow fila1 in NumVisitasForSchool.Rows)
            {
                ModeloNegocio.School schoolMN = new ModeloNegocio.School();
                LogicaNegocio.School schoolLN = new LogicaNegocio.School();

                school_id = Convert.ToInt32(fila1["school_id"]);
                if (school_id == 0)
                {
                    nameSchool = "Indeterminado";
                }
                else
                {
                    schoolMN = schoolLN.getSchool(school_id);
                    nameSchool = schoolMN.Nombre;
                }
                
                NumVisitAse = Convert.ToInt32(fila1["Cantidad"]);
                PorcAse = (NumVisitAse / NumVisitas) * 100;
                lblNumVisitForSchool.Text += "<tr>";
                lblNumVisitForSchool.Text += "<td>" + nameSchool + "</td>";
                lblNumVisitForSchool.Text += "<td>" + fila1["Cantidad"].ToString() + "</td>";
                lblNumVisitForSchool.Text += "<td>" + String.Format("{0:0.00}", PorcAse) + "</td>";
                lblNumVisitForSchool.Text += "</tr>";
            }
        }
    }
}