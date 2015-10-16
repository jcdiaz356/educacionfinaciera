using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Presentacion
{
    public partial class ReporteAcomClases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable NumVisitasForAsesor, NumVisitasForTeacher;
            int NumAcomp;
            double porcNumAcomp, NumAcompParcial;
            LogicaNegocio.AconpanaClase acompClases = new LogicaNegocio.AconpanaClase();
            if (Request.Params["opcion"] == "asesor")
            {
                NumAcomp = acompClases.countRowsAconpanaClase();
                lblNumAcomp.Text = Convert.ToString(NumAcomp);
                NumVisitasForAsesor = acompClases.getCountAcompForAgent();
                foreach (DataRow fila in NumVisitasForAsesor.Rows)
                {
                    ModeloNegocio.Asesor asesorMN = new ModeloNegocio.Asesor();
                    LogicaNegocio.Asesor asesorLN = new LogicaNegocio.Asesor();

                    asesorMN = asesorLN.getAsesorId(Convert.ToInt32(fila["asesor_id"]));
                    NumAcompParcial = Convert.ToInt32(fila["Cantidad"]);
                    porcNumAcomp = (NumAcompParcial / NumAcomp) * 100;
                    lblNumAcompaForAsesor.Text += "<tr>";
                    lblNumAcompaForAsesor.Text += "<td>" + asesorMN.FullName + "</td>";
                    lblNumAcompaForAsesor.Text += "<td>" + fila["Cantidad"].ToString() + "</td>";
                    lblNumAcompaForAsesor.Text += "<td>" + String.Format("{0:0.00}", porcNumAcomp) + "</td>";
                    lblNumAcompaForAsesor.Text += "</tr>";
                }
            }

            if (Request.Params["opcion"] == "profesor")
            {
                NumAcomp = acompClases.countRowsAconpanaClase();
                lblNumAcomProfe.Text = Convert.ToString(NumAcomp);
                NumVisitasForTeacher = acompClases.getCountAcompForTeacher();
                foreach (DataRow fila in NumVisitasForTeacher.Rows)
                {
                    ModeloNegocio.Docente docenteMN = new ModeloNegocio.Docente();
                    LogicaNegocio.Docente docenteLN = new LogicaNegocio.Docente();
                    

                    docenteMN = docenteLN.getDocenteId(Convert.ToInt32(fila["docente_id"]));
                    NumAcompParcial = Convert.ToInt32(fila["Num_fichas"]);
                    porcNumAcomp = (NumAcompParcial / NumAcomp) * 100;
                    lblNumAcompaForProfesor.Text += "<tr>";
                    lblNumAcompaForProfesor.Text += "<td>" + docenteMN.FullName + "</td>";
                    lblNumAcompaForProfesor.Text += "<td>" + fila["Num_fichas"].ToString() + "</td>";
                    lblNumAcompaForProfesor.Text += "<td>" + String.Format("{0:0.00}", porcNumAcomp) + "</td>";
                    lblNumAcompaForProfesor.Text += "</tr>";
                }
            }
            
        }
    }
}