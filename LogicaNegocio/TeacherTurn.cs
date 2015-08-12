using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class TeacherTurn
    {
        DataTable TeachersTurn;
        public int insertTeacherTurn(ModeloNegocio.TeacherTurn ObjTeacherTurn)
        {

            AccesoDatos.TeacherTurn TeacherTurn = new AccesoDatos.TeacherTurn();
            return TeacherTurn.insertTeacherTurn(ObjTeacherTurn);
        }

        public List<ModeloNegocio.TeacherTurn> getAllTeacherTurnForUser(int iduser)
        {
            List<ModeloNegocio.TeacherTurn> lista = new List<ModeloNegocio.TeacherTurn>();
            AccesoDatos.TeacherTurn teacherTurnAD = new AccesoDatos.TeacherTurn();
            TeachersTurn = teacherTurnAD.getAllTeacherTurnForIdUser(iduser);
            foreach (DataRow fila in TeachersTurn.Rows)
            {
                ModeloNegocio.TeacherTurn teacherTurnMN = new ModeloNegocio.TeacherTurn();
                teacherTurnMN.Id = int.Parse(fila["id"].ToString());
                teacherTurnMN.Turn = fila["turn"].ToString();
                lista.Add(teacherTurnMN);
            }
            return lista;

        }


        public bool deleteTeacherTurns(int idTeacher)
        {

            AccesoDatos.TeacherTurn teacherTurnAD = new AccesoDatos.TeacherTurn();
            return teacherTurnAD.deleteTeacherTurns(idTeacher);
        }
    }
}
