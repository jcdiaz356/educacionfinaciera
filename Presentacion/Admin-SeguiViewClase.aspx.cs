using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiViewClase : System.Web.UI.Page
    {
        public ModeloNegocio.AconpanaClase aconpanaClaseMN;
        public LogicaNegocio.AconpanaClase aconpanaClaseLN;

        public ModeloNegocio.Asesor asesorMN;
        public LogicaNegocio.Asesor asesorLN;   

        public ModeloNegocio.Docente docenteMN;
        public LogicaNegocio.Docente docenteLN;

        public ModeloNegocio.School schoolMN;
        public LogicaNegocio.School schoolLN;

        public ModeloNegocio.TeacherGrade teacherGradeMN;
        public LogicaNegocio.TeacherGrade teacherGradeLN;

        public ModeloNegocio.Tema temaMN;
        public LogicaNegocio.Tema temaLN;

        public ModeloNegocio.Sesion sesionMN;
        public LogicaNegocio.Sesion sesionLN;




        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                aconpanaClaseMN = new ModeloNegocio.AconpanaClase();
                aconpanaClaseLN = new LogicaNegocio.AconpanaClase();
                int aconpana_id = Convert.ToInt32(Request.Params["aconpana_id"]);

                aconpanaClaseMN = aconpanaClaseLN.getAconpanaClaseId(aconpana_id);

                txtFecha.Text = aconpanaClaseMN.Fecha.ToString("yyyy-MM-dd");

                asesorLN = new LogicaNegocio.Asesor();
                asesorMN = new ModeloNegocio.Asesor();
                asesorMN = asesorLN.getAsesorId(aconpanaClaseMN.Asesor_id);
                txtAsesor.Text = asesorMN.FullName;


                docenteLN = new LogicaNegocio.Docente();
                docenteMN = new ModeloNegocio.Docente();
                docenteMN = docenteLN.getDocenteId(aconpanaClaseMN.Docente_id);
                txtDocente.Text = docenteMN.FullName;


                schoolLN = new LogicaNegocio.School();
                schoolMN = new ModeloNegocio.School();

                //schoolMN = schoolLN.getDocenteId(visitaMN.Docente_id);
                schoolMN = schoolLN.getSchool(aconpanaClaseMN.School_id);

                txtSchool.Text = schoolMN.Nombre.ToString();


                teacherGradeLN = new LogicaNegocio.TeacherGrade();
                teacherGradeMN = new ModeloNegocio.TeacherGrade();

                teacherGradeMN = teacherGradeLN.getTeacherGradeId(Convert.ToInt32(aconpanaClaseMN.Id_Grado_seccion));

                txtGradoSeccion.Text = "Grado: " +  teacherGradeMN.Grade.ToString() + " Seccion: " + teacherGradeMN.Seccion.ToString();
                


                temaLN = new LogicaNegocio.Tema();
                temaMN = new ModeloNegocio.Tema();

                temaMN = temaLN.getTemaId(Convert.ToInt32(aconpanaClaseMN.Id_Tema_Nombre_sesion));

                txtNombSesion.Text = temaMN.Name;



                sesionLN = new LogicaNegocio.Sesion();
                sesionMN = new ModeloNegocio.Sesion();

                sesionMN = sesionLN.getSesionId(Convert.ToInt32(aconpanaClaseMN.Id_sesion));

                txtNumSesion.Text = sesionMN.NumSesion;


                txtEstidianteAsistentes.Text = aconpanaClaseMN.Num_estudiante.ToString();

                if(aconpanaClaseMN.Sesion_planificado == 0) {
                    txtSesionPlanificado.Text = "No (" + aconpanaClaseMN.Motivo + ")";
                } else if(aconpanaClaseMN.Sesion_planificado == 1) {
                     txtSesionPlanificado.Text = "Si";
                }

                if (aconpanaClaseMN.Desarrollo_innovacion == 0)
                {
                    txtInnovacion.Text = "No";
                }
                else if (aconpanaClaseMN.Desarrollo_innovacion == 1)
                {
                    txtInnovacion.Text = "Si";
                }



                txtRecursosInformáticos.Text = aconpanaClaseMN.Recursos_informaticos;

                txtRecursosAudiovisuales.Text = aconpanaClaseMN.Recursos_audiovisuales;

                txtMaterialesDidactico.Text = aconpanaClaseMN.Materiales_didacticos;

                txtDinamicasUsadas.Text = aconpanaClaseMN.Dinamicas_utilizadas;

                TxtOtros.Text = aconpanaClaseMN.Otros;

                if (aconpanaClaseMN.Asesor_intervino == 0)
                {
                    txtIntervino.Text = "No";
                }
                else if (aconpanaClaseMN.Desarrollo_innovacion == 1)
                {
                    txtIntervino.Text = "Si";
                }

                txtComoIntervinoSesion.Text = aconpanaClaseMN.Como_intervino;

                if (aconpanaClaseMN.Intervencion_colaboradores == 0)
                {
                    txtOtrosColaboradores.Text = "No";
                }
                else if (aconpanaClaseMN.Intervencion_colaboradores == 1)
                {
                    txtOtrosColaboradores.Text = "Si";
                }

                txtQuien.Text = aconpanaClaseMN.Colaborador;

                txtComoIntervino.Text = aconpanaClaseMN.Como_intervino;


                if (aconpanaClaseMN.Participa_juego == 0)
                {
                    txtParticipaJuego.Text = "No";
                }
                else if (aconpanaClaseMN.Participa_juego == 1)
                {
                    txtParticipaJuego.Text = "Si";
                }


                txtEtapa.Text = aconpanaClaseMN.Etapa;
                txtRazon.Text = aconpanaClaseMN.Razon;
                txtIncidencia.Text = aconpanaClaseMN.Incidencia;

                //txtMotivoVisita.Text = visitaMN.MotivoVisita;

                //txtObservacion.Text = visitaMN.Observacion;
                //TxtPendientes.Text = visitaMN.Pendientes;

            }


        }

        protected void cmdVolver_Click(object sender, EventArgs e)
        {
            string strRedirect;
            strRedirect = "Admin-SeguiClase.aspx?id=2";
            Response.Redirect(strRedirect, true);
        }
    }
}