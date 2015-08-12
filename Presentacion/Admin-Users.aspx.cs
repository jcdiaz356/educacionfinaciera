using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.User users = new LogicaNegocio.User();
            List<ModeloNegocio.Asesor> listUsuario = new List<ModeloNegocio.Asesor>();

            listUsuario=users.getAllUsers();


            //List<string> locations;  // however this initialized 

            //StringBuilder sb = new StringBuilder();

            //sb.Append("<ul id=\"tabs\">");

            //for (int i = 0; i < listUsuario.Count; i++)
            //{
            //   //sb.Append("<li id=\"tab" + listUsuario[i].Id.ToString() + "\"><a href=\"" + listUsuario[i].FullName.ToString() + "\">Tab " + listUsuario[i].Email.ToString() + "</a></li>");
            //    ListView1.Items.Add(listUsuario[i].FullName.ToString());

            //    listUsuario[i].FullName.ToString();
            //}


            GridView1.DataSource = listUsuario;
            GridView1.DataBind();
            //sb.Append("</ul>");
        }
    }
}