<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="arma-tu-clase.aspx.cs" Inherits="Presentacion.arma_tu_clase" %>
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
                                   String Active1 = "", Active2 = "", Active3 = "", Active4 = "", Active5 = "", Active6 = "";
                                   switch (idContent)
                                   {
                                       case 6:
                                            Active1 = "active";
                                           break;
                                       case 7:
                                           Active2 = "active";
                                           break;
                                       case 8:
                                           Active3 = "active";
                                           break;
                                       case 9:
                                           Active4 = "active";
                                           break;
                                       case 10:
                                           Active5 = "active";
                                           break;
                                       case 11:
                                           Active6 = "active";
                                           break;
                                        
                                   }
                                %>
                                <!-- Collect the nav links, forms, and other content for toggling -->
                                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                                    <ul class="nav navbar-nav">
                                        <li class="<% Response.Write(Active1); %>"><a href="arma-tu-clase.aspx?id=6">GUÍA METODOLOGÍCA <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                                        <li class="<% Response.Write(Active2); %>"><a href="arma-tu-clase.aspx?id=7">SESIONES<div class="triangulo_top_right" ></div></a></li>
                                        <li class="<% Response.Write(Active3); %>"><a href="arma-tu-clase.aspx?id=8">VIDEOS<div class="triangulo_top_right" ></div></a></li>
                                        <li class="<% Response.Write(Active4); %>"><a href="arma-tu-clase.aspx?id=9">JUEGO INTERACTIVO<div class="triangulo_top_right" ></div></a></li>
                                        <li class="<% Response.Write(Active5); %>"><a href="arma-tu-clase.aspx?id=10">TALLERES<div class="triangulo_top_right" ></div></a></li>
                                        <li class="<% Response.Write(Active6); %>"><a href="arma-tu-clase.aspx?id=11">MAS RECURSOS<div class="triangulo_top_right" ></div></a></li>
                                    </ul>
                                </div><!-- /.navbar-collapse -->
                            </div><!-- /.container-fluid -->
                        </nav>

                </div>
            </div>
            <!-- COLUMNA DERECHA-->
            <% if ((Convert.ToInt16(Request.QueryString["id"]) != 11) & (Convert.ToInt16(Request.QueryString["id"]) != 8)) {%>
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
                                        Arma Tu Clase
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <h1><asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label></h1>
                                        
                                     
                                        <asp:Label ID="lblContent" runat="server" Text=""></asp:Label>
                                            <% if (Convert.ToInt16(Request.QueryString["id"]) == 7) {%>
                                            <h4>Programa de Formación Docente:</h4>
                                            <ul>
                                                <li><a href="media/archivos/Sesiones/Primera_sesion/ORIENTACIONES_METODOLOGICAS.pdf" target="_blank">Orientaciones metodológicas <span class="glyphicon glyphicon-file"></span></a> </li>
                                                <li>Educación Financiera</li>
                                                
                                                <ul>
                                                    <li>1ra y 2da sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/1ra_y_2da_sesion/Guia_Docente_2012_SBS.pdf" target="_blank">Guía Docente 2012 SBS <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/1ra_y_2da_sesion/PPT_BCP.pdf" target="_blank">PPT BCP <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/1ra_y_2da_sesion/SEPARATA_DEL_AHORRO_CONTROL_DE_LECTURA.pdf" target="_blank">Separata del Ahorro y control de Lectura <span class="glyphicon glyphicon-file"></span></a></li>
                                                    </ul>
                                                    <li>3ra y 4ta sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/3ra_y_4ta_sesion/Comisiones_prohibidas_en_el_Sistema_FinancieroRES.pdf" target="_blank">Comisiones prohibidas en el Sistema FinancieroRES <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/3ra_y_4ta_sesion/Finanzas-en-el_Cole-BCP-06-07-junio.pdf" target="_blank">Finanzas en el Cole-BCP-06-07-junio <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/3ra_y_4ta_sesion/Historieta_SBS.pdf" target="_blank">Historieta SBS <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/3ra_y_4ta_sesion/Lectura-Presupuesto-Familiar.pdf" target="_blank">Lectura Presupuesto Familiar <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/3ra_y_4ta_sesion/RR_8181_2012.pdf" target="_blank">RR 8181 2012 <span class="glyphicon glyphicon-file"></span></a></li>
                                                    </ul>
                                                    <li>5ta y 6ta sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/5ta_y_6ta_sesion/REGULACION_Y_SUPERVISION_DEL_SISTEMA_FINANCIERO.pdf" target="_blank">REGULACION Y SUPERVISION DEL SISTEMA FINANCIERO <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/1_Educacion_Financiera/5ta_y_6ta_sesion/ROL_Y_FUNCIONAMIENTO_DEL_SISTEMA_FINANCIERO.pdf" target="_blank">ROL Y FUNCIONAMIENTO DEL SISTEMA FINANCIERO <span class="glyphicon glyphicon-file"></span></a></li>
                                                        
                                                    </ul>
                                                </ul>
                                                <li>Habilidades Pedágogicas</li>
                                                <ul>
                                                    <li>1ra y 2da sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/1ra_y_2da_sesion/El_ser_autentico.pdf" target="_blank">El ser autentico <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/1ra_y_2da_sesion/LA_NOCION_DEL_NINO_EN_LA_HISTORIA.doc" target="_blank">LA NOCIÓN DEL NIÑO EN LA HISTORIA <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/1ra_y_2da_sesion/Soportes_para_crecer.pdf" target="_blank">Soportes para crecer <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/1ra_y_2da_sesion/TEORIAS_DEL_DESARROLLO_INFANTIL.doc" target="_blank">TEORIAS DEL DESARROLLO INFANTIL <span class="glyphicon glyphicon-file"></span></a></li>
                                                    </ul>
                                                    <li>3ra y 4ta sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/3ra_y_4ta_sesion/3_historias_aula2.pdf" target="_blank">Historias aula 2 <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/3ra_y_4ta_sesion/EL_VINCULO_COMUNICACIONAL_Y_AFECTIVO_MAESTRO_ALUMNO.pdf" target="_blank">EL VINCULO COMUNICACIONAL Y AFECTIVO MAESTRO ALUMNO <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/3ra_y_4ta_sesion/FLORENTINO_SANTOS_PORRAS_01.pdf" target="_blank">FLORENTINO SANTOS PORRAS 01 <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/2_Habilidades_Pedagogicas/3ra_y_4ta_sesion/INTELIGENCIA_EMOCIONAL_EN_NINOS.pdf" target="_blank">INTELIGENCIA EMOCIONAL EN NIÑOS <span class="glyphicon glyphicon-file"></span></a></li>
                                                    </ul>
                                                </ul>
                                                <li>Enfoques Educativos</li>
                                                <ul>
                                                    <li>1ra y 2da sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/3_Enfoques_Educativos/1ra_y_2da_sesion/EL_ENFOQUE_DE_COMPETENCIAS.pdf" target="_blank">EL ENFOQUE DE COMPETENCIAS <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/3_Enfoques_Educativos/1ra_y_2da_sesion/ORIENTACIONES_GENERALES_PARA_LA_PLANIFICACION_CURRICULAR.pdf" target="_blank">ORIENTACIONES GENERALES PARA LA PLANIFICACION CURRICULAR <span class="glyphicon glyphicon-file"></span></a></li>
                                                        <li><a href="media/archivos/Sesiones/3_Enfoques_Educativos/1ra_y_2da_sesion/PPT_Enfoque_por_competencias.pdf" target="_blank">PPT Enfoque por competencias <span class="glyphicon glyphicon-file"></span></a></li>
                                                        
                                                    </ul>
                                                    <li>3ra y 4ta sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/3_Enfoques_Educativos/3ra_y_4ta_sesion/Materiales_Enfoques_Educativos.pdf" target="_blank">Materiales Enfoques Educativos <span class="glyphicon glyphicon-file"></span></a></li>
                                                        
                                                    </ul>
                                                </ul>
                                                <li>Programacion Curricular en Educacion Financiera</li>
                                                <ul>
                                                    <li>1ra sesion</li>
                                                    <ul>
                                                        <li><a href="media/archivos/Sesiones/4_Programacion_Curricular_en_Educacion_Financiera/1ra_y_2da_sesion/ORIENTACIONES_METODOLOGICAS.pdf" target="_blank">ORIENTACIONES METODOLOGICAS <span class="glyphicon glyphicon-file"></span></a></li>
                                                    </ul>
                                                    
                                                </ul>
                                            </ul>

                                            <% } %>
                                        
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

            <% if ((Convert.ToInt16(Request.QueryString["id"]) != 11) & (Convert.ToInt16(Request.QueryString["id"]) != 8)) {%>
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
