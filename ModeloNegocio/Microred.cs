using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class Microred
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
        private int _user_id;

        public int User_id
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        private int school_id;

        public int School_id
        {
            get { return school_id; }
            set { school_id = value; }
        }

        private int docente_id;

        public int Docente_id
        {
            get { return docente_id; }
            set { docente_id = value; }
        }

        private string _microred;

        public string MicroredName
        {
            get { return _microred; }
            set { _microred = value; }
        }
        private string _lugar_sesion;

        public string Lugar_sesion
        {
            get { return _lugar_sesion; }
            set { _lugar_sesion = value; }
        }
        private DateTime _h_inicio;

        public DateTime H_inicio
        {
            get { return _h_inicio; }
            set { _h_inicio = value; }
        }
        private DateTime h_termino;

        public DateTime H_termino
        {
            get { return h_termino; }
            set { h_termino = value; }
        }
        private int _num_participantes;

        public int Num_participantes
        {
            get { return _num_participantes; }
            set { _num_participantes = value; }
        }
        private string _educ_financiera;

        public string Educ_financiera
        {
            get { return _educ_financiera; }
            set { _educ_financiera = value; }
        }
        private string _enfoques_edu;

        public string Enfoques_edu
        {
            get { return _enfoques_edu; }
            set { _enfoques_edu = value; }
        }
        private string _programacion_ped;

        public string Programacion_ped
        {
            get { return _programacion_ped; }
            set { _programacion_ped = value; }
        }
        private string _habilidad_ped;

        public string Habilidad_ped
        {
            get { return _habilidad_ped; }
            set { _habilidad_ped = value; }
        }
        private string _trabajo_grupal;

        public string Trabajo_grupal
        {
            get { return _trabajo_grupal; }
            set { _trabajo_grupal = value; }
        }
        private string _participativo;

        public string Participativo
        {
            get { return _participativo; }
            set { _participativo = value; }
        }
        private string _expositivo;

        public string Expositivo
        {
            get { return _expositivo; }
            set { _expositivo = value; }
        }
        private string _dinamicas_ludicas;

        public string Dinamicas_ludicas
        {
            get { return _dinamicas_ludicas; }
            set { _dinamicas_ludicas = value; }
        }
        private string _recursos_informaticos;

        public string Recursos_informaticos
        {
            get { return _recursos_informaticos; }
            set { _recursos_informaticos = value; }
        }
        private string _recursos_audiovisuales;

        public string Recursos_audiovisuales
        {
            get { return _recursos_audiovisuales; }
            set { _recursos_audiovisuales = value; }
        }
        private string _materiales_didaticos;

        public string Materiales_didaticos
        {
            get { return _materiales_didaticos; }
            set { _materiales_didaticos = value; }
        }
        private string _observacion;

        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
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
