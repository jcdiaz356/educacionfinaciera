using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_IngDocente : System.Web.UI.Page
    {
        public LogicaNegocio.School ObjSchoolLN;
        public ModeloNegocio.Docente ObjDocenteMN;
        public LogicaNegocio.Docente ObjDocenteLN;
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

                cursos.Add("Historia, Geografía y Economía (HGE)");
                cursos.Add("Educación para el Trabajo (EPT)");
                cursos.Add("Matemáticas");
                cursos.Add("Otros");
                lblCursos.DataSource = cursos;
                lblCursos.DataBind();

                turnos.Add("Mañana");
                turnos.Add("Tarde");
                lblTurnos.DataSource = turnos;
                lblTurnos.DataBind();
            }

        }

        protected void rblTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
            ObjDocenteMN = new ModeloNegocio.Docente();
            ObjDocenteLN = new LogicaNegocio.Docente();

            ObjDocenteMN.Codigo = txtCodigo.Text;
            ObjDocenteMN.FullName = txtNombreApellido.Text;
            ObjDocenteMN.Email = txtCorreo.Text;
            ObjDocenteMN.Type = 4;
            ObjDocenteMN.Telefono = txtTelefono.Text;
            ObjDocenteMN.TypeContract = Convert.ToString(ddlContrato.SelectedItem);

            ObjDocenteMN.School_id = ObjDocenteLN.insertDocente(ObjDocenteMN);

            ObjUserSchoolMN = new ModeloNegocio.UserSchool();
            ObjUserSchoolLN = new LogicaNegocio.UserSchool();

            ObjUserSchoolMN.UserAsesorId = ObjDocenteMN.School_id;
            ObjUserSchoolMN.UserSchoolId = Convert.ToInt32(ddlEscuela.SelectedValue);

            ObjUserSchoolLN.insertUserSchool(ObjUserSchoolMN);

            //foreach (ListItem item in lblGradosaCargo.Items)
            //{
            //    if (item.Selected == true)
            //    {
            //        ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
            //        ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();

            //        ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
            //        ObjTeacherGradeMN.Grade= item.Text;
            //        ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);

            //    }

            //}


            if (chk1.Checked==true)
            {

                if (chk1A.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN); 
                }

                if (chk1B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk1K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk1L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1L.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1L.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
            }


            if (chk2.Checked == true)
            {

                if (chk2A.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk2B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk2K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk2L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2L.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2L.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
            }

            if (chk3.Checked == true)
            {

                if (chk3A.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk3B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk3K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk3L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3L.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3L.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
            }


            if (chk4.Checked == true)
            {

                if (chk4A.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk4B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk4K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk4L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4L.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4L.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
            }


            if (chk5.Checked == true)
            {

                if (chk5A.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk5B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk5K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk5L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5L.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5L.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
            }

            foreach (ListItem item in lblCursos.Items)
            {
                if (item.Selected == true)
                {
                    ObjTeacherCourseMN = new ModeloNegocio.TeacherCourse();
                    ObjTeacherCourseLN = new LogicaNegocio.TeacherCourse();

                    ObjTeacherCourseMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherCourseMN.Course = item.Text;

                    ObjTeacherCourseLN.insertTeacherCourse(ObjTeacherCourseMN);

                }

            }

            foreach (ListItem item in lblTurnos.Items)
            {
                if (item.Selected == true)
                {
                    ObjTeacherTurnMN = new ModeloNegocio.TeacherTurn();
                    ObjTeacherTurnLN = new LogicaNegocio.TeacherTurn();

                    ObjTeacherTurnMN.UserTeacheId = ObjDocenteMN.School_id;
                    ObjTeacherTurnMN.Turn = item.Text;

                    ObjTeacherTurnLN.insertTeacherTurn(ObjTeacherTurnMN);

                }

            }

            string strRedirect;
            strRedirect = "Admin-ListDocente.aspx?id=2";
            Response.Redirect(strRedirect, true);

        }
    }
}