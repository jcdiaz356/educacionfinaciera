using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;
using LogicaNegocio;
using ModeloNegocio;

namespace Presentacion
{
    public partial class Admin_IngEscuela : System.Web.UI.Page
    {
        LogicaNegocio.Ugel ObjUgelLN;
        LogicaNegocio.Distrito ObjDistritoLN;

        LogicaNegocio.School ObjSchoolLN;
        ModeloNegocio.School ObjSchoolMN;


        private DataTable DtUgel, DtDistritos;
        protected void Page_Load(object sender, EventArgs e)
        {
            


            if (!IsPostBack)
            {
                //Configurar Entradas
                txtCodigo.Attributes["placeholder"] = "Ingrese Código";
                txtNombreEscuela.Attributes["placeholder"] = "Ingrese Nombres y Número de la Escuela";
                txtDireccion.Attributes["placeholder"] = "Ingrese Dirección";
                referencia.Attributes["placeholder"] = "Ingrese Referencia";
                ObjDistritoLN = new LogicaNegocio.Distrito();
                ObjUgelLN = new LogicaNegocio.Ugel();

                DtDistritos = ObjDistritoLN.getAllDistritos(1);
                DdlDistrito.DataSource = DtDistritos;
                DdlDistrito.DataValueField = "id";
                DdlDistrito.DataTextField = "nombre";
                DdlDistrito.DataBind();

                DtUgel = ObjUgelLN.getAllUgels();
                DdlUgel.DataSource = DtUgel;
                DdlUgel.DataValueField = "id";
                DdlUgel.DataTextField = "nombre";
                DdlUgel.DataBind();
            }     


        }

        protected void CmdGuardar_Click(object sender, EventArgs e)
        {
            ObjSchoolLN = new LogicaNegocio.School();
            ObjSchoolMN = new ModeloNegocio.School();

            //ObjSchoolMN
            ObjSchoolMN.Codigo = txtCodigo.Text;
            ObjSchoolMN.Nombre = txtNombreEscuela.Text;
            ObjSchoolMN.Direccion = txtDireccion.Text;
            ObjSchoolMN.Telefono = txtTelefono.Text;
            ObjSchoolMN.Ugel_id = Convert.ToInt32(DdlUgel.Text);
            ObjSchoolMN.Distrito_id = Convert.ToInt32(DdlDistrito.Text);
            ObjSchoolMN.Referencia = referencia.Text;
            ObjSchoolMN.Latitud = "";
            ObjSchoolMN.Longitud = "";
            ObjSchoolMN.Director = "";
            ObjSchoolMN.Subdirector = "";
            if (NumDocHGE.Text == "")
            {
                ObjSchoolMN.Num_Doc_hge = 0;
            }
            else
            {
                ObjSchoolMN.Num_Doc_hge = Convert.ToInt32(NumDocHGE.Text);
            }
          
                ObjSchoolMN.Num_doc_inicial = 0;
      
           
                ObjSchoolMN.Num_doc_primaria = 0;
           
           
                ObjSchoolMN.Num_doc_secundaria = 0;
           
           
                ObjSchoolMN.Num_alum_ini = 0;
           
             
                ObjSchoolMN.Num_alum_prim = 0;
            
            
            if (NumAlumSec.Text == "")
            {
                ObjSchoolMN.Num_alum_sec = 0;
            }
            else
            {
                ObjSchoolMN.Num_alum_sec = Convert.ToInt32(NumAlumSec.Text);
            }
            
                ObjSchoolMN.Num_aulas = 0;
           
            
                ObjSchoolMN.Num_secc_prim = 0;
            
            if (NumSeccSec.Text == "")
            {
                ObjSchoolMN.Num_secc_sec = 0;
            }
            else
            {
                ObjSchoolMN.Num_secc_sec = Convert.ToInt32(NumSeccSec.Text);
            }
            

            ObjSchoolLN.insertSchool(ObjSchoolMN);
                string strRedirect;
                strRedirect = "Admin-ListEscuela.aspx?id=3";
                Response.Redirect(strRedirect, true);
           

            

        }

    }
}