using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Request.Url.AbsoluteUri.ToLower().Contains(Page.ResolveUrl(item.NavigateUrl.ToLower());
            Request.Url.AbsolutePath.ToString();
            //Debug.WriteLine(Request.Url.AbsolutePath.ToLower());
            //Debug.WriteLine(Page.R);
        }
    }
}