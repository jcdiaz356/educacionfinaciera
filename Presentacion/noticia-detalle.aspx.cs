using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class noticia_detalle : System.Web.UI.Page
    {
        private LogicaNegocio.Content objContentLN;
        private LogicaNegocio.Comment objCommentLN;
        private ModeloNegocio.Content objContentMN;
        private ModeloNegocio.Comment objCommentMN;

        private int id = 0;

       // private ModeloNegocio.Comment objCommentMN;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no autentificado redirecciona a Login
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
            if (!IsPostBack)
            {
            
                    if (!string.IsNullOrEmpty(Request.Params["id"]))
                    {
                        id= Convert.ToInt32(Request.Params["id"]);
                        objContentMN = new ModeloNegocio.Content();

                        objContentLN = new LogicaNegocio.Content();
                        objContentMN = objContentLN.getContentId(id);

                        objCommentMN = new ModeloNegocio.Comment();


                        string imagen = "";

                        if (!string.IsNullOrEmpty(objContentMN.Image))
                         {
                             imagen = "<img class=\"img-responsive\" src=\"http://contigoentusfinanzasenaula.com/media/images/" + objContentMN.Image + " \" />";
                          }


                        lblDetalleNoticia.Text +=  "<h1>" + objContentMN.Title + "</h1>";
                        lblDetalleNoticia.Text +=   imagen ;
                        lblDetalleNoticia.Text +=  objContentMN.ContentNote ;


                        List<ModeloNegocio.Comment> lista = objContentMN.Comment;

                        if (lista.Count > 0)
                        {
                            foreach (ModeloNegocio.Comment comment in lista) {
                                lblComentario.Text += "<blockquote>";

                                lblComentario.Text += "<h4>Correo: " + comment.EmailAuthor + " <small>Fecha: " + comment.Created_at + "</small></h4>";
                                lblComentario.Text +=  "<p>" + comment.CommentContent + "</p>";
                                lblComentario.Text +=  "</blockquote>";
                            }
                        }
                       
                        
                        
 

                    }



            
            }
            

        }

        protected void cmdGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.Params["id"]);
            objCommentMN = new ModeloNegocio.Comment();
            objCommentLN = new LogicaNegocio.Comment();

            String IPAdd   ;
            IPAdd = Request.UserHostAddress;
            

            
  
        //If String.IsNullOrEmpty(IPAdd) Then  
        //    IPAdd = Request.ServerVariables("REMOTE_ADDR")  
        //    lblIPBehindProxy.Text = IPAdd  
        //End If  


            objCommentMN.CommentContent = txtComentario.Text;
            objCommentMN.EmailAuthor = txtEmail.Text;
            objCommentMN.IdCotent = id ;
            objCommentMN.IpAuthor = IPAdd;

            objCommentLN.insertComment(objCommentMN);

            string strRedirect;
            strRedirect = "noticia-detalle.aspx?id=" + id.ToString();
            Response.Redirect(strRedirect, true);





        }
    }
}