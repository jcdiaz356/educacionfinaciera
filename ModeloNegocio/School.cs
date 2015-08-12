using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class School
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _codigo;

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }


        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _ugel_id;

        public int Ugel_id
        {
            get { return _ugel_id; }
            set { _ugel_id = value; }
        }

        private string _Ugel;

        public string Ugel
        {
            get { return _Ugel; }
            set { _Ugel = value; }
        }

        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        private int _distrito_id;

        public int Distrito_id
        {
            get { return _distrito_id; }
            set { _distrito_id = value; }
        }

        private string _referencia;

        public string Referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }

        private string _latitud;

        public string Latitud
        {
            get { return _latitud; }
            set { _latitud = value; }
        }

        private string _longitud;

        public string Longitud
        {
            get { return _longitud; }
            set { _longitud = value; }
        }

        private string _director;

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        private string _subdirector;

        public string Subdirector
        {
            get { return _subdirector; }
            set { _subdirector = value; }
        }

        private int _num_Doc_hge;

        public int Num_Doc_hge
        {
            get { return _num_Doc_hge; }
            set { _num_Doc_hge = value; }
        }

        private int _num_doc_inicial;

        public int Num_doc_inicial
        {
            get { return _num_doc_inicial; }
            set { _num_doc_inicial = value; }
        }

        private int _num_doc_primaria;

        public int Num_doc_primaria
        {
            get { return _num_doc_primaria; }
            set { _num_doc_primaria = value; }
        }

        private int _num_doc_secundaria;

        public int Num_doc_secundaria
        {
            get { return _num_doc_secundaria; }
            set { _num_doc_secundaria = value; }
        }

        private int _num_alum_ini;

        public int Num_alum_ini
        {
            get { return _num_alum_ini; }
            set { _num_alum_ini = value; }
        }

        private int _num_alum_prim;

        public int Num_alum_prim
        {
            get { return _num_alum_prim; }
            set { _num_alum_prim = value; }
        }

        private int _num_alum_sec;

        public int Num_alum_sec
        {
            get { return _num_alum_sec; }
            set { _num_alum_sec = value; }
        }

        private int _num_aulas;

        public int Num_aulas
        {
            get { return _num_aulas; }
            set { _num_aulas = value; }
        }

        private int _num_secc_prim;

        public int Num_secc_prim
        {
            get { return _num_secc_prim; }
            set { _num_secc_prim = value; }
        }

        private int _num_secc_sec;

        public int Num_secc_sec
        {
            get { return _num_secc_sec; }
            set { _num_secc_sec = value; }
        }

        private DateTime _fCreado;
        public DateTime FechaCreado
        {
            get { return _fCreado; }
            set { _fCreado = value; }
        }

        private DateTime _fActualizado;
        public DateTime FechaActualizado
        {
            get { return _fActualizado; }
            set { _fActualizado = value; }
        }

        private List<Docente> _Docente;

        public List<Docente> Docente
        {
            get { return _Docente; }
            set { _Docente = value; }
        }

       
    }
}
