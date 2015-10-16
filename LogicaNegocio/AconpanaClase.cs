using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class AconpanaClase
    {
        public List<ModeloNegocio.AconpanaClase> getAllAconpanaClase(int registroAMostrar, int registroAEmpezar)
        {
            AccesoDatos.AconpanaClase aconpanaClase = new AccesoDatos.AconpanaClase();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return aconpanaClase.getAllAconpanaClase(registroAMostrar, registroAEmpezar);
        }
        public int insertAconpanaClase(ModeloNegocio.AconpanaClase ObjAconpanaClase)
        {
            AccesoDatos.AconpanaClase aconpanaClase = new AccesoDatos.AconpanaClase();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return aconpanaClase.insertAconpanaClase(ObjAconpanaClase);
        }

        public ModeloNegocio.AconpanaClase getAconpanaClaseId(int aconpanaClaseid)
        {
            AccesoDatos.AconpanaClase aconpanaClase = new AccesoDatos.AconpanaClase();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return aconpanaClase.getAconpanaClaseId(aconpanaClaseid);
        }

        public int countRowsAconpanaClase()
        {
            AccesoDatos.AconpanaClase aconpanaClase = new AccesoDatos.AconpanaClase();
            return aconpanaClase.countRowsAconpanaClase();

        }

        public bool deleteMicrored(int idAconpanaClase)
        {
            AccesoDatos.AconpanaClase microred = new AccesoDatos.AconpanaClase();

            microred.deleteAconpanaClase(idAconpanaClase);
            return true;
        }

        public DataTable getCountAcompForAgent()
        {

            AccesoDatos.AconpanaClase acompClaseAD = new AccesoDatos.AconpanaClase();
            return acompClaseAD.getCountAcompForAgent();
        }

        public DataTable getCountAcompForTeacher()
        {

            AccesoDatos.AconpanaClase acompClaseAD = new AccesoDatos.AconpanaClase();
            return acompClaseAD.getCountAcompForTeacher();
        }

        public int countBloquesForIdTeacher(int teacher_id)
        {
            AccesoDatos.AconpanaClase aconpanaClase = new AccesoDatos.AconpanaClase();
            return aconpanaClase.getCountBloquesForIdTeacher(teacher_id);

        }
    }
}
