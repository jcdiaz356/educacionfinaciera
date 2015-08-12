using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class Admin_SeguiClase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LogicaNegocio.AconpanaClase aconpanaClase = new LogicaNegocio.AconpanaClase();
            List<ModeloNegocio.AconpanaClase> listAconpanaClase = new List<ModeloNegocio.AconpanaClase>();


            //-------------Inicio Paginador

            UscPaginador.caragaPaginador(100, Convert.ToInt32(Request.Params["pagina"]), aconpanaClase.countRowsAconpanaClase());
            //---------------Fin Paginador

            int NumRegistrosEmpezar = UscPaginador.RegistrosAEmpezar;
            listAconpanaClase = aconpanaClase.getAllAconpanaClase(100, UscPaginador.RegistrosAEmpezar);
            foreach (ModeloNegocio.AconpanaClase Aconpana in listAconpanaClase)
            {
                ModeloNegocio.Asesor asesorMN = new ModeloNegocio.Asesor();
                LogicaNegocio.Asesor asesorLN = new LogicaNegocio.Asesor();

                ModeloNegocio.Docente docenteMN = new ModeloNegocio.Docente();
                LogicaNegocio.Docente docenteLN = new LogicaNegocio.Docente();

                asesorMN = asesorLN.getAsesorId(Aconpana.Asesor_id);
                docenteMN = docenteLN.getDocenteId(Aconpana.Docente_id);

                NumRegistrosEmpezar++;

                FilasLista.Text += "<tr id='" + Aconpana.Id + "'>";
                FilasLista.Text += "<th scope=row>" + NumRegistrosEmpezar + "</th>";
                FilasLista.Text += "<td>" + asesorMN.FullName + "</td>";
                FilasLista.Text += "<td>" + docenteMN.FullName + "</td>";
                FilasLista.Text += "<td>" + Aconpana.Fecha.ToString("dd-MM-yyyy") + "</td>";
                FilasLista.Text += "<td>";
               // FilasLista.Text += "<a href='" + "Admin-Segui.aspx?asesor_id=" + Aconpana.Id + "'><span class='glyphicon glyphicon-pencil' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Editar seguimiento a clase'></span></a>";
                FilasLista.Text += "<a href='" + "Admin-SeguiViewClase.aspx?aconpana_id=" + Aconpana.Id + "&id=2'><span class='glyphicon glyphicon-zoom-in' aria-hidden='true' data-toggle='tooltip' data-placement='bottom' title='Ver  seguimiento a clase'></span></a>";
                FilasLista.Text += "<a href='" + "#" + "' onClick=\"javascript:showMyModalSetTitle('Eliminar', 'Está seguro que desea eliminar  <b>" + Aconpana.Id_Tema_Nombre_sesion + "</b> ','" + Aconpana.Id + "')\"'><span class='glyphicon glyphicon-remove' aria-hidden='true' data-toggle='tooltip' data-placement='bottom'   title='Eliminar  seguimiento a clase'></span></a>";

                FilasLista.Text += "</td></tr>";
            }
        }
    }
}