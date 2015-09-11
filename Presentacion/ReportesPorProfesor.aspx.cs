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
            int totalGrades; 
            //int c = 0;
            LogicaNegocio.TeacherGrade teacherGrade = new LogicaNegocio.TeacherGrade();
            NumGradesForTeachers = teacherGrade.getCountGradesForTeachers();
            
            foreach (DataRow fila0 in NumGradesForTeachers.Rows)
            {
                //c = c + 1;
                totalGrades = teacherGrade.getCountGradesForIdTeacher(Convert.ToInt32(fila0["id"]));
                lblNumGradesForTeacher.Text += "<tr>";
                lblNumGradesForTeacher.Text += "<td>" + fila0["name"].ToString() + "</td>";
                lblNumGradesForTeacher.Text += "<td>" + totalGrades + "</td>";
                lblNumGradesForTeacher.Text += "<td>" + fila0["Num_grades"].ToString() + "</td>";
                lblNumGradesForTeacher.Text += "</tr>";
                //if (c == 5)
                //{
                //    break;
                //}
            }
        }
    }
}