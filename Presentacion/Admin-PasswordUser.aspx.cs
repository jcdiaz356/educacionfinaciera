using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_PasswordUser : System.Web.UI.Page
    {


        
        public LogicaNegocio.Asesor ObjAsesorLN;
        public ModeloNegocio.Asesor ObjAsesorMN;
        public int asesor_id;
      
        protected void Page_Load(object sender, EventArgs e)
        {

            asesor_id = Convert.ToInt32(Request["user_id"]);
            ObjAsesorLN = new LogicaNegocio.Asesor();
            ObjAsesorMN = new ModeloNegocio.Asesor();

            ObjAsesorMN = ObjAsesorLN.getAsesorId(asesor_id);

            lblUsuario.Text = "Usuario: " + ObjAsesorMN.FullName;
            //if (ObjAsesorMN.Email == null || ObjAsesorMN.Email == "")
            //{
            //    txtCorreo.Text = ObjAsesorMN.Email;
            //}

            if (!IsPostBack)
            {

                txtCorreo.Text = ObjAsesorMN.Email;

            }


        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
            ObjAsesorLN = new LogicaNegocio.Asesor();

            if (ObjAsesorLN.setPasswordUser(asesor_id, txtCorreo.Text, txtPassword.Text))
            {
                string strRedirect;

                if (Request.Params["password"] == "asesor")
                {
                    strRedirect = "Admin-ListAsesor.aspx?id=1&success=true";
                    Response.Redirect(strRedirect, true);
                }
                if (Request.Params["password"] == "docente")
                {
                    strRedirect = "Admin-ListDocente.aspx?id=2&success=true";
                    Response.Redirect(strRedirect, true);
                }
                if (Request.Params["password"] == "director")
                {
                    strRedirect = "Admin-ListDirector.aspx?id=4&success=true";
                    Response.Redirect(strRedirect, true);
                }
                
            }    
          


        }
    }
}