<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminMenuLeftRepo.ascx.cs" Inherits="Presentacion.UscControl.AdminMenuLeftRepo" %>
<div class="menu-left">
    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <% 
                int idContent = Convert.ToInt16(Request.QueryString["id"]);
                String Active1 = "", Active2 = "", Active3 = "", Active4 = "", Active5 = "";
                switch (idContent)
                {
                    case 1:
                        Active1 = "active";
                        break;
                    case 2:
                        Active2 = "active";
                        break;
                    case 3:
                        Active3 = "active";
                        break;
                    case 4:
                        Active4 = "active";
                        break;
                    case 5:
                        Active5 = "active";
                        break;

                }
            %>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                <ul class="nav navbar-nav">
                    <li class="<% Response.Write(Active1); %>"><a href="ReporteConsolidado.aspx?id=1">Reporte Consolidado <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                    <li class="<% Response.Write(Active2); %>"><a href="Admin-RepoInstAsistidas.aspx?id=2">Instituciones Educativas <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                    <li class="<% Response.Write(Active3); %>"><a href="ReportePorAsesor.aspx?id=3">Asesores <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                    <li class="<% Response.Write(Active4); %>"><a href="ReportesPorProfesor.aspx?id=4">Profesores <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                    <li class="<% Response.Write(Active5); %>"><a href="ReporteVisitasIE.aspx?id=5">VISITAS IE <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                    <%--<li class="<% Response.Write(Active2); %>"><a href="Admin-RepoDocAsesorados.aspx?id=2">Total Docentes Asesorados<div class="triangulo_top_right" ></div></a></li>
                    <li class="<% Response.Write(Active2); %>"><a href="Admin-RepoSesRealizadas.aspx?id=3">Total Sesiones Realizadas<div class="triangulo_top_right" ></div></a></li>--%>
                    
                    
                </ul>
            </div><!-- /.navbar-collapse -->
        </div><!-- /.container-fluid -->
    </nav>

</div>