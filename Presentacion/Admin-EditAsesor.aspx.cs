using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_EditAsesor : System.Web.UI.Page
    {
        public ModeloNegocio.Asesor AsesorMN;
        public LogicaNegocio.Asesor AsesorLN;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AsesorMN = new ModeloNegocio.Asesor();
                AsesorLN = new LogicaNegocio.Asesor();
                if (Request.Params["asesor_id"] == "")
                {
                    AsesorMN.id = Convert.ToInt32(30);
                }
                else
                {
                    AsesorMN.id = Convert.ToInt32(Request.Params["asesor_id"]);
                }
                
                AsesorLN.getAsesor(ref AsesorMN);
                txtCodigo.Text = AsesorMN.Codigo;
                txtNombre.Text = AsesorMN.FullName;
                txtTelefono.Text = AsesorMN.Telefono;

                LogicaNegocio.School ObjSchoolLN = new LogicaNegocio.School();
                lblEscuelaACargo.DataSource = ObjSchoolLN.getAllSchool();
                lblEscuelaACargo.DataValueField = "id";
                lblEscuelaACargo.DataTextField = "Nombre";
                lblEscuelaACargo.DataBind();
                
                int c=0;
                foreach(ModeloNegocio.School listSchool in AsesorMN.Schools)
                {
                    lblEscuelaACargo.Items.Insert(c, new ListItem(listSchool.Nombre, Convert.ToString(listSchool.id)));
                    lblEscuelaACargo.Items[c].Selected = true;
                    c = c + 1;
                }
                txtDocenteACargo.Text = Convert.ToString(c);

                LogicaNegocio.Docente ObjDocenteLN = new LogicaNegocio.Docente();
                //lblDocenteCaCargo.DataSource = ObjDocenteLN.getAllDocente();
                //lblDocenteCaCargo.DataValueField = "id";
                //lblDocenteCaCargo.DataTextField = "FullName";
                //lblDocenteCaCargo.DataBind();
                c = 0;
                //foreach (ModeloNegocio.User listTeacher in AsesorMN.Teachers)
                //{
                //    lblDocenteCaCargo.Items.Insert(c, new ListItem(listTeacher.FullName, Convert.ToString(listTeacher.id)));
                //    lblDocenteCaCargo.Items[c].Selected = true;
                //    c = c + 1;
                //}
                //txtDocenteACargo.Text = Convert.ToString(c);
                ListItem item = ddlGrupo.Items.FindByText(AsesorMN.Grupo);
                if (item != null)
                {
                    item.Selected = true;
                }
                 

            }
        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
            LogicaNegocio.UserTeacher userTeacher;
            LogicaNegocio.UserSchool userSchool;
            ModeloNegocio.UserSchool ObjUserSchoolMN;
            ModeloNegocio.UserTeacher ObjUserDocenteMN;
            AsesorMN = new ModeloNegocio.Asesor();
            AsesorLN = new LogicaNegocio.Asesor();
            AsesorMN.id = Convert.ToInt32(Request.Params["asesor_id"]);
            AsesorLN.getAsesor(ref AsesorMN);


            userSchool = new LogicaNegocio.UserSchool();
            foreach (ModeloNegocio.School listSchool in AsesorMN.Schools)
            {
                
                userSchool.updateSelectSchoolForIduser(listSchool.id, 0);
            }


            userSchool.deleteSchoolsForUserId(AsesorMN.id);




            foreach (ListItem item in lblEscuelaACargo.Items)
            {
                if (item.Selected == true)
                {
                    ObjUserSchoolMN = new ModeloNegocio.UserSchool();
                    userSchool = new LogicaNegocio.UserSchool();

                    ObjUserSchoolMN.UserAsesorId = AsesorMN.id;
                    ObjUserSchoolMN.UserSchoolId = Convert.ToInt32(item.Value);

                    userSchool.insertUserSchool(ObjUserSchoolMN);
                }
            }


            userTeacher = new LogicaNegocio.UserTeacher();
            foreach (ModeloNegocio.User teacherLista in AsesorMN.Teachers)
            {
                
                userTeacher.updateSelectTeacherForIduser(teacherLista.id, 0);
            }

            userTeacher.deleteTeachersForUserId(AsesorMN.id);


            //foreach (ListItem item in lblDocenteCaCargo.Items)
            //{
            //    if (item.Selected == true)
            //    {
            //        ObjUserDocenteMN = new ModeloNegocio.UserTeacher();
            //        userTeacher = new LogicaNegocio.UserTeacher();

            //        ObjUserDocenteMN.UserAsesorId = AsesorMN.id;
            //        ObjUserDocenteMN.UserTeacheId = Convert.ToInt32(item.Value);

            //        userTeacher.insertUserTeacher(ObjUserDocenteMN);

            //    }

            //}
            AsesorMN.Codigo = txtCodigo.Text;
            AsesorMN.FullName = txtNombre.Text;
            AsesorMN.Telefono = txtTelefono.Text;
            AsesorMN.Grupo = Convert.ToString(ddlGrupo.SelectedItem);
            AsesorMN.FechaActualizado = DateTime.Now;
            AsesorLN = new LogicaNegocio.Asesor();
            AsesorLN.updateAsesor(AsesorMN);

            string strRedirect;
            strRedirect = "Admin-ListAsesor.aspx?id=1";
            Response.Redirect(strRedirect, true);
        }
    }
}