<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="testimonio.aspx.cs" Inherits="Presentacion.testimonio" %>
<%@Register TagPreFix="ucSocialFacebook" TagName="MenuSocialFacebook" src="~/SocialFacebook.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!------------CONTENEDOR-->
    <div class="container" >
        <div class="row">
            <!-- COLUMNA IZQUIERDA-->
            <div class="col-md-3 pt">
                <!----------MENU LEFT------------->
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
                                   String Active1 = "", Active2 = "";
                                   switch (idContent)
                                   {
                                       case 12:
                                            Active1 = "active";
                                           break;
                                       case 13:
                                           Active2 = "active";
                                           break;
                                        
                                   }
                                %>
                                <!-- Collect the nav links, forms, and other content for toggling -->
                                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                                    <ul class="nav navbar-nav">
                                        <li class="<% Response.Write(Active1); %>"><a href="testimonio.aspx?id=12">HISTORIA <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                                        <li class="<% Response.Write(Active2); %>"><a href="testimonio.aspx?id=13">VIDEOS<div class="triangulo_top_right" ></div></a></li>

                                    </ul>
                                </div><!-- /.navbar-collapse -->
                            </div><!-- /.container-fluid -->
                        </nav>

                </div>
            </div>
            <!-- COLUMNA DERECHA-->
            <% if (Convert.ToInt16(Request.QueryString["id"]) != 13) {%>
            <div class="col-md-6">
            <% }else{ %>
            <div class="col-md-9">
            <% } %>
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <h1></h1>
                                        
                                     
                                        <asp:Label ID="lblContent" runat="server" Text="">

                                        </asp:Label>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

            <% if (Convert.ToInt16(Request.QueryString["id"]) != 13) {%>
            <div class="col-md-3">
                

                <!-- REDES SOCIALES-->
                <div class="row">
                    <div class="col-md-12">
                        <!------------CUADRO 1 FACEBOOK------>
                        <ucSocialFacebook:MenuSocialFacebook id="MenuSocial" runat="server" />

                    </div>

                </div>


            </div>
            <%  } %>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
