using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicaNegocio
{
    public class MicroredSchool
    {
        public int insertMicroredSchool(ModeloNegocio.MicroredSchool ObjMicroredSchool)
        {
            AccesoDatos.MicroredSchool microred = new AccesoDatos.MicroredSchool();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return microred.insertMicroredSchool(ObjMicroredSchool);
        }


        public List<ModeloNegocio.MicroredSchool> getAllMicroredSchoolForIdMicrored(int idMicrored)
        {
            AccesoDatos.MicroredSchool microred = new AccesoDatos.MicroredSchool();

            return microred.getAllMicroredSchoolForIdMicrored(idMicrored);
        }
    }
}
