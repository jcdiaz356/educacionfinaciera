using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace LogicaNegocio
{
    public class VisitaIE
    {

        public List<ModeloNegocio.VisitaIE> getAllVisitas(int registroAMostrar, int registroAEmpezar)
        {
            AccesoDatos.VisitaIE aconpanaClase = new AccesoDatos.VisitaIE();
            //AccesoDatos.UserSchool userSchool = new AccesoDatos.UserSchool();
            //return userSchool.updateSelectSchoolForIduser(idSchool, value);
            return aconpanaClase.getAllVisitas(registroAMostrar, registroAEmpezar);
        }

        public ModeloNegocio.VisitaIE getVisitaId(int visita_id)
        {
            AccesoDatos.VisitaIE visita = new AccesoDatos.VisitaIE();

            return visita.getVisitaId(visita_id);
        }

        public int insertVisitas(ModeloNegocio.VisitaIE ObjAconpanaClase)
        {
            AccesoDatos.VisitaIE visita = new AccesoDatos.VisitaIE();

            return visita.insertVisita(ObjAconpanaClase);
        }

        public int countRowsVisitas()
        {
            AccesoDatos.VisitaIE visitaIE = new AccesoDatos.VisitaIE();
            return visitaIE.countRowsVisitas();

        }

        public bool deleteVisitaIE(int idVisita)
        {
            AccesoDatos.VisitaIE microred = new AccesoDatos.VisitaIE();

            microred.deleteVisitaIE(idVisita);
            return true;
        }

        public DataTable getCountVisitsForAgent()
        {

            AccesoDatos.VisitaIE visitaAD = new AccesoDatos.VisitaIE();
            return visitaAD.getCountVisitsForAgent();
        }

        public DataTable getCountVisitsForSchool()
        {

            AccesoDatos.VisitaIE visitaAD = new AccesoDatos.VisitaIE();
            return visitaAD.getCountVisitsForSchool();
        }

        public DataTable getReportAllVisitasIE()
        {
            AccesoDatos.VisitaIE acompClaseAD = new AccesoDatos.VisitaIE();
            return acompClaseAD.getReportAllVisitasIE();

        }
    }
}
