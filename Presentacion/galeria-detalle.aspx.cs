using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class galeria_detalle : System.Web.UI.Page
    {

        private LogicaNegocio.GaleriaContenido objGaleriaContenidoLN;
        private ModeloNegocio.GaleriaContenido objGaleriaContenidoMN;


        private int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.Params["id"]))
            {
                id = Convert.ToInt32(Request.Params["id"]);
                //objGaleriaContenidoMN = new ModeloNegocio.GaleriaContenido();

                objGaleriaContenidoLN = new LogicaNegocio.GaleriaContenido();
                //objGaleriaContenidoMN = objGaleriaContenidoLN.getAllGaleriaContenidoId(id);

                //objGaleriaContenidoMN = new ModeloNegocio.GaleriaContenido();


                //string imagen = "";

                //if (!string.IsNullOrEmpty(objContentMN.Image))
                //{
                //    imagen = "<img class=\"img-responsive\" src=\"http://contigoentusfinanzasenaula.com/media/images/" + objContentMN.Image + " \" />";
                //}


                //lblDetalleNoticia.Text += "<h1>" + objContentMN.Title + "</h1>";
                //lblDetalleNoticia.Text += imagen;
                //lblDetalleNoticia.Text += objContentMN.ContentNote;


                List<ModeloNegocio.GaleriaContenido> lista = objGaleriaContenidoLN.getAllGaleriaContenidoId(id);
                lblGaleria.Text = "<div class=\"row gallery thumbnails\">";
                if (lista.Count > 0)
                {
                    foreach (ModeloNegocio.GaleriaContenido galeria in lista)
                    {
                        lblGaleria.Text += "<div class=\"col-md-4\">";
                        lblGaleria.Text += "<a href=\"http://contigoentusfinanzasenaula.com/media/images/" + galeria.Source + "\" class=\"zoom1\" data-fancybox-group=\"button\" title=\" " + galeria.Description + " \">";
                        //lblGaleria.Text += "<a href=\"galeria-detalle.aspx?id=" + galeria.Id + "\"  data-fancybox-group=\"button\">";
                        lblGaleria.Text += "<img class=\"img-responsive\" src=\"http://contigoentusfinanzasenaula.com/media/images/" + galeria.Source + "\"   />";
                        lblGaleria.Text += " <div>";
                        lblGaleria.Text += "<span>";
                        lblGaleria.Text += "<img  src=\"img/zoom.png\" >";
                        lblGaleria.Text += "VER IMÁGEN";
                        lblGaleria.Text += "</span>";
                        lblGaleria.Text += "</div>";
                        lblGaleria.Text += "</a>";
                        lblGaleria.Text += "</div>";

                        lblTitulo.Text = "<h4>" +galeria.Name_galeria + "</h4>";
                    }
                }

                lblGaleria.Text += "</div>";





            }
        }
    }
}