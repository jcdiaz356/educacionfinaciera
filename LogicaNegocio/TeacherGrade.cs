using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class TeacherGrade
    {
        DataTable TeachersGrades;

        public int insertTeacherGrade(ModeloNegocio.TeacherGrade ObjTeacherGrade)
        {

            AccesoDatos.TeacherGrade TeacherGrade = new AccesoDatos.TeacherGrade();
            return TeacherGrade.insertTeacherGrade(ObjTeacherGrade);
        }



        public List<ModeloNegocio.TeacherGrade> getAllTeacherGradeForUser(int iduser)
        {
            List<ModeloNegocio.TeacherGrade> lista = new List<ModeloNegocio.TeacherGrade>();
            AccesoDatos.TeacherGrade teacherGradeAD = new AccesoDatos.TeacherGrade();
            TeachersGrades = teacherGradeAD.getAllTeacherGradeForIdUser(iduser);

            foreach (DataRow fila in TeachersGrades.Rows)
            {
                ModeloNegocio.TeacherGrade teacherGradeMN = new ModeloNegocio.TeacherGrade();
                teacherGradeMN.Id = int.Parse(fila["id"].ToString());
                teacherGradeMN.Grade = fila["grade"].ToString();
                teacherGradeMN.Seccion = fila["seccion"].ToString();
                

                if (DBNull.Value.Equals(fila["num_alumnos"]))
                {
                    teacherGradeMN.Num_alumnos = 0;
                }
                else
                {
                     
                    teacherGradeMN.Num_alumnos = Convert.ToInt32(fila["num_alumnos"]);
                }

                lista.Add(teacherGradeMN);
            }
            return lista;

        }

        public ModeloNegocio.TeacherGrade getTeacherGradeId(int TeacherGrade_id)
        {

            AccesoDatos.TeacherGrade TeacherGrade = new AccesoDatos.TeacherGrade();
            return TeacherGrade.getTeacherGradeId(TeacherGrade_id);
        }


        //public ModeloNegocio.TeacherGrade getTeacherGradeId(int TeacherGrade_id)
        //{
        //    AccesoDatos.TeacherGrade teacherGradeAD = new AccesoDatos.TeacherGrade();
        //    return teacherGradeAD.getTeacherGradeId(TeacherGrade_id);
        //}

        public bool deleteTeacherGrade(int idTeacher)
        {

            AccesoDatos.TeacherGrade teacherGradeAD = new AccesoDatos.TeacherGrade();
            return teacherGradeAD.deleteTeacherGrade(idTeacher);
        }
    }
}
