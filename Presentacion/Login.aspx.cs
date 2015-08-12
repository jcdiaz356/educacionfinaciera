using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Presentacion
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LogicaNegocio.User usersLN = new LogicaNegocio.User();
            //ModeloNegocio.User user = new ModeloNegocio.User();
            //Label1.Text = usersLN.Encrypt("123456");

           

        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {

            LogicaNegocio.User usersLN = new LogicaNegocio.User();
            ModeloNegocio.Asesor user= new ModeloNegocio.Asesor();
            user = usersLN.loginUsuario(txtEmail.Text, txtPassword.Text);


            if (user.id == 0)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('No se encontró al usuario!');", true);
            }
            else
            {
               // ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alert('Bien!');", true);
                FormsAuthentication.RedirectFromLoginPage(user.FullName,false);
                Session["id"] = user.id;
                Session["idTipoUser"] = user.typeUser.Id;
                Session["name"] = user.FullName;
                Session["type"] = user.typeUser.Name;
                Session["email"] = user.Email;

                //.
                if (user.typeUser.Id==1)
                {
                    string strRedirect;
                    strRedirect = "Admin-Users.aspx";
                    Response.Redirect(strRedirect, true);
                }
                else if(user.typeUser.Id==4)
                {
                    string strRedirect;
                    strRedirect = "Default.aspx";
                    Response.Redirect(strRedirect, true);
                }
                
            }

           // Label1.Text = usersLN.encriptaPassword("123456");

        }
    }
}