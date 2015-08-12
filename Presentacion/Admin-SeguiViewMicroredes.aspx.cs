using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiViewMicroredes : System.Web.UI.Page
    {

        public ModeloNegocio.Microred microredMN;
        public LogicaNegocio.Microred microredLN;

        public ModeloNegocio.MicroredDocente microredDocenteMN;
        public LogicaNegocio.MicroredDocente microredDocenteLN;

        public ModeloNegocio.MicroredSchool microredSchoolMN;
        public LogicaNegocio.MicroredSchool microredSchoolLN;

        public ModeloNegocio.Asesor asesorMN;
        public LogicaNegocio.Asesor asesorLN;

        

        public ModeloNegocio.Docente docenteMN;
        public LogicaNegocio.Docente docenteLN;

        public ModeloNegocio.School schoolMN;
        public LogicaNegocio.School schoolLN;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                microredMN = new ModeloNegocio.Microred();
                microredLN = new LogicaNegocio.Microred();

                int microred_id = Convert.ToInt32(Request.Params["microred_id"]);
                microredMN = microredLN.getMicroredId(microred_id);



                txtFecha.Text = microredMN.Fecha.ToString("yyyy-MM-dd");

                asesorLN = new LogicaNegocio.Asesor();
                asesorMN = new ModeloNegocio.Asesor();
                asesorMN = asesorLN.getAsesorId(microredMN.User_id);
                txtAsesor.Text = asesorMN.FullName;


                microredDocenteMN = new ModeloNegocio.MicroredDocente();
                microredDocenteLN = new LogicaNegocio.MicroredDocente();
                List<ModeloNegocio.MicroredDocente> listaMicroredDocente =new  List<ModeloNegocio.MicroredDocente>();

                listaMicroredDocente = microredDocenteLN.getAllMicroredDocenteForIdMicrored(microred_id);
                foreach (ModeloNegocio.MicroredDocente microredDocente in listaMicroredDocente)
                {

                    docenteLN = new LogicaNegocio.Docente();
                    docenteMN = new ModeloNegocio.Docente();
                    docenteMN = docenteLN.getDocenteId(microredDocente.Docente_id);

                    ddlDocente.Items.Add(new ListItem(docenteMN.FullName,docenteMN.id.ToString() ));
                       
                }



                microredSchoolMN = new ModeloNegocio.MicroredSchool();
                microredSchoolLN = new LogicaNegocio.MicroredSchool();
                List<ModeloNegocio.MicroredSchool> listaMicroredSchool = new List<ModeloNegocio.MicroredSchool>();

                listaMicroredSchool = microredSchoolLN.getAllMicroredSchoolForIdMicrored(microred_id);
                foreach (ModeloNegocio.MicroredSchool microredSchool in listaMicroredSchool)
                {

                    schoolLN = new LogicaNegocio.School();
                    schoolMN = new ModeloNegocio.School();
                    schoolMN = schoolLN.getSchool(microredSchool.School_id);

                    ddlSchool.Items.Add(new ListItem(schoolMN.Nombre, schoolMN.id.ToString()));

                }

                txtMircrored.Text = microredMN.MicroredName;
                txtSesion.Text = microredMN.Lugar_sesion;
                txtInicio.Text = microredMN.H_inicio.ToString("hh:mm:ss");
                txtTermino.Text = microredMN.H_termino.ToString("hh:mm:ss");
                txtParticipante.Text = Convert.ToString(microredMN.Num_participantes);
                txtEducacion.Text = microredMN.Educ_financiera;
                txtEnfoque.Text = microredMN.Enfoques_edu;
                txtProgramacion.Text = microredMN.Programacion_ped;
                txtHabilidades.Text = microredMN.Habilidad_ped;
                txtTrabajo.Text = microredMN.Trabajo_grupal;
                txtParticipativo.Text = microredMN.Participativo;
                txtExpositivo.Text = microredMN.Expositivo;
                txtDinamicas.Text = microredMN.Dinamicas_ludicas;
                txtRecursos.Text = microredMN.Recursos_informaticos;
                txtAudiovisuales.Text = microredMN.Recursos_audiovisuales;
                txtMateriales.Text = microredMN.Materiales_didaticos;
                txtObservacion.Text = microredMN.Observacion;


            }
        }

        protected void CmdVolver_Click(object sender, EventArgs e)
        {
            string strRedirect;
            strRedirect = "Admin-SeguiMicroredes.aspx?id=1";
            Response.Redirect(strRedirect, true);
        }

     

    }
}