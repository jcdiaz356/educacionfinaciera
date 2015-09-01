using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class School
    {
        public ModeloNegocio.School insertSchool(ModeloNegocio.School ObjSchool)
        {
             
            AccesoDatos.School school = new AccesoDatos.School();
            //school.insertSchool(ObjSchool);
            return school.insertSchool(ObjSchool);
            
        }

        public List<ModeloNegocio.School> getAllSchool(int registroAMostrar, int registroAEmpezar)
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.School school = new AccesoDatos.School();

            return school.getAllSchool(registroAMostrar, registroAEmpezar);

        }

        public List<ModeloNegocio.School> getAllSchoolNoSelect()
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.School school = new AccesoDatos.School();

            return school.getAllSchoolNoSelect();

        }

        public List<ModeloNegocio.Docente> getAllDocenteSchool(int idShool)
        {
            AccesoDatos.School school = new AccesoDatos.School();

            return school.getAllDocenteSchool(idShool);
        }

        public ModeloNegocio.Director getDirectorSchool(int idShool)
        {
            AccesoDatos.School school = new AccesoDatos.School();

            return school.getDirectorSchool(idShool);
        }

        public List<ModeloNegocio.School> getAllSchool()
        {
            //LogicaNegocioa.UsuarioLN objListaUsuario = new LogicaNegocio.UsuarioLN();
            AccesoDatos.School school = new AccesoDatos.School();

            return school.getAllSchool();

        }

        public bool deleteSchool(int idSchool)
        {
            AccesoDatos.School school;


            school = new AccesoDatos.School();
            school.deleteSchool(idSchool);


            return true;
        }

        public bool updateSchool(ModeloNegocio.School ObjSchool)
        {
            AccesoDatos.School school;


            school = new AccesoDatos.School();
            school.updateSchool(ObjSchool);


            return true;
        }

        public void getSchool(ref ModeloNegocio.School ObjSchool)
        {
            AccesoDatos.School school = new AccesoDatos.School();
            school.getSchool(ref ObjSchool);
            
        }


        public ModeloNegocio.School getSchool(int school_id)
        {
            AccesoDatos.School school = new AccesoDatos.School();
            return school.getSchool(school_id);

        }
        public int countRowsSchool()
        {
            AccesoDatos.School school = new AccesoDatos.School();
            return school.countRowsSchool();

        }

        public DataTable countSchoolForUgel()
        {

            AccesoDatos.School schoolAD = new AccesoDatos.School();
            return schoolAD.getCountSchoolForUgel();
        }

        public DataTable countStudentsForSchool()
        {

            AccesoDatos.School schoolAD = new AccesoDatos.School();
            return schoolAD.getCountStudentsForSchool();
        }

        public DataTable countSchoolForAsesor()
        {

            AccesoDatos.School schoolAD = new AccesoDatos.School();
            return schoolAD.getCountSchoolForAsesor();
        }
      
    }
}
