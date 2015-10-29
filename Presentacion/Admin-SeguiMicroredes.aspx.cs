using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiMicroredes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            LogicaNegocio.Microred microredes = new LogicaNegocio.Microred();
            List<ModeloNegocio.Microred> listMicrored = new List<ModeloNegocio.Microred>();
            int NumRegistrosEmpezar;
            
           




            if (Request.Params["asesor_id"] != null)
            {
                int asesor_id = Convert.ToInt32(Request.Params["asesor_id"]);
                NumRegistrosEmpezar = 0;
                listMicrored = microredes.getAllMicroredesPorAsesor(asesor_id, 200, UscPaginador.RegistrosAEmpezar);

            }
            else
            {
                //-------------Inicio Paginador
                UscPaginador.caragaPaginador(100, Convert.ToInt32(Request.Params["pagina"]), microredes.countRowsMicroredes());
                //---------------Fin Paginador

                NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
                listMicrored = microredes.getAllMicroredes(100, UscPaginador.RegistrosAEmpezar);
            }





            foreach (ModeloNegocio.Microred Micro in listMicrored)
            {
                ModeloNegocio.Asesor asesorMN = new ModeloNegocio.Asesor();
                LogicaNegocio.Asesor asesorLN = new LogicaNegocio.Asesor();

                asesorMN = asesorLN.getAsesorId(Micro.User_id);

                NumRegistrosEmpezar++;

                FilasListaMicroredes.Text += "<tr id='" + Micro.Id + "'>";
                FilasListaMicroredes.Text += "<th scope=row>" + NumRegistrosEmpezar + "</th>";
                FilasListaMicroredes.Text += "<td>" + asesorMN.FullName + "</td>";
                FilasListaMicroredes.Text += "<td>" + Micro.MicroredName + "</td>";
                FilasListaMicroredes.Text += "<td>" + Micro.Fecha.ToString("dd-MM-yyyy") + "</td>";
                FilasListaMicroredes.Text += "<td>";
                //FilasListaMicroredes.Text += "<a href='" + "Admin-SeguiEditMicroredes.aspx?microred_id=" + Micro.Id + "&id=1'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar Microred'></span></a>";
                FilasListaMicroredes.Text += "<a href='" + "Admin-SeguiViewMicroredes.aspx?microred_id=" + Micro.Id + "&id=1'><span class='glyphicon glyphicon glyphicon-zoom-in' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver datos de la Microred'></span></a>";
                FilasListaMicroredes.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar a <b>" + Micro.MicroredName + "</b> ','" + Micro.Id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar Microred'></span></a>";
                
                FilasListaMicroredes.Text += "</td></tr>";
            }


            
            



            //lblPaginador.Text +="<nav>";
            //lblPaginador.Text +="<ul class=\"pagination\">" ;
            
            //lblPaginador.Text +="</li>";
           
            //for (int i = 1; i <= PagUlt; i++)
            //{

            //    string activate = "";
            //    if (Convert.ToInt32(PagAct) == i)
            //    {
            //        activate = "active";
            //    }
                

                 
            //    lblPaginador.Text +="<li class='"+ activate +"'><a href=\"Admin-SeguiMicroredes.aspx?pagina=" + i + "&id=1\">" + i + "</a></li>";
                
            //}
            
            //lblPaginador.Text += "</ul>";
            //lblPaginador.Text += "</nav>";


            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            LogicaNegocio.Asesor LNAsesor = new LogicaNegocio.Asesor();
            ModeloNegocio.Asesor MNAsesor = new ModeloNegocio.Asesor();

            MNAsesor = LNAsesor.getAsesorCode(txtCodDocente.Text);
            string strRedirect;
            strRedirect = "Admin-SeguiMicroredes.aspx?asesor_id=" + MNAsesor.id;
            Response.Redirect(strRedirect, true);
        }
    }
}