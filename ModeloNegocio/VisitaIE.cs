using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class VisitaIE
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _fecha;

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        private int _asesor_id;

        public int Asesor_id
        {
            get { return _asesor_id; }
            set { _asesor_id = value; }
        }

        private int _school_id;

        public int School_id
        {
            get { return _school_id; }
            set { _school_id = value; }
        }

        private int _docente_id;

        public int Docente_id
        {
            get { return _docente_id; }
            set { _docente_id = value; }
        }

        private int _director_id;

        public int Director_id
        {
            get { return _director_id; }
            set { _director_id = value; }
        }


        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _motivoVisita;

        public string MotivoVisita
        {
            get { return _motivoVisita; }
            set { _motivoVisita = value; }
        }

        private string _observacion;

        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }


        private string _pendientes;

        public string Pendientes
        {
            get { return _pendientes; }
            set { _pendientes = value; }
        }
        private DateTime _created_at;

        public DateTime Created_at
        {
            get { return _created_at; }
            set { _created_at = value; }
        }
        private DateTime _updated_at;

        public DateTime Updated_at
        {
            get { return _updated_at; }
            set { _updated_at = value; }
        }

    }
}
