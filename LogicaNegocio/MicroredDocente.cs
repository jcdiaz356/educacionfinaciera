using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class MicroredDocente
    {

        public int insertMicroredDocente(ModeloNegocio.MicroredDocente ObjMicroredDocente)
        {
            AccesoDatos.MicroredDocente microred = new AccesoDatos.MicroredDocente();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return microred.insertMicroredDocente(ObjMicroredDocente);
        }

        public List<ModeloNegocio.MicroredDocente> getAllMicroredDocenteForIdMicrored(int idMicrored)
        {
            AccesoDatos.MicroredDocente microred = new AccesoDatos.MicroredDocente();
            return microred.getAllMicroredDocenteForIdMicrored(idMicrored);
        }

    }
}
