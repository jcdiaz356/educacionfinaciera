using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class conoce_mas : System.Web.UI.Page
    {
        private LogicaNegocio.Content objLNContent;
        private ModeloNegocio.Content objMNContent;
        private Int16 idConten;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si no autentificado redirecciona a Login
            //if (!this.Page.User.Identity.IsAuthenticated)
            //{
            //    FormsAuthentication.RedirectToLoginPage();
            //}

            idConten = Convert.ToInt16(Request.QueryString["id"]);

            //objLNContent = new LogicaNegocio.Content();
            //objMNContent = new ModeloNegocio.Content();

            //objMNContent = objLNContent.getContentId(idConten);

            if (idConten == 1)
            {
                lblTitulo.Text = "¿Qué hacemos?";
                lblContent.Text += "<p>“Contigo en tus Finanzas en Aula” es un proyecto educativo de  del Banco de Crédito del Perú (BCP) en el marco de su estrategia de Responsabilidad Social Corporativa, implementado en convenio con el Ministerio de Educación (Minedu), la Dirección Regional de Educación de Lima Metropolitana (DRELM), las Unidades de Gestión Educativa Local (UGEL) y las 57 entidades educativas seleccionadas. </p>";
                lblContent.Text += "<p>El proyecto se orienta a fortalecer, en los docentes, las competencias de educación financiera y la metodología de enseñanza centrada en el estudiante, puesto que ellos son la base para que el aprendizaje y la práctica financiera se desarrollen en los adolescentes. </p>";
                lblContent.Text += "<p>Para ello, se ha diseñado una estrategia que permite la sinergia entre todos los actores: estudiantes, docentes, directores, padres y madres, funcionarios de las UGEL, funcionarios de la DRELM, funcionarios del Minedu, hacedores de política pública, agencias del BCP, agentes del BCP, y el área de Responsabilidad Social del banco. Asimismo, se acompaña al docente y se monitorea sus actividades con la finalidad de aportar y asesorar en el cumplimiento de estas. </p>";
                lblContent.Text += "<p>La meta clara es articular la educación financiera al Marco Curricular Nacional en una alianza estratégica púbico privada que compromete al Minedu y a sus órganos descentralizados de educación, con el objetivo de expandir, dentro de un periodo determinado, la educación financiera a nivel de las escuelas secundarias de todo el país.  </p>";
                lblContent.Text += "<p>Debemos recordar que dentro de este proyecto, la educación financiera para los estudiantes de 1ro, 2do, 3er, 4to y 5to año del nivel secundario de la Educación Básica Regular deberá ser vista como un elemento sustancial y dinamizador de su proyecto de vida, además de ser incorporado en su análisis FODA y en la misión y visión personal de cada estudiante.</p>";
                lblContent.Text += "<p>A partir de esta articulación sinérgica entre la educación financiera y la identificación de sus fortalezas, debilidades, oportunidades y amenazas; los jóvenes encontrarán sentido a la necesidad de desarrollar una serie de habilidades sociales (blandas) para lograr sus sueños personales. </p>";
                lblContent.Text += "<p>En la medida que cada uno de ellos se trace un objetivo personal, la motivación para lograrlo será una condición vital. Estamos formando no solo futuros mejores clientes del sistema financiero, sino, y sobretodo, ciudadanos plenos, con poder de decisión y elección de aquellas alternativas financieras que harán de ellos personas con capacidad de elegir el tipo de vida que han planificado y soñado, con optimismo y suficiente sentido de realdad.</p>";
                lblContent.Text += "<p>Así, el BCP, a través de una de sus principales estrategias de Responsabilidad Social, pone a disposición del Estado y de la sociedad civil una de sus mayores fortalezas: la capacidad de brindar educación financiera a todas las personas. Esta iniciativa publico privada se presenta como una de las más innovadoras del país en el campo de la Responsabilidad Social Empresarial.</p>";
            }
            if (idConten == 2)
            {
                lblTitulo.Text = "¿Dónde Estamos?";
                lblContent.Text += "Aca tenemos un cuadro que muestra que tanto hemos avanzado<br><span class=\"glyphicon glyphicon-file\"></span> <a href=\"http://contigoentusfinanzasenaula.com/media/archivos/DondeEstamos_listadecolegios.pdf\" target=\"_blank\">obtener cuadro</a>";
            }
            if (idConten == 3)
            {
                lblTitulo.Text = "Experiencias Internacionales de Educación Financiera";
                lblContent.Text += "<ul><li>Plan de Educación Financiera 2013 – 2017 (Comisión Nacional del Mercado de Valores - España) <a href=\"https://www.cnmv.es/DocPortal/Publicaciones/PlanEducacion/PlanEducacion13_17.pdf\" target=\"_blank\">Más Detalles</a></li>";
                lblContent.Text += "<li>Educación financiera para todos. Estrategias y buenas prácticas de educación financiera en la Unión Europea. <a href=\"http://www.eesc.europa.eu/resources/docs/qe-30-12-894-es.pdf\" target=\"_blank\">Más Detalles</a></li>";
                lblContent.Text += "<li>La educación financiera en América Latina y el Caribe. Situación actual y perspectivas.  <a href=\"http://www.oecd.org/daf/fin/financial-education/OECD_CAF_Financial_Education_Latin_AmericaES.pdf\" target=\"_blank\">Más Detalles</a></li>";
                lblContent.Text += "<li>Estrategia nacional de educación económica y financiera (Colombia)  <a href=\"https://www.superfinanciera.gov.co/SFCant/ConsumidorFinanciero/estratenaledufinanciera012011.pdf\" target=\"_blank\">Más Detalles</a></li>";
                lblContent.Text += "<li>I Congreso Latinoamericano de Educación financiera (2010)  <a href=\"http://www.febraban.org.br/7rof7swg6qmyvwjcfwf7i0asdf9jyv/sitefebraban/espanhol-final.pdf\" target=\"_blank\">Más Detalles</a></li></ul>";
            }
            if (idConten == 4)
            {
                lblTitulo.Text = "Objetivos";
                lblContent.Text += "<p>“Contigo en tus Finanzas en Aula” es un proyecto educativo de  del Banco de Crédito del Perú (BCP) en el marco de su estrategia de Responsabilidad Social Corporativa, implementado en convenio con el Ministerio de Educación (Minedu), la Dirección Regional de Educación de Lima Metropolitana (DRELM), las Unidades de Gestión Educativa Local (UGEL) y las 57 entidades educativas seleccionadas. </p>";
                lblContent.Text += "<p>Los objetivos específicos de ésta intervención son: </p>";
                lblContent.Text += "<ul><li>Brindar las herramientas para que los docentes cuenten con prácticas pedagógicas (metodologías y contenidos) para promover una educación financiera articulada a habilidades sociales  a través de la implementación de 15 sesiones de clase.</li>";
                lblContent.Text += "<li>Apoyar a las Instituciones Educativas a incorporar en sus instrumentos de gestión (PEI/PCC) contenidos y metodologías para la educación financiera y habilidades sociales articuladas a prácticas financieras adecuadas.</li>";
                lblContent.Text += "<li>Asegurar que las UGEL cuenten con información y conocimientos en educación financiera y habilidades sociales articuladas para el acompañamiento técnico a sus escuelas.</li>";
                lblContent.Text += "<li>Colaborar con el Minedu para fortalecer la implementación de estrategias para la educación financiera articuladas a habilidades sociales a nivel secundario.</li></ul>";
            }
            if (idConten == 5)
            {
                lblTitulo.Text = "Beneficiarios";
                lblContent.Text += "<table class=\"table table-striped\"><thead><th>Grupo poblacional directo</th><th>Cantidad</th></thead>";
                lblContent.Text += "<tbody><tr><th scope=\"row\">Alumnos</th><td>38,032</td></tr>";
                lblContent.Text += "<tr><th scope=\"row\">Docentes</th><td>258</td></tr>";
                lblContent.Text += "<tr><th scope=\"row\">Escuelas</th><td>57</td></tr>";
                lblContent.Text += "<tr><th scope=\"row\">Directores</th><td>57</td></tr>";
                lblContent.Text += "<tr><th scope=\"row\">Funcionarios públicos (MINEDU, DRELM, UGEL, etc)</th><td>35 aprox.</td></tr></tbody>";
                lblContent.Text += "<thead><th>Grupo poblacional indirecto</th><th>Cantidad</th></thead>";
                lblContent.Text += "<tbody><tr><th scope=\"row\">Agentes BCP</th><td>100 aprox.</td></tr>";
                lblContent.Text += "<tr><th scope=\"row\">Padres de familia</th><td>10,000</td></tr>";
                lblContent.Text += "<tr><th scope=\"row\">Funcionarios públicos (MINEDU, DRELM, UGEL, etc)</th><td>50</td></tr></tbody></table>";
            }
        }
    }
}