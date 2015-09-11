using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class Microred
    {

        public List<ModeloNegocio.Microred> getAllMicroredes(int registroAMostrar, int registroAEmpezar)
        {
            AccesoDatos.Microred microred = new AccesoDatos.Microred();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return microred.getAllMicroredes(registroAMostrar, registroAEmpezar);
        }

        public ModeloNegocio.Microred getMicroredId(int microred_id)
        {
            AccesoDatos.Microred microred = new AccesoDatos.Microred();
            
            return microred.getMicroredId(microred_id);

        }
        public int insertMicrored( ModeloNegocio.Microred ObjMicrored)
        {
            AccesoDatos.Microred microred = new AccesoDatos.Microred();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return microred.insertMicrored(ObjMicrored);
        }

        public int countRowsMicroredes()
        {
            AccesoDatos.Microred microred = new AccesoDatos.Microred();
            return microred.countRowsMicroredes();

        }

        public bool deleteMicrored(int idMicrored)
        {
            AccesoDatos.Microred microred = new AccesoDatos.Microred();

            microred.deleteMicrored(idMicrored);
           return true;
        }

        public DataTable getCountMicroredesForAgent()
        {

            AccesoDatos.Microred acompClaseAD = new AccesoDatos.Microred();
            return acompClaseAD.getCountMicroredesForAgent();
        }
    }
}
