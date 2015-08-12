using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_EditSubDirector : System.Web.UI.Page
    {
        public ModeloNegocio.Director DirectorMN;
        public LogicaNegocio.Director DirectorLN;
        public LogicaNegocio.School ObjSchoolLN;


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
                DirectorMN = new ModeloNegocio.Director();
                DirectorLN = new LogicaNegocio.Director();
                DirectorMN.id = Convert.ToInt32(Request.Params["subdirector_id"]);
                DirectorLN.getDirector(ref DirectorMN);

                txtCodigo.Text = DirectorMN.Codigo;
                txtNombreApellido.Text = DirectorMN.FullName;
                txtCorreo.Text = DirectorMN.Email;
                txtTelefono.Text = DirectorMN.Telefono;
                txtCorreo.Text = DirectorMN.Email;

                ObjSchoolLN = new LogicaNegocio.School();
                ddlEscuela.DataSource = ObjSchoolLN.getAllSchoolNoSelect();
                ddlEscuela.DataValueField = "id";
                ddlEscuela.DataTextField = "nombre";
                ddlEscuela.DataBind();
                ListItem item = ddlEscuela.Items.FindByValue(Convert.ToString(DirectorMN.School_id));
                if (item != null)
                {
                    item.Selected = true;
                }






            }
        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
            ModeloNegocio.Docente ObjDocenteMN;
            LogicaNegocio.Docente ObjDocenteLN;

            ObjDocenteMN = new ModeloNegocio.Docente();
            ObjDocenteLN = new LogicaNegocio.Docente();


            int idDocente = Convert.ToInt32(Request.Params["subdirector_id"]);

            ObjDocenteMN.id = idDocente;
            ObjDocenteMN.Codigo = txtCodigo.Text;
            ObjDocenteMN.FullName = txtNombreApellido.Text;
            ObjDocenteMN.Email = txtCorreo.Text;
            ObjDocenteMN.Type = 9;
            ObjDocenteMN.Telefono = txtTelefono.Text;
            ObjDocenteMN.TypeContract = "";
            //ObjDocenteMN.School_id = Convert.ToInt32(ddlEscuela.Text);

            ObjDocenteLN.updateDocente(ObjDocenteMN);

            ObjUserSchoolMN = new ModeloNegocio.UserSchool();
            ObjUserSchoolLN = new LogicaNegocio.UserSchool();


            //Eliminamos los datos de Uuser_school
            ObjUserSchoolLN.deleteSchoolsForUserId(idDocente);


            ObjUserSchoolMN.UserAsesorId = idDocente;
            ObjUserSchoolMN.UserSchoolId = Convert.ToInt32(ddlEscuela.SelectedValue);

            ObjUserSchoolLN.insertUserSchool(ObjUserSchoolMN);







            string strRedirect;
            strRedirect = "Admin-ListSubDirector.aspx?id=5";
            Response.Redirect(strRedirect, true);

        }
    }
}