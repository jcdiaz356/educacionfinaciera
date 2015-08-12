<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="Presentacion.Menu" %>

<div class="menu">
    <div class="container">
        <nav class="navbar navbar-default">
            <div class="container-fluid">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                </div>
                <% String adminUsers = "",adminReportes = "", adminIngresos = "", defaultActive = "", conocemas = "", armatuclase = "", testimonio = "", galeria = "", noticias = "", escolaresinforman = "", contacto = "", adminSeguimiento = "";
                   String url = Request.Url.AbsolutePath.ToString();
                   switch (url)
                   {
                       case "/Default.aspx":
                            defaultActive = "active";
                           break;
                       case "/conoce-mas.aspx":
                            conocemas = "active";
                           break;
                       case "/arma-tu-clase.aspx":
                            armatuclase = "active";
                           break;
                       case "/testimonio.aspx":
                            testimonio = "active";
                           break;
                       case "/galeria.aspx":
                            galeria = "active";
                           break;
                       case "/noticias.aspx":
                            noticias = "active";
                           break;
                       case "/noticias-detalle.aspx":
                           noticias = "active";
                           break;
                       case "/escolares-informan.aspx":
                            escolaresinforman = "active";
                           break;
                       case "/contacto.aspx":
                            contacto = "active";
                           break;
                       case "/blog.aspx":
                           escolaresinforman = "active";
                           break;
                       case "/Admin-Ingresos.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-IngAsesor.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-IngDocente.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-IngDirector.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-IngSubDirector.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-IngEscuela.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-EditAsesor.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-EditDirector.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-EditSubDirector.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-PasswordUser.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-ListAsesor.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-ListDocente.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-ListEscuela.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-ListDirector.aspx":
                           adminIngresos = "active";
                           break;
                       case "/Admin-ListSubDirector.aspx":
                           adminIngresos = "active";
                           break; 
                       case "/Admin-Seguimientos.aspx":
                           adminSeguimiento = "active";
                           break;
                       case "/Admin-SeguiMicroredes.aspx":
                           adminSeguimiento = "active";
                           break;
                       case "/Admin-SeguiClase.aspx":
                           adminSeguimiento = "active";
                           break;
                       case "/Admin-SeguiVisitas.aspx":
                           adminSeguimiento = "active";
                           break;
                       case "/Admin-SeguiNuevoMicroredes.aspx":
                           adminSeguimiento = "active";
                           break;
                       case "/Admin-SeguiNuevoClase.aspx":
                           adminSeguimiento = "active";
                           break;

                       case "/Admin-SeguiNuevoVisita.aspx":
                           adminSeguimiento = "active";
                           break;
                       case "/Admin-Reportes.aspx":
                           adminReportes = "active";
                           break;
                       case "/Admin-Users.aspx":
                           adminUsers = "active";
                           break;
                       default  :
                          defaultActive = "active";
                           break; 
                       
                   }
                %>
               


                


                <% if(Convert.ToInt16(Session["idTipoUser"]) == 1) { %>
                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="<% Response.Write(defaultActive); %>"><a href="Default.aspx">PORTAL <span class="sr-only">(current)</span></a></li>
                        <li class="<% Response.Write(adminUsers); %>"><a href="Admin-Users.aspx">USUARIOS <span class="sr-only">(current)</span></a></li>
                        
                    </ul>
                </div>
                <% }  else if(Convert.ToInt16(Session["idTipoUser"]) == 4) { %>
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="<% Response.Write(defaultActive); %>"><a href="Default.aspx">INICIO <span class="sr-only">(current)</span></a></li>
                        <li class="<% Response.Write(conocemas); %>" ><a href="conoce-mas.aspx?id=1">CONOCE MAS</a></li>
                        <li class="<% Response.Write(armatuclase); %>" ><a href="arma-tu-clase.aspx?id=6">ARMA TU CLASE</a></li>
                        <li class="<% Response.Write(testimonio); %>" ><a href="testimonio.aspx?id=12">TESTIMONIO</a></li>
                        <li class="<% Response.Write(galeria); %>"><a href="galeria.aspx">GALERIA</a></li>
                        <li class="<% Response.Write(noticias); %>"><a href="noticias.aspx">NOTICIAS</a></li>
                        <li class="<% Response.Write(escolaresinforman); %>"><a href="escolares-informan.aspx">ESCOLARES INFORMAN</a></li>
                        <li class="<% Response.Write(contacto); %>"><a href="contacto.aspx">CONTACTO</a></li>
                    </ul>
                </div>

                <% } else if((Convert.ToInt16(Session["idTipoUser"]) == 2) | (Convert.ToInt16(Session["idTipoUser"]) ==7)) { %>
                    
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="<% Response.Write(defaultActive); %>"><a href="Default.aspx">PORTAL <span class="sr-only">(current)</span></a></li>
                        <li class="<% Response.Write(adminIngresos); %>"><a href="Admin-Ingresos.aspx">INGRESOS <span class="sr-only">(current)</span></a></li>
                        <li class="<% Response.Write(adminSeguimiento); %>"><a href="Admin-Seguimientos.aspx">SEGUIMIENTOS <span class="sr-only">(current)</span></a></li>
                        <li class="<% Response.Write(adminReportes); %>"><a href="Admin-Reportes.aspx">REPORTES <span class="sr-only">(current)</span></a></li>
                    </ul>
                </div>
                <% } else if(Convert.ToInt16(Session["idTipoUser"]) == 5) { %>
                    
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="<% Response.Write(defaultActive); %>"><a href="Default.aspx">PORTAL <span class="sr-only">(current)</span></a></li>
                        <li class="<% Response.Write(adminReportes); %>"><a href="Admin-Reportes.aspx">REPORTES <span class="sr-only">(current)</span></a></li>
                    </ul>
                </div>
                <% } else if(Convert.ToInt16(Session["idTipoUser"]) == 6) { %>
                    
                    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                    <ul class="nav navbar-nav">
                        <li class="<% Response.Write(defaultActive); %>"><a href="Default.aspx">PORTAL <span class="sr-only">(current)</span></a></li>
                        <li class="<% Response.Write(adminReportes); %>"><a href="Admin-Reportes.aspx">REPORTES <span class="sr-only">(current)</span></a></li>
                    </ul>
                </div>
                <% } %>

                <!-- /.navbar-collapse -->
            </div>
            <!-- /.container-fluid -->
        </nav>
    </div>
</div>
