using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_IngAsesor : System.Web.UI.Page

    {
        public LogicaNegocio.UserTeacher ObjUserDocenteLN;
        public LogicaNegocio.UserSchool ObjUserSchoolLN  ;
        public LogicaNegocio.Asesor ObjAsesorLN;
        public LogicaNegocio.School ObjSchoolLN;
        public LogicaNegocio.Docente ObjDocenteLN;

        public ModeloNegocio.UserTeacher ObjUserDocenteMN;
        public ModeloNegocio.UserSchool ObjUserSchoolMN;
        public ModeloNegocio.Asesor ObjAsesorMN;
        public ModeloNegocio.School ObjSchoolMN;
        public ModeloNegocio.Docente ObjDocenteMN;

        



        protected void Page_Load(object sender, EventArgs e)
        {
            //

            if (!IsPostBack)
            {
                //Configurar Entradas
                //txtCodigo.Attributes["placeholder"] = "Ingrese Código";
                //txtNombreEscuela.Attributes["placeholder"] = "Ingrese Nombres y Número de la Escuela";
                //txtDireccion.Attributes["placeholder"] = "Ingrese Dirección";
                //referencia.Attributes["placeholder"] = "Ingrese Referencia";
                ObjDocenteLN = new LogicaNegocio.Docente();
                ObjSchoolLN = new LogicaNegocio.School();

                lblEscuelaACargo.DataSource = ObjSchoolLN.getAllSchool();
                lblEscuelaACargo.DataValueField = "id";
                lblEscuelaACargo.DataTextField = "nombre";
                lblEscuelaACargo.DataBind();


                //lblDocenteCaCargo.DataSource = ObjDocenteLN.getAllDocente();
                //lblDocenteCaCargo.DataValueField = "id";
                //lblDocenteCaCargo.DataTextField = "FullName";
                //lblDocenteCaCargo.DataBind();

               
            }

            //ScriptManager.RegisterStartupScript(this, GetType(), "YourChangeEventJS(ddl)", "alert(ddl.selectedIndex);", true);
        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
           
           

            //foreach (ListItem item in lblEscuelaACargo.Items)  {
            //    TimeslotItems += item.ToString() + " - " + item.Value.ToString() +  ","; // /n to print each item on new line or you omit /n to print text on same line
               
            //    System.Console.WriteLine("abc");
            //    Console.Out.WriteLine("Hello World!");
            //}

            ObjAsesorMN = new ModeloNegocio.Asesor();
            ObjAsesorLN = new LogicaNegocio.Asesor();
            ObjAsesorMN.Codigo = txtCodigo.Text;
            ObjAsesorMN.FullName = txtNombre.Text;
            ObjAsesorMN.Telefono = txtTelefono.Text;
            ObjAsesorMN.Type = 7; //7 es el tipo asesor
            ObjAsesorMN.Grupo = Convert.ToString(ddlGrupo.SelectedItem);


            ObjAsesorMN.id = ObjAsesorLN.insertAsesor(ObjAsesorMN);
                




            //string TimeslotItems = "";
            
            foreach (ListItem item in lblEscuelaACargo.Items)
            {
                if (item.Selected ==  true)
                {
                    ObjUserSchoolMN = new ModeloNegocio.UserSchool();
                    ObjUserSchoolLN = new LogicaNegocio.UserSchool();

                    ObjUserSchoolMN.UserAsesorId = ObjAsesorMN.id;
                    ObjUserSchoolMN.UserSchoolId = Convert.ToInt32(item.Value) ;

                    ObjUserSchoolLN.insertUserSchool(ObjUserSchoolMN);
                   // TimeslotItems += item.ToString() + " - " + item.Value.ToString() + ","; // /n to print each item on new line or you omit /n to print text on same line
                   // System.Console.WriteLine("abc");
                   // Console.Out.WriteLine("Hello World!");
                }
                
            }

            //foreach (ListItem item in lblDocenteCaCargo.Items)
            //{
            //    if (item.Selected ==  true)
            //    {
            //        ObjUserDocenteMN = new ModeloNegocio.UserTeacher();
            //        ObjUserDocenteLN = new LogicaNegocio.UserTeacher();

            //        ObjUserDocenteMN.UserAsesorId = ObjAsesorMN.id;
            //        ObjUserDocenteMN.UserTeacheId = Convert.ToInt32(item.Value);

            //        ObjUserDocenteLN.insertUserTeacher(ObjUserDocenteMN);

            //    }
                
            //}

            string strRedirect;
            strRedirect = "Admin-ListAsesor.aspx?id=1";
            Response.Redirect(strRedirect, true);

        }

        protected void lblEscuelaACargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count=0;
            foreach (ListItem item in lblEscuelaACargo.Items)
            {
                if (item.Selected == true)
                {
                    count ++;
                }
                txtDocenteACargo.Text = count.ToString();

            }
        }
    }
}