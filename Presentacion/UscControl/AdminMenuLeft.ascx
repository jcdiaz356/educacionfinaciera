<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminMenuLeft.ascx.cs" Inherits="Presentacion.UscControl.AdminMenuLeft" %>
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
                    <li class="<% Response.Write(Active1); %>"><a href="Admin-ListAsesor.aspx?id=1">ASESORES <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>

                    <li class="<% Response.Write(Active2); %>"><a href="Admin-ListDocente.aspx?id=2">DOCENTES<div class="triangulo_top_right" ></div></a></li>

                    <li class="<% Response.Write(Active4); %>"><a href="Admin-ListDirector.aspx?id=4">DIRECTOR<div class="triangulo_top_right" ></div></a></li>

                    <li class="<% Response.Write(Active5); %>"><a href="Admin-ListSubDirector.aspx?id=5">SUBDIRECTOR<div class="triangulo_top_right" ></div></a></li>

                    <li class="<% Response.Write(Active3); %>"><a href="Admin-ListEscuela.aspx?id=3">ESCUELAS<div class="triangulo_top_right" ></div></a></li>
                    
                </ul>
            </div><!-- /.navbar-collapse -->
        </div><!-- /.container-fluid -->
    </nav>

</div>