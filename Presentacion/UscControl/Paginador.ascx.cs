using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.UscControl
{

    public partial class Paginador : System.Web.UI.UserControl
    {
        //public void SetText(string theText)
        //{
        //    //this.lblPaginador.Text = theText;
        //}

      
        private int _registrosAMostrar;

        public int RegistrosAMostrar
        {
            get { return _registrosAMostrar; }
            set { _registrosAMostrar = value; }
        }

        private int _registrosAEmpezar;

        public int RegistrosAEmpezar
        {
            get { return _registrosAEmpezar; }
            set { _registrosAEmpezar = value; }
        }

        //private int _nroRegistros;

        //public int NroRegistros
        //{
        //    get { return _nroRegistros; }
        //    set { _nroRegistros = value; }
        //}
        //private string _paginaResultados;

        //public string PaginaResultados
        //{
        //    get { return _paginaResultados; }
        //    set { _paginaResultados = value; }
        //}

        //private int _pagina;

        //public int Pagina
        //{
        //    get { return _pagina; }
        //    set { _pagina = value; }
        //}


        public void caragaPaginador(int registrosAMostrar , int pagina, int nroRegistros)
        {

            double PagUlt = Convert.ToInt32(nroRegistros) / registrosAMostrar;
            //calculo cuantas paginas tendra mi paginacion
            int Res = Convert.ToInt32(nroRegistros) % registrosAMostrar; //Hallando el resto

            int PagAct = 1;

            if (Res > 0)
            {
                PagUlt = Math.Floor(PagUlt) + 1;
            }

            if (pagina == null || pagina == 0)
            {
                _registrosAEmpezar = 0;
                PagAct = 1;
            }
            else
            {
                _registrosAEmpezar = (Convert.ToInt32(pagina) - 1) * registrosAMostrar;
                PagAct = Convert.ToInt32(pagina);
            }

            lblPaginador.Text += "<nav>";
            lblPaginador.Text += "<ul class=\"pagination\">";
            lblPaginador.Text += "</li>";

            for (int i = 1; i <= PagUlt; i++)
            {
                string activate = "";
                if (Convert.ToInt32(PagAct) == i)
                {
                    activate = "active";
                }



                lblPaginador.Text += "<li class='" + activate + "'><a href=\"?pagina=" + i + " \">" + i + "</a></li>";

               // lblPaginador.Text += "<li class='" + activate + "'><a href=\"?pagina=" + i + "&id=1\">" + i + "</a></li>";
            }
            lblPaginador.Text += "</ul>";
            lblPaginador.Text += "</nav>";
        }

        protected void Page_Load(object sender, EventArgs e)
        {


           

        }
    }
}