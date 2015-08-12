using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class arma_tu_clase : System.Web.UI.Page
    {
        private Int16 idConten;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no autentificado redirecciona a Login
            //if (!this.Page.User.Identity.IsAuthenticated)
            //{
            //    FormsAuthentication.RedirectToLoginPage();
            //}
            idConten = Convert.ToInt16(Request.QueryString["id"]);
            if (idConten == 6)
            {
                lblTitulo.Text = "Guía metodológica";
                lblContent.Text += "";
                
            }
            if (idConten == 7)
            {
                lblTitulo.Text = "Sesiones";
                lblContent.Text += "";
                
            }
            if (idConten == 8)
            {
                lblTitulo.Text = "Videos";
                lblContent.Text += "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube-nocookie.com/embed/8z1oLU829mk?list=PLZgJHRxG688OEvxDQW1HhEvWOCKIc8jkg&amp;showinfo=0\" frameborder=\"0\" allowfullscreen></iframe>";

            }
            if (idConten == 9)
            {
                lblTitulo.Text = "Juego interactivo “La Gran Aventura Con Lucas”";
                lblContent.Text += "Título: Desafíate: ahorra y gana<br>";
                lblContent.Text += "<p>La presente dinámica denominada “La Gran Aventura Con Lucas” es una actividad donde los estudiantes de los colegios del proyecto “Contigo en tus finanzas en el aula” –impulsado por el BCP- simulan cotidianamente las prácticas del sistema financiero que incluye ejercicios de ahorro, créditos, pago de impuestos y seguros; a través del cual se espera que los estudiantes conozcan de manera directa el manejo responsable de distintas herramientas financieras, desde un enfoque participativo y prospectivo, fortaleciendo de este modo capacidades y actitudes para el ejercicio de sus derechos como ciudadanos.</p>";
                lblContent.Text += "<p>El juego “Desafíate: ahorra y gana” está dirigido a todos los grados de educación secundaria según misiones que incluyen actividades de reciclaje, elaboración de periódicos murales relacionados al tema financiero, exposiciones sobre educación financiera, mantenimiento y limpieza de las aulas, obtención de mejores promedios ponderados, implementación de áreas verdes e implementación de bibliotecas.</p>";
                lblContent.Text += "Conoce más en el documento del juego: <br><span class=\"glyphicon glyphicon-file\"></span> <a href=\"http://contigoentusfinanzasenaula.com/media/archivos/Juego_Interactivo_La_Gran_Aventura_Con_Lucas.pdf\" target=\"_blank\">obtener documento del Juego</a>";
            }
            if (idConten == 10)
            {
                lblTitulo.Text = "Talleres";
                lblContent.Text += "<table class=\"table table-striped\"><thead><th>GRUPOS</th><th>MAYO</th><th>JUNIO</th><th>JULIO</th><th>AGOSTO</th><th>SETIEMBRE</th></thead>";
                lblContent.Text += "<tbody><tr><th scope=\"row\">Grupo A</th><td>16 y 17  mayo</td><td>6 y 7 junio</td><td>4 y 5 julio</td><td>15 y 16 agosto </td><td>12 y 13 set.</td></tr>";
                lblContent.Text += "<tbody><tr><th scope=\"row\">Grupo B</th><td>23 Y 24 mayo</td><td>13 y 14 junio</td><td>11 y 12 julio </td><td>22 y 23 agosto</td><td>19 y 20 set.</td></tr>";
                
                lblContent.Text += "</tbody></table>";
            }
            if (idConten == 11)
            {
                lblTitulo.Text = "Más recursos";
                lblContent.Text += "<h2>Documentos</h2>";
                lblContent.Text += "<ul><li>Informe PISA 2012. Competencia financiera. <a href=\"http://www.mecd.gob.es/dctm/inee/internacional/pisa2012-financiera/informeespanolpisafinanciera07.07.14web.pdf?documentId=0901e72b81a25b3f\" target=\"_blank\">Más Detalles</a></li>";
                lblContent.Text += "<li>Cuento \"Mi dinero y yo\". Aprende con Daniel y Lucía cómo ahorrar y usar bien tu dinero. <a href=\"http://www.instituto-aviva-de-ahorro-y-pensiones.es/recursos/a.pdf/saber-mas/infantil/Instituto-Aviva-educacion-financiera-mi-dinero-y-yo.pdf\" target=\"_blank\">Más Detalles</a></li>";
                lblContent.Text += "<li>Cómic \"Educación financiera en la ciudad. Cronomatopeyas del gentío\" <a href=\"http://www.edufinet.com/edufinext/images/comic_provincias.pdf\" target=\"_blank\">Más Detalles</a></li></ul>";
                lblContent.Text += "<h2>Videos</h2>";
                lblContent.Text += "<ul><li>Consejos del ABC de la Banca del BCP</li>";
                lblContent.Text += "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/Ym_t3-eVXG0?list=PLDBDBE6C8A2606860\" frameborder=\"0\" allowfullscreen></iframe>";
                lblContent.Text += "<li>Consejos de educación financiera de la Red Española de Educación Financiera</li>";
                lblContent.Text += "<iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/aQWplMOf7MA?list=PLiLln3peFC1cId5mz6V2W58N0e1L8x8IV\" frameborder=\"0\" allowfullscreen></iframe>";
                lblContent.Text += "</ul>";
                lblContent.Text += "<h2>Web</h2>";
                lblContent.Text += "<ul><li>ABC de la banca del BCP. <br><a href=\"https://www.abcdelabanca.com/\" target=\"_blank\">Visita la web</a></li>";
                lblContent.Text += "<li>Portal de educación financiera de la Superintendencia de Banca, Seguros y AFP (SBS).<br><a href=\"http://www.sbs.gob.pe/educacion-financiera\" target=\"_blank\">Visita la web</a></li>";
                lblContent.Text += "<li>Gepeese: Portal para jóvenes con juegos y consejos sobre finanzas. <br><a href=\"http://www.finanzasparatodos.es/gepeese/es/inicio/\" target=\"_blank\">Visita la web</a></li>";
                lblContent.Text += "<li>Portal de la Red Española de Educación Financiera. <br><a href=\"http://www.rededucacionfinanciera.es/\" target=\"_blank\">Visita la web</a></li>";
                lblContent.Text += "</ul>";
            }
        }
    }
}