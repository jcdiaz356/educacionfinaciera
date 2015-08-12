<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdminMenuLeftSegui.ascx.cs" Inherits="Presentacion.UscControl.AdminMenuLeftSegui" %>
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

                }
            %>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                <ul class="nav navbar-nav">
                    <li class="<% Response.Write(Active1); %>"><a href="Admin-SeguiMicroredes.aspx?id=1">Acompañamiento a las Microredes <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                    <li class="<% Response.Write(Active2); %>"><a href="Admin-SeguiClase.aspx?id=2">Acompañamiento a Clase<div class="triangulo_top_right" ></div></a></li>
                    <li class="<% Response.Write(Active3); %>"><a href="Admin-SeguiVisitas.aspx?id=3">Visitas a IE<div class="triangulo_top_right" ></div></a></li>
                    
                    
                </ul>
            </div><!-- /.navbar-collapse -->
        </div><!-- /.container-fluid -->
    </nav>

</div>