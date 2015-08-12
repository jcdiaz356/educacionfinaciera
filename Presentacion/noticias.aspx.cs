using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
 


namespace Presentacion
{
    public partial class noticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no autentificado redirecciona a Login
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }



            LogicaNegocio.Content objContenidoLN = new LogicaNegocio.Content();
  //-------------Inicio Paginador

            UscPaginador.caragaPaginador(20, Convert.ToInt32(Request.Params["pagina"]), objContenidoLN.countRowsContent(1));
            //---------------Fin Paginador

             List<ModeloNegocio.Content> lista = new List<ModeloNegocio.Content>();
             lista = objContenidoLN.getAllContent(20, UscPaginador.RegistrosAEmpezar, 1);
                                            foreach (ModeloNegocio.Content Content in lista)
                                            {
                                                String contenidoNota;
                                                String tituloNota;
                                                String imagen="";
                                                //ContenidoNota = Presentacion.App_Code.Global.RemoveHTMLTags("holaa"); // .RemoveHTMLTags(Content.ContentNote);

                                                contenidoNota = LogicaNegocio.GlobalFunction.RemoveHTMLTags(Content.ContentNote).Substring(0, 160);
                                                if (Content.Title.Length > 86)
                                                {
                                                    tituloNota = LogicaNegocio.GlobalFunction.RemoveHTMLTags(Content.Title).Substring(0, 85);
                                                }
                                                else
                                                {
                                                    tituloNota = LogicaNegocio.GlobalFunction.RemoveHTMLTags(Content.Title);
                                                }

                                                if (!string.IsNullOrEmpty(Content.Image))
                                                {
                                                    imagen = "<img class=\"img-responsive\" src=\"http://contigoentusfinanzasenaula.com/media/images/" + Content.Image + " \" />";
                                                }



                                                lblNoticia.Text += "<div class=\"col-md-6\">" ;
                                                lblNoticia.Text +=   "<div class=\"nota\">";
                                                lblNoticia.Text += "<div class=\"caption\">";
                                                lblNoticia.Text +=            "<h4>" + tituloNota + "...</h4>";
                                                lblNoticia.Text += imagen;
                                                lblNoticia.Text +=           "<p><a href=\"noticia-detalle.aspx?id=" + Content.Id + " \">" + contenidoNota + "...</a></p>";
                                                lblNoticia.Text += "  <p><a href=\"noticia-detalle.aspx?id=" + Content.Id + "\" class=\"btn btn-default btn-xs\" role=\"button\">Leer más</a>";
                                                lblNoticia.Text +=     "  </div>";
                                                lblNoticia.Text +=  " </div>";
                                                lblNoticia.Text += "</div>";
                                            }
          
            
        }
    }
}