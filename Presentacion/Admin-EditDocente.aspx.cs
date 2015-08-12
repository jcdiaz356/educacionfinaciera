using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_EditDocente : System.Web.UI.Page
    {
        public ModeloNegocio.Docente DocenteMN;
        public LogicaNegocio.Docente DocenteLN;
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
                DocenteMN = new ModeloNegocio.Docente();
                DocenteLN = new LogicaNegocio.Docente();
                DocenteMN.id = Convert.ToInt32(Request.Params["docente_id"]);
                DocenteLN.getDocente(ref DocenteMN);

                txtCodigo.Text = DocenteMN.Codigo;
                txtNombreApellido.Text = DocenteMN.FullName;
                txtCorreo.Text = DocenteMN.Email;
                txtTelefono.Text = DocenteMN.Telefono;
                txtCorreo.Text = DocenteMN.Email;
                
                ObjSchoolLN = new LogicaNegocio.School();
                ddlEscuela.DataSource = ObjSchoolLN.getAllSchoolNoSelect();
                ddlEscuela.DataValueField = "id";
                ddlEscuela.DataTextField = "nombre";
                ddlEscuela.DataBind();
                ListItem item = ddlEscuela.Items.FindByValue(Convert.ToString(DocenteMN.School_id));
                if (item != null)
                {
                    item.Selected = true;
                }

                List<String> secciones = new List<string>();
                List<String> cursos = new List<string>();
                List<String> turnos = new List<string>();
                secciones.Add("1ro. de Secundaria");
                secciones.Add("2do. de Secundaria");
                secciones.Add("3ro. de Secundaria");
                secciones.Add("4to. de Secundaria");
                secciones.Add("5to. de Secundaria");
                //lblGradosaCargo.DataSource = secciones;
                //lblGradosaCargo.DataBind();
                ListItem item1;
                foreach (ModeloNegocio.TeacherGrade listTeachGrad in DocenteMN.TeacherGrade)
                {
                    //item1 = lblGradosaCargo.Items.FindByText(listTeachGrad.Grade);
                    //if (item1 != null)
                    //{
                    //    item1.Selected = true;
                    //}
                    if (listTeachGrad.Grade == chk1.Text)
                    {
                        chk1.Checked = true;
                        if (listTeachGrad.Seccion == chk1A.Text)
                        {
                            chk1A.Checked = true;
                            txt1A.Text = listTeachGrad.Num_alumnos.ToString();

                        }

                        if (listTeachGrad.Seccion == chk1B.Text)
                        {
                            chk1B.Checked = true;
                            txt1B.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1C.Text)
                        {
                            chk1C.Checked = true;
                            txt1C.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1D.Text)
                        {
                            chk1D.Checked = true;
                            txt1D.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1E.Text)
                        {
                            chk1E.Checked = true;
                            txt1E.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1F.Text)
                        {
                            chk1F.Checked = true;
                            txt1F.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1G.Text)
                        {
                            chk1G.Checked = true;
                            txt1G.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1H.Text)
                        {
                            chk1H.Checked = true;
                            txt1H.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1I.Text)
                        {
                            chk1I.Checked = true;
                            txt1I.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1J.Text)
                        {
                            chk1J.Checked = true;
                            txt1J.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1K.Text)
                        {
                            chk1K.Checked = true;
                            txt1K.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk1L.Text)
                        {
                            chk1L.Checked = true;
                            txt1L.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                   
                    }



                    if (listTeachGrad.Grade == chk2.Text)
                    {
                        chk2.Checked = true;
                        if (listTeachGrad.Seccion == chk2A.Text)
                        {
                            chk2A.Checked = true;
                            txt2A.Text = listTeachGrad.Num_alumnos.ToString();

                        }

                        if (listTeachGrad.Seccion == chk2B.Text)
                        {
                            chk2B.Checked = true;
                            txt2B.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2C.Text)
                        {
                            chk2C.Checked = true;
                            txt2C.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2D.Text)
                        {
                            chk2D.Checked = true;
                            txt2D.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2E.Text)
                        {
                            chk2E.Checked = true;
                            txt2E.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2F.Text)
                        {
                            chk2F.Checked = true;
                            txt2F.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2G.Text)
                        {
                            chk2G.Checked = true;
                            txt2G.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2H.Text)
                        {
                            chk2H.Checked = true;
                            txt2H.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2I.Text)
                        {
                            chk2I.Checked = true;
                            txt2I.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2J.Text)
                        {
                            chk2J.Checked = true;
                            txt2J.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2K.Text)
                        {
                            chk2K.Checked = true;
                            txt2K.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk2L.Text)
                        {
                            chk2L.Checked = true;
                            txt2L.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                    }


                    if (listTeachGrad.Grade == chk3.Text)
                    {
                        chk3.Checked = true;
                        if (listTeachGrad.Seccion == chk3A.Text)
                        {
                            chk3A.Checked = true;
                            txt3A.Text = listTeachGrad.Num_alumnos.ToString();

                        }

                        if (listTeachGrad.Seccion == chk3B.Text)
                        {
                            chk3B.Checked = true;
                            txt3B.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3C.Text)
                        {
                            chk3C.Checked = true;
                            txt3C.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3D.Text)
                        {
                            chk3D.Checked = true;
                            txt3D.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3E.Text)
                        {
                            chk3E.Checked = true;
                            txt3E.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3F.Text)
                        {
                            chk3F.Checked = true;
                            txt3F.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3G.Text)
                        {
                            chk3G.Checked = true;
                            txt3G.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3H.Text)
                        {
                            chk3H.Checked = true;
                            txt3H.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3I.Text)
                        {
                            chk3I.Checked = true;
                            txt3I.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3J.Text)
                        {
                            chk3J.Checked = true;
                            txt3J.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3K.Text)
                        {
                            chk3K.Checked = true;
                            txt3K.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk3L.Text)
                        {
                            chk3L.Checked = true;
                            txt3L.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                    }




                    if (listTeachGrad.Grade == chk4.Text)
                    {
                        chk4.Checked = true;
                        if (listTeachGrad.Seccion == chk4A.Text)
                        {
                            chk4A.Checked = true;
                            txt4A.Text = listTeachGrad.Num_alumnos.ToString();

                        }

                        if (listTeachGrad.Seccion == chk4B.Text)
                        {
                            chk4B.Checked = true;
                            txt4B.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4C.Text)
                        {
                            chk4C.Checked = true;
                            txt4C.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4D.Text)
                        {
                            chk4D.Checked = true;
                            txt4D.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4E.Text)
                        {
                            chk4E.Checked = true;
                            txt4E.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4F.Text)
                        {
                            chk4F.Checked = true;
                            txt4F.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4G.Text)
                        {
                            chk4G.Checked = true;
                            txt4G.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4H.Text)
                        {
                            chk4H.Checked = true;
                            txt4H.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4I.Text)
                        {
                            chk4I.Checked = true;
                            txt4I.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4J.Text)
                        {
                            chk4J.Checked = true;
                            txt4J.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4K.Text)
                        {
                            chk4K.Checked = true;
                            txt4K.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk4L.Text)
                        {
                            chk4L.Checked = true;
                            txt4L.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                    }




                    if (listTeachGrad.Grade == chk5.Text)
                    {
                        chk5.Checked = true;
                        if (listTeachGrad.Seccion == chk5A.Text)
                        {
                            chk5A.Checked = true;
                            txt5A.Text = listTeachGrad.Num_alumnos.ToString();

                        }

                        if (listTeachGrad.Seccion == chk5B.Text)
                        {
                            chk5B.Checked = true;
                            txt5B.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5C.Text)
                        {
                            chk5C.Checked = true;
                            txt5C.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5D.Text)
                        {
                            chk5D.Checked = true;
                            txt5D.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5E.Text)
                        {
                            chk5E.Checked = true;
                            txt5E.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5F.Text)
                        {
                            chk5F.Checked = true;
                            txt5F.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5G.Text)
                        {
                            chk5G.Checked = true;
                            txt5G.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5H.Text)
                        {
                            chk5H.Checked = true;
                            txt5H.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5I.Text)
                        {
                            chk5I.Checked = true;
                            txt5I.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5J.Text)
                        {
                            chk5J.Checked = true;
                            txt5J.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5K.Text)
                        {
                            chk5K.Checked = true;
                            txt5K.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                        if (listTeachGrad.Seccion == chk5L.Text)
                        {
                            chk5L.Checked = true;
                            txt5L.Text = listTeachGrad.Num_alumnos.ToString();

                        }
                    }

                }

                ListItem item2 = ddlContrato.Items.FindByText(Convert.ToString(DocenteMN.TypeContract));
                if (item2 != null)
                {
                    item2.Selected = true;
                }

                cursos.Add("Historia, Geografía y Economía (HGE)");
                cursos.Add("Educación para el Trabajo (EPT)");
                cursos.Add("Matemáticas");
                cursos.Add("Otros");
                lblCursos.DataSource = cursos;
                lblCursos.DataBind();
                ListItem item3;
                foreach (ModeloNegocio.TeacherCourse listTeachCours in DocenteMN.TeacherCourses)
                {
                    item3 = lblCursos.Items.FindByText(listTeachCours.Course);
                    if (item3 != null)
                    {
                        item3.Selected = true;
                    }
                }

                turnos.Add("Mañana");
                turnos.Add("Tarde");
                lblTurnos.DataSource = turnos;
                lblTurnos.DataBind();
                ListItem item4;
                foreach (ModeloNegocio.TeacherTurn listTeachTurns in DocenteMN.TeacherTurns)
                {
                    item4 = lblTurnos.Items.FindByText(listTeachTurns.Turn);
                    if (item4 != null)
                    {
                        item4.Selected = true;
                    }
                }

            }
        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
            ModeloNegocio.Docente ObjDocenteMN;
            LogicaNegocio.Docente ObjDocenteLN;

            ObjDocenteMN = new ModeloNegocio.Docente();
            ObjDocenteLN = new LogicaNegocio.Docente();


            int idDocente = Convert.ToInt32(Request.Params["docente_id"]);

            ObjDocenteMN.id = idDocente;
            ObjDocenteMN.Codigo = txtCodigo.Text;
            ObjDocenteMN.FullName = txtNombreApellido.Text;
            ObjDocenteMN.Email = txtCorreo.Text;
            ObjDocenteMN.Type = 4;
            ObjDocenteMN.Telefono = txtTelefono.Text;
            ObjDocenteMN.TypeContract = Convert.ToString(ddlContrato.SelectedItem);
            //ObjDocenteMN.School_id = Convert.ToInt32(ddlEscuela.Text);

            ObjDocenteLN.updateDocente(ObjDocenteMN);

            ObjUserSchoolMN = new ModeloNegocio.UserSchool();
            ObjUserSchoolLN = new LogicaNegocio.UserSchool();


            //Eliminamos los datos de Uuser_school
            ObjUserSchoolLN.deleteSchoolsForUserId(idDocente);


            ObjUserSchoolMN.UserAsesorId = idDocente;
            ObjUserSchoolMN.UserSchoolId = Convert.ToInt32(ddlEscuela.SelectedValue);

            ObjUserSchoolLN.insertUserSchool(ObjUserSchoolMN);


              
            ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
            ObjTeacherGradeLN.deleteTeacherGrade(idDocente) ;

        
            ObjTeacherCourseLN = new LogicaNegocio.TeacherCourse();
            ObjTeacherCourseLN.deleteTeacherCourse(idDocente);


            ObjTeacherTurnLN = new LogicaNegocio.TeacherTurn();
            ObjTeacherTurnLN.deleteTeacherTurns(idDocente);


            //foreach (ListItem item in lblGradosaCargo.Items)
            //{
            //    if (item.Selected == true)
            //    {
            //        ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
            //        ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();

            //        ObjTeacherGradeMN.UserTeacheId = idDocente;
            //        ObjTeacherGradeMN.Grade= item.Text;

            //        ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);

            //    }

            //}

            if (chk1.Checked == true)
            {

                if (chk1A.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk1B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk1J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk1K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk1.Text;
                    ObjTeacherGradeMN.Seccion = chk1K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt1K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk1L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
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
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk2B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk2J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk2K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk2.Text;
                    ObjTeacherGradeMN.Seccion = chk2K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt2K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk2L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
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
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk3B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk3J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk3K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk3.Text;
                    ObjTeacherGradeMN.Seccion = chk3K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt3K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk3L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
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
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk4B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk4J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk4K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk4.Text;
                    ObjTeacherGradeMN.Seccion = chk4K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt4K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk4L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
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
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5A.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5A.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk5B.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5B.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5B.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5C.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5C.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5C.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5D.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5D.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5D.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5E.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5E.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5E.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5F.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5F.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5F.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5G.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5G.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5G.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5H.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5H.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5H.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5I.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5I.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5I.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }
                if (chk5J.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5J.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5J.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk5K.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
                    ObjTeacherGradeMN.Grade = chk5.Text;
                    ObjTeacherGradeMN.Seccion = chk5K.Text;
                    ObjTeacherGradeMN.Num_alumnos = Convert.ToInt32(txt5K.Text);
                    ObjTeacherGradeLN.insertTeacherGrade(ObjTeacherGradeMN);
                }

                if (chk5L.Checked == true)
                {
                    ObjTeacherGradeMN = new ModeloNegocio.TeacherGrade();
                    ObjTeacherGradeLN = new LogicaNegocio.TeacherGrade();
                    ObjTeacherGradeMN.UserTeacheId = idDocente;
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

                    ObjTeacherCourseMN.UserTeacheId = idDocente;
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

                    ObjTeacherTurnMN.UserTeacheId = idDocente;
                    ObjTeacherTurnMN.Turn = item.Text;

                    ObjTeacherTurnLN.insertTeacherTurn(ObjTeacherTurnMN);

                }

            }

            string strRedirect;
            strRedirect = "Admin-ListDocente.aspx?id=1";
            Response.Redirect(strRedirect, true);

        }
        }
    
}