using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class testimonio : System.Web.UI.Page
    {
        private Int16 idConten;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no autentificado redirecciona a Login
            //if (!this.Page.User.Identity.IsAuthenticated)
            //{
            //    FormsAuthentication.RedirectToLoginPage();
            //}
            idConten = Convert.ToInt16(Request.QueryString["id"]);

            //objLNContent = new LogicaNegocio.Content();
            //objMNContent = new ModeloNegocio.Content();

            //objMNContent = objLNContent.getContentId(idConten);

            if (idConten == 12)
            {
                lblTitulo.Text = "Historia";
                lblContent.Text += "<p>Aun Pendiente. </p>";
            }
            if (idConten == 13)
            {
                lblTitulo.Text = "Videos";
                lblContent.Text += "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube-nocookie.com/embed/videoseries?list=PLZgJHRxG688Puvlr5ZU2MXb8h4aOnZYvv&amp;showinfo=0\" frameborder=\"0\" allowfullscreen></iframe><br>";
                lblContent.Text += "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/P-yJQd2IPig?list=PLZgJHRxG688Np6jkWpmXBAw13D0nOTgFE\" frameborder=\"0\" allowfullscreen></iframe><br>";
                lblContent.Text += "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube-nocookie.com/embed/videoseries?list=PLZgJHRxG688MUWBJj6e5_9LLQmMHP3fM-&amp;showinfo=0\" frameborder=\"0\" allowfullscreen></iframe><br>";
                lblContent.Text += "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube-nocookie.com/embed/videoseries?list=PLZgJHRxG688MXRWRHIs-uTvpaVb8NoKF1&amp;showinfo=0\" frameborder=\"0\" allowfullscreen></iframe>";
            }
            
        }
    }
}