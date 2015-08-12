using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class TeacherCourse
    {
        DataTable TeachersCourse;
        public int insertTeacherCourse(ModeloNegocio.TeacherCourse ObjTeacherCourse)
        {

            AccesoDatos.TeacherCourse TeacherCourse = new AccesoDatos.TeacherCourse();
            return TeacherCourse.insertTeacherCourse(ObjTeacherCourse);
        }

        public List<ModeloNegocio.TeacherCourse> getAllTeacherCourseForUser(int iduser)
        {
            List<ModeloNegocio.TeacherCourse> lista = new List<ModeloNegocio.TeacherCourse>();
            AccesoDatos.TeacherCourse teacherCourseAD = new AccesoDatos.TeacherCourse();
            TeachersCourse = teacherCourseAD.getAllTeacherCourseForIdUser(iduser);
            foreach (DataRow fila in TeachersCourse.Rows)
            {
                ModeloNegocio.TeacherCourse teacherCourseMN = new ModeloNegocio.TeacherCourse();
                teacherCourseMN.Id = int.Parse(fila["id"].ToString());
                teacherCourseMN.Course = fila["course"].ToString();
                lista.Add(teacherCourseMN);
            }
            return lista;

        }
        public bool deleteTeacherCourse(int idTeacher)
        {

            AccesoDatos.TeacherCourse teacherCourseAD = new AccesoDatos.TeacherCourse();
            return teacherCourseAD.deleteTeacherCourse(idTeacher);

            
        }


    }
}
