using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Presentacion
{
    public partial class ReportesPorProfesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable NumGradesForTeachers;
            int totalGrades=0;
            Double NumColGrades,PorGrades;
            LogicaNegocio.TeacherGrade teacherGrade = new LogicaNegocio.TeacherGrade();
            NumGradesForTeachers = teacherGrade.getCountGradesForTeachers();
            foreach (DataRow fila0 in NumGradesForTeachers.Rows)
            {
                totalGrades = totalGrades + Convert.ToInt32(fila0["Num_grades"]);
            }
            lblCountTeachers.Text = Convert.ToString(totalGrades);
            foreach (DataRow fila0 in NumGradesForTeachers.Rows)
            {
                NumColGrades = Convert.ToInt32(fila0["Num_grades"]);
                PorGrades = (NumColGrades / totalGrades) * 100;
                lblNumGradesForTeacher.Text += "<tr>";
                lblNumGradesForTeacher.Text += "<td>" + fila0["name"].ToString() + "</td>";
                lblNumGradesForTeacher.Text += "<td>" + fila0["Num_grades"].ToString() + "</td>";
                lblNumGradesForTeacher.Text += "<td>" + String.Format("{0:0.00}", PorGrades) + "</td>";
                lblNumGradesForTeacher.Text += "</tr>";
            }
        }
    }
}