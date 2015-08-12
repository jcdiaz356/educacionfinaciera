using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.UscControl
{
    public partial class Noticias : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.Content objContenidoLN = new LogicaNegocio.Content();
            List<ModeloNegocio.Content> lista = new List<ModeloNegocio.Content>();
            lista = objContenidoLN.getAllContent(4, 0, 1);
            foreach (ModeloNegocio.Content Content in lista)
            {
                String contenidoNota;
                String tituloNota;
                String imagen = "";
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

                //<h1>titulo</h1>
                //            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Modi nihil quos saepe ut.  cum exercitationem illo nesciunt quos!</p>

               // lblNoticia.Text += "<div class=\"col-md-6\">";
               // lblNoticia.Text += "<div class=\"nota\">";
              //  lblNoticia.Text += "<div class=\"caption\">";
                lblNoticia.Text += "<h6>" + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tituloNota.ToLower()) +"...</h6>";
                
                //lblNoticia.Text += imagen;
               // lblNoticia.Text += "<p><a href=\"noticia-detalle.aspx?id=" + Content.Id + " \">" + contenidoNota + "...</a></p>";
                lblNoticia.Text += "  <p><a href=\"noticia-detalle.aspx?id=" + Content.Id + "\" class=\"btn btn-default btn-xs\" role=\"button\">Leer más</a>";
              //  lblNoticia.Text += "  </div>";
              //  lblNoticia.Text += " </div>";
              //  lblNoticia.Text += "</div>";
            }
        }
    }
}