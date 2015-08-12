using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloNegocio
{
    public class AconpanaClase
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
        private int _docente_id;

        public int Docente_id
        {
            get { return _docente_id; }
            set { _docente_id = value; }
        }
        private int _school_id;

        public int School_id
        {
            get { return _school_id; }
            set { _school_id = value; }
        }
        
          
        
        
        private string _id_grado_seccion;
        public string Id_Grado_seccion
        {
            get { return _id_grado_seccion; }
            set { _id_grado_seccion = value; }
        }
        private int _id_sesion;

        public int Id_sesion
        {
            get { return _id_sesion; }
            set { _id_sesion = value; }
        }
        private string _id_tema_nombre_sesion;

        public string Id_Tema_Nombre_sesion
        {
            get { return _id_tema_nombre_sesion; }
            set { _id_tema_nombre_sesion = value; }
        }
        private int _num_estudiante;

        public int Num_estudiante
        {
            get { return _num_estudiante; }
            set { _num_estudiante = value; }
        }
        private int _sesion_planificado;

        public int Sesion_planificado
        {
            get { return _sesion_planificado; }
            set { _sesion_planificado = value; }
        }
        private string _motivo;

        public string Motivo
        {
            get { return _motivo; }
            set { _motivo = value; }
        }
        private int _desarrollo_innovacion;

        public int Desarrollo_innovacion
        {
            get { return _desarrollo_innovacion; }
            set { _desarrollo_innovacion = value; }
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
        private string _materiales_didacticos;

        public string Materiales_didacticos
        {
            get { return _materiales_didacticos; }
            set { _materiales_didacticos = value; }
        }
        private string _dinamicas_utilizadas;

        public string Dinamicas_utilizadas
        {
            get { return _dinamicas_utilizadas; }
            set { _dinamicas_utilizadas = value; }
        }
        private string _otros;

        public string Otros
        {
            get { return _otros; }
            set { _otros = value; }
        }
        private int _asesor_intervino;

        public int Asesor_intervino
        {
            get { return _asesor_intervino; }
            set { _asesor_intervino = value; }
        }
        private string _como_intervino;

        public string Como_intervino
        {
            get { return _como_intervino; }
            set { _como_intervino = value; }
        }
        private int _intervencion_colaboradores;

        public int Intervencion_colaboradores
        {
            get { return _intervencion_colaboradores; }
            set { _intervencion_colaboradores = value; }
        }
        private string _colaborador;

        public string Colaborador
        {
            get { return _colaborador; }
            set { _colaborador = value; }
        }
        private string _como_intervino_colaborador;

        public string Como_intervino_colaborador
        {
            get { return _como_intervino_colaborador; }
            set { _como_intervino_colaborador = value; }
        }
        private int _participa_juego;

        public int Participa_juego
        {
            get { return _participa_juego; }
            set { _participa_juego = value; }
        }
        private string _etapa;

        public string Etapa
        {
            get { return _etapa; }
            set { _etapa = value; }
        }
        private string _razon;

        public string Razon
        {
            get { return _razon; }
            set { _razon = value; }
        }
        private string _incidencia;

        public string Incidencia
        {
            get { return _incidencia; }
            set { _incidencia = value; }
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
