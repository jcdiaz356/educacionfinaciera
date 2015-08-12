using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_IngDirector : System.Web.UI.Page
    {
        public LogicaNegocio.School ObjSchoolLN;
        public ModeloNegocio.Director ObjDirectorMN;
        public LogicaNegocio.Director ObjDirectorLN;
        public ModeloNegocio.UserSchool ObjUserSchoolMN;
        public LogicaNegocio.UserSchool ObjUserSchoolLN;
        public ModeloNegocio.TeacherGrade ObjTeacherGradeMN;
        public LogicaNegocio.TeacherGrade ObjTeacherGradeLN;
        public ModeloNegocio.TeacherCourse ObjTeacherCourseMN;
        public LogicaNegocio.TeacherCourse ObjTeacherCourseLN;
        public ModeloNegocio.TeacherTurn ObjTeacherTurnMN;
        public LogicaNegocio.TeacherTurn ObjTeacherTurnLN;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                ObjSchoolLN = new LogicaNegocio.School();
                List<String> secciones = new List<string>();
                List<String> cursos = new List<string>();
                List<String> turnos = new List<string>();

                //secciones.Add("1ro. de Secundaria");
                //secciones.Add("2do. de Secundaria");
                //secciones.Add("3ro. de Secundaria");
                //secciones.Add("4to. de Secundaria");
                //secciones.Add("5to. de Secundaria");
                //lblGradosaCargo.DataSource = secciones;
                //lblGradosaCargo.DataBind();

                ddlEscuela.DataSource = ObjSchoolLN.getAllSchoolNoSelect();
                ddlEscuela.DataValueField = "id";
                ddlEscuela.DataTextField = "nombre";
                ddlEscuela.DataBind();


            }


        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
            ObjDirectorMN = new ModeloNegocio.Director();
            ObjDirectorLN = new LogicaNegocio.Director();

            ObjDirectorMN.Codigo = txtCodigo.Text;
            ObjDirectorMN.FullName = txtNombreApellido.Text;
            ObjDirectorMN.Email = txtCorreo.Text;
            ObjDirectorMN.Type = 8;
            ObjDirectorMN.Telefono = txtTelefono.Text;
            //ObjDirectorMN.TypeContract = Convert.ToString(ddlContrato.SelectedItem);

            ObjDirectorMN.School_id = ObjDirectorLN.insertDirector(ObjDirectorMN);

            ObjUserSchoolMN = new ModeloNegocio.UserSchool();
            ObjUserSchoolLN = new LogicaNegocio.UserSchool();

            ObjUserSchoolMN.UserAsesorId = ObjDirectorMN.School_id;
            ObjUserSchoolMN.UserSchoolId = Convert.ToInt32(ddlEscuela.SelectedValue);

            ObjUserSchoolLN.insertUserSchool(ObjUserSchoolMN);







            string strRedirect;
            strRedirect = "Admin-ListDirector.aspx?id=4";
            Response.Redirect(strRedirect, true);

        }

    }
       
}