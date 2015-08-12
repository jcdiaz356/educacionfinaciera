using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class galeria : System.Web.UI.Page
    {
        private ModeloNegocio.Galeria  objGaleriaMN ;
        private LogicaNegocio.Galeria objGaleriaLN ;


        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no autentificado redirecciona a Login
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();

            }

            objGaleriaLN = new LogicaNegocio.Galeria();
            objGaleriaMN = new ModeloNegocio.Galeria();
            List<ModeloNegocio.Galeria> lista = new List<ModeloNegocio.Galeria>();

           lista = objGaleriaLN.getAllGaleria(20,0,1);

            lblGaleria.Text="<div class=\"row gallery thumbnails\">";
                 
            if (lista.Count > 0)
                        {
                            foreach (ModeloNegocio.Galeria galeria in lista) {
                                 lblGaleria.Text += "<div class=\"col-md-4\">";
                                 //lblGaleria.Text += "<a href=\"img/imagen1.jpg\" class=\"zoom1\" data-fancybox-group=\"button\">";
                                 lblGaleria.Text += "<a href=\"galeria-detalle.aspx?id=" + galeria.Id + "\"  data-fancybox-group=\"button\">";
                                 lblGaleria.Text += "<img class=\"img-responsive\" src=\"http://contigoentusfinanzasenaula.com/media/images/"+ galeria.Image +"\"   />";
                                 lblGaleria.Text +=             " <div>";
                                 lblGaleria.Text +=                 "<span>";
                                 lblGaleria.Text +=                     "<img  src=\"img/zoom.png\" >";
                                 lblGaleria.Text +=                         galeria.Name;
                                 lblGaleria.Text +=                 "</span>";
                                 lblGaleria.Text +=        "</div>";
                                 lblGaleria.Text +=     "</a>";
                                 lblGaleria.Text += "</div>";
                            }
                        }
            lblGaleria.Text+="</div>";
           
        }
    }
}