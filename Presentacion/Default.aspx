<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Presentacion._Default" %>
<%@Register TagPreFix="ucSocialFacebook" TagName="MenuSocialFacebook" src="~/SocialFacebook.ascx" %>
<%@Register TagPreFix="ucNoticias" TagName="ucNoticias" src="~/UscControl/Noticias.ascx" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <!------------CONTENEDOR-->
<div class="container" >
    <div class="row">
        <!-- seción slider-->
        <div class="col-md-8 pt">
            <!--------SLIDER--------------->
            <div class="row">
                <div class="col-md-12 ">
                    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
                        <!-- Indicators -->
                        <ol class="carousel-indicators">
                            <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="2"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="3"></li>
                            <li data-target="#carousel-example-generic" data-slide-to="4"></li>
                        </ol>

                        <!-- Wrapper for slides -->
                        <div class="carousel-inner" role="listbox">
                            <div class="item active">
                                <a href="http://contigoentusfinanzasenaula.com/noticia-detalle.aspx?id=3"><img src="http://contigoentusfinanzasenaula.com/media/images/g1_6.JPG" alt="..."></a>
                                <div class="carousel-caption">
                                    Directores de diversos colegios de Lima Metropolitana estuvieron presentes en la presentación de Contigo en tus finanzas en aula, proyecto educativo del Banco de Crédito del Perú (BCP) en el marco de su estrategia de Responsabilidad Social Corporativa, que involucra a más de 50 instituciones educativas.
                                </div>
                            </div>
                            <div class="item">
                                <a href="http://contigoentusfinanzasenaula.com/noticia-detalle.aspx?id=4"><img src="http://contigoentusfinanzasenaula.com/media/images/g2_9.JPG" alt="..."></a>
                                <div class="carousel-caption">
                                    Más de 100 docentes estuvieron presentes en el taller.<br>El primer grupo de profesores de los colegios participantes del proyecto Contigo en tus finanzas en aula asistió a la sesión inaugural llevada a cabo el 16 y 17 de mayo en las instalaciones del colegio Nuestra Señora de Guadalupe.
                                </div>
                            </div>
                            <div class="item">
                                <a href="http://contigoentusfinanzasenaula.com/noticia-detalle.aspx?id=5"><img src="http://contigoentusfinanzasenaula.com/media/images/g3_11.JPG" alt="..."></a>
                                <div class="carousel-caption">
                                    Participaron 130 docentes de colegios públicos de Lima Metropolitana.<br>El grupo 2 de profesores de diversas instituciones educativas públicas asistieron a la primera jornada de los talleres del proyecto Contigo en tus finanzas en aula organizado por el BCP el pasado 23 y 24 de mayo en las instalaciones del colegio Nuestra Señora de Guadalupe.
                                </div>
                            </div>
                            <div class="item">
                                <a href="http://contigoentusfinanzasenaula.com/noticia-detalle.aspx?id=6"><img src="http://contigoentusfinanzasenaula.com/media/images/g4_3.JPG" alt="..."></a>
                                <div class="carousel-caption">
                                    Los docentes de diversos colegios de Villa María del Triunfo y Villa El Salvador estuvieron presentes el pasado viernes 05 de junio en la primera sesión de los microtalleres del proyecto Contigo en tus finanzas en aula organizado por el BCP en las instalaciones del colegio Perú-EE.UU. 
                                </div>
                            </div>

                            <div class="item">
                                <a href="http://contigoentusfinanzasenaula.com/noticia-detalle.aspx?id=7"><img src="http://contigoentusfinanzasenaula.com/media/images/g5_11.JPG" alt="..."></a>
                                <div class="carousel-caption">
                                    El grupo 1 de profesores de diversas instituciones educativas públicas asistieron a la segunda jornada de los talleres del proyecto Contigo en tus finanzas en aula organizado por el BCP el pasado 06 y 07 de junio en las instalaciones del colegio Nuestra Señora de Guadalupe. 
                                </div>
                            </div>
                        </div>

                        <!-- Controls -->
                        <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
                            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                            <span class="sr-only">Previous</span>
                        </a>
                        <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
                            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                            <span class="sr-only">Next</span>
                        </a>
                    </div>
                </div>

            </div>
            <!-- -----END SLIDER----->

            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="col-md-12 pb">
                            
                            <div class="cuadro pt">
                                <div class="title">
                                    TESTIMONIOS
                                    <div class="triangulo_top_right" ></div>
                                </div>
                                <div class="cuadro-content">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <iframe class="youtube" src="https://www.youtube.com/embed/gIOmGQxC4qQ" frameborder="0" allowfullscreen></iframe>

                                        </div>
                                        <div class="col-md-6">
                                            <iframe class="youtube" src="https://www.youtube.com/embed/CewjHthST50" frameborder="0" allowfullscreen></iframe>

                                        </div>


                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- ----- ---->
            <div class="row">
                <div class="col-md-12">
                    <h1>             </h1>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="row">
                <div class="col-md-12">
                    <% if(Convert.ToInt16(Session["idTipoUser"]) != 4) { %>
                          <div class="cuadro pt">
                            <div class="title">
                                MENÚ PORTAL
                                <div class="triangulo_top_right" ></div>
                            </div>
                            <div class="cuadro-content">
                                <ul >
                                    <li ><a href="Default.aspx">INICIO <span class="sr-only">(current)</span></a></li>
                                    <li ><a href="conoce-mas.aspx?id=1">CONOCE MAS</a></li>
                                    <li  ><a href="arma-tu-clase.aspx?id=6">ARMA TU CLASE</a></li>
                                    <li ><a href="testimonio.aspx?id=12">TESTIMONIO</a></li>
                                    <li ><a href="galeria.aspx">GALERIA</a></li>
                                    <li ><a href="noticias.aspx">NOTICIAS</a></li>
                                    <li><a href="escolares-informan.aspx">ESCOLARES INFORMAN</a></li>
                                    <li><a href="contacto.aspx">CONTACTO</a></li>
                                </ul>
                            </div>
                        </div>      
                    <% } %>
                    <!------------ Noticias ------>
                     <ucNoticias:ucNoticias id="ucNoticias" runat="server" />
                    <%--<div class="cuadro pt">
                        <div class="title">
                            NOTICIAS
                            <div class="triangulo_top_right" ></div>
                        </div>
                        <div class="cuadro-content">
                            <h1>titulo</h1>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Modi nihil quos saepe ut.  cum exercitationem illo nesciunt quos!</p>
                        </div>
                    </div>--%>


                    <!------------CUADRO 2------->
                    <div class="cuadro pt">
                        <div class="title">
                            DESCARGA LA GUÍA
                            <div class="triangulo_top_right" ></div>
                        </div>
                        <div class="cuadro-content">
                            <h4>Titulo2</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Modi nihil quos saepe ut. Accusantium dicta eos eveniet officiis . </p>

                            <%--<h4>Titulo2</h4>
                            <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Modi nihil quos saepe ut. </p>--%>


                        </div>
                    </div>

                </div>



            </div>

            <!-- REDES SOCIALES-->

            <div class="row">
                <div class="col-md-12">
                    <ucSocialFacebook:MenuSocialFacebook id="MenuSocial" runat="server" />

                </div>

            </div>
            
            


        </div>
    </div>

</div>
</asp:Content>
