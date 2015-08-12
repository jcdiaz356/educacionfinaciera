using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_EditEscuela : System.Web.UI.Page
    {
        public ModeloNegocio.School SchoolMN;
        public LogicaNegocio.School SchoolLN;
        LogicaNegocio.Ugel ObjUgelLN;
        LogicaNegocio.Distrito ObjDistritoLN;

        private DataTable DtUgel, DtDistritos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SchoolMN = new ModeloNegocio.School();
                SchoolMN.id = Convert.ToInt32(Request.Params["school_id"]);
                SchoolLN = new LogicaNegocio.School();
                SchoolLN.getSchool(ref SchoolMN);
                txtCodigo.Text = SchoolMN.Codigo;
                txtNombreEscuela.Text = SchoolMN.Nombre;
                txtTelefono.Text = SchoolMN.Telefono;
                txtDireccion.Text = SchoolMN.Direccion;

                ObjDistritoLN = new LogicaNegocio.Distrito();
                DtDistritos = ObjDistritoLN.getAllDistritos(1);
                DdlDistrito.DataSource = DtDistritos;
                DdlDistrito.DataValueField = "id";
                DdlDistrito.DataTextField = "nombre";
                DdlDistrito.DataBind();
                ListItem item = DdlDistrito.Items.FindByValue(Convert.ToString(SchoolMN.Distrito_id));
                if (item != null)
                {
                    item.Selected = true;
                }

                referencia.Text = SchoolMN.Referencia;

                ObjUgelLN = new LogicaNegocio.Ugel();
                DtUgel = ObjUgelLN.getAllUgels();
                DdlUgel.DataSource = DtUgel;
                DdlUgel.DataValueField = "id";
                DdlUgel.DataTextField = "nombre";
                DdlUgel.DataBind();
                ListItem item1 = DdlUgel.Items.FindByValue(Convert.ToString(SchoolMN.Ugel_id));
                if (item1 != null)
                {
                    item1.Selected = true;
                }

                //director.Text = SchoolMN.Director;
                //SubDirector.Text = SchoolMN.Subdirector;
                NumDocHGE.Text = Convert.ToString(SchoolMN.Num_Doc_hge);
               // NumDocIni.Text = Convert.ToString(SchoolMN.Num_doc_inicial);
              //  NumDocPrim.Text = Convert.ToString(SchoolMN.Num_doc_primaria);
                NumDocSec.Text = Convert.ToString(SchoolMN.Num_doc_secundaria);
               // NumAlumIni.Text = Convert.ToString(SchoolMN.Num_alum_ini);
              //  NumAlumPrim.Text = Convert.ToString(SchoolMN.Num_alum_prim);
                NumAlumSec.Text = Convert.ToString(SchoolMN.Num_alum_sec);
              //  NumAulas.Text = Convert.ToString(SchoolMN.Num_aulas);
             //   NumSeccPrim.Text = Convert.ToString(SchoolMN.Num_secc_prim);
                NumSeccSec.Text = Convert.ToString(SchoolMN.Num_secc_sec);
                latitud.Text = SchoolMN.Latitud;
                longitud.Text = SchoolMN.Longitud;
            }
        }

        protected void CmdGuardar_Click(object sender, EventArgs e)
        {
            SchoolMN = new ModeloNegocio.School();
            SchoolLN = new LogicaNegocio.School();

            SchoolMN.id = Convert.ToInt32(Request.Params["school_id"]);
            SchoolMN.Codigo =txtCodigo.Text;
            SchoolMN.Nombre = txtNombreEscuela.Text;
            SchoolMN.Telefono = txtTelefono.Text;
            SchoolMN.Direccion = txtDireccion.Text;
            SchoolMN.Distrito_id = Convert.ToInt32(DdlDistrito.Text);
            SchoolMN.Ugel_id = Convert.ToInt32(DdlUgel.Text);
            SchoolMN.Referencia = referencia.Text;
            SchoolMN.Latitud = latitud.Text;
            SchoolMN.Longitud = longitud.Text;
            SchoolMN.Director = "";
            SchoolMN.Subdirector = "";
            if (NumDocHGE.Text == "")
            {
                SchoolMN.Num_Doc_hge = 0;
            }
            else
            {
                SchoolMN.Num_Doc_hge = Convert.ToInt32(NumDocHGE.Text);
            }
           
                SchoolMN.Num_doc_inicial = 0;
            
           
                SchoolMN.Num_doc_primaria = 0;
           
            if (NumDocSec.Text == "")
            {
                SchoolMN.Num_doc_secundaria = 0;
            }
            else
            {
                SchoolMN.Num_doc_secundaria = Convert.ToInt32(NumDocSec.Text);
            }
           
                SchoolMN.Num_alum_ini = 0;
           
           
                SchoolMN.Num_alum_prim = 0;
           
            if (NumAlumSec.Text == "")
            {
                SchoolMN.Num_alum_sec = 0;
            }
            else
            {
                SchoolMN.Num_alum_sec = Convert.ToInt32(NumAlumSec.Text);
            }
           
                SchoolMN.Num_aulas = 0;
          
           
                SchoolMN.Num_secc_prim = 0;
           
            if (NumSeccSec.Text == "")
            {
                SchoolMN.Num_secc_sec = 0;
            }
            else
            {
                SchoolMN.Num_secc_sec = Convert.ToInt32(NumSeccSec.Text);
            }

            SchoolLN.updateSchool(SchoolMN);
            string strRedirect;
            strRedirect = "Admin-ListEscuela.aspx?id=3";
            Response.Redirect(strRedirect, true);
        }
    }
}