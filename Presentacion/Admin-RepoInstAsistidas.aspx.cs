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
            DataTable NumSchoolForUgel, NumTeachersForSchool, NumStudentsForSchool;
            double NumColegios, NumTeacherSchool, PorcTeaher, NumColUgel, PorcUgel, NumStudentsSchool, PorcStudents, TotalTeachers, TotalStudents;
            LogicaNegocio.School colegios = new LogicaNegocio.School();
            LogicaNegocio.Docente docentes = new LogicaNegocio.Docente();
            LogicaNegocio.UserSchool userSchool = new LogicaNegocio.UserSchool();
            NumColegios = colegios.countRowsSchool();
            TotalTeachers = docentes.countRowsDocentes();
            TotalStudents = docentes.countRowsStudents();
            lblNumColegios.Text = Convert.ToString(NumColegios);
            lblCountTeachers.Text = Convert.ToString(TotalTeachers);
            lblCountStudents.Text = Convert.ToString(TotalStudents);
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

            NumTeachersForSchool = userSchool.countTeacherForSchool();
            foreach (DataRow fila0 in NumTeachersForSchool.Rows)
            {
                NumTeacherSchool = Convert.ToInt32(fila0["Num_teacher"]);
                PorcTeaher = (NumTeacherSchool / TotalTeachers) * 100;
                lblNumTeacherForSchool.Text += "<tr>";
                lblNumTeacherForSchool.Text += "<td>" + fila0["codigo"].ToString() + "</td>";
                lblNumTeacherForSchool.Text += "<td>" + fila0["nombre"].ToString() + "</td>";
                lblNumTeacherForSchool.Text += "<td>" + fila0["Num_teacher"].ToString() + "</td>";
                lblNumTeacherForSchool.Text += "<td>" + String.Format("{0:0.00}", PorcTeaher) + "</td>";
                lblNumTeacherForSchool.Text += "</tr>";
            }

            NumStudentsForSchool = colegios.countStudentsForSchool();
            foreach (DataRow fila00 in NumStudentsForSchool.Rows)
            {
                NumStudentsSchool = Convert.ToInt32(fila00["num_alum_sec"]);
                PorcStudents = (NumStudentsSchool / TotalStudents) * 100;
                lblNumStudentsForSchool.Text += "<tr>";
                lblNumStudentsForSchool.Text += "<td>" + fila00["codigo"].ToString() + "</td>";
                lblNumStudentsForSchool.Text += "<td>" + fila00["nombre"].ToString() + "</td>";
                lblNumStudentsForSchool.Text += "<td>" + fila00["num_alum_sec"].ToString() + "</td>";
                lblNumStudentsForSchool.Text += "<td>" + String.Format("{0:0.00}", PorcStudents) + "</td>";
                lblNumStudentsForSchool.Text += "</tr>";
            }

            
        }
    }
}