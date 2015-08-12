using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Presentacion
{
    public partial class Admin_RepoInstAsistidas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable NumSchoolForUgel, NumSchoolForAsesor;
            double NumColegios, NumColUgel, PorcUgel;
            LogicaNegocio.School colegios = new LogicaNegocio.School();
            NumColegios = colegios.countRowsSchool();
            lblNumColegios.Text = Convert.ToString(NumColegios);
            NumSchoolForUgel = colegios.countSchoolForUgel();
            foreach (DataRow fila in NumSchoolForUgel.Rows)
            {
                NumColUgel = Convert.ToInt32(fila["Num_Cole"]);
                PorcUgel = (NumColUgel / NumColegios) * 100;
                lblNumSchoolForUgel.Text += "<tr>";
                lblNumSchoolForUgel.Text += "<td>" + fila["NombUgel"].ToString() + "</td>";
                lblNumSchoolForUgel.Text += "<td>" + fila["Num_Cole"].ToString() + "</td>";
                lblNumSchoolForUgel.Text += "<td>" + String.Format("{0:0.00}", PorcUgel) + "</td>";
                lblNumSchoolForUgel.Text += "</tr>";
            }

            NumSchoolForAsesor = colegios.countSchoolForAsesor();
            foreach (DataRow fila1 in NumSchoolForAsesor.Rows)
            {
                NumColUgel = Convert.ToInt32(fila1["NUMERO_ESCUELAS"]);
                PorcUgel = (NumColUgel / NumColegios) * 100;
                lblNumSchoolForAsesor.Text += "<tr>";
                lblNumSchoolForAsesor.Text += "<td>" + fila1["ASESOR"].ToString() + "</td>";
                lblNumSchoolForAsesor.Text += "<td>" + fila1["NUMERO_ESCUELAS"].ToString() + "</td>";
                lblNumSchoolForAsesor.Text += "<td>" + String.Format("{0:0.00}", PorcUgel) + "</td>";
                lblNumSchoolForAsesor.Text += "</tr>";
            }
        }
    }
}