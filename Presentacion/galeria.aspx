<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="galeria.aspx.cs" Inherits="Presentacion.galeria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <!------------CONTENEDOR-->
    <div class="container" >
        <div class="row">

            <!-- COLUMNA IZQUIERDA-->
            <div class="col-md-12">
                <!--------------------------Contenido galeria imagenes---------------------------->
                <div class="row">
                    <div class="col-md-12 pt ">

                        <div class="cuadro ">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        GALERIA DE IMÁGENES
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <!--  fila 1-->
                                        <asp:Label ID="lblGaleria" runat="server" Text="">
                                        

                                       </asp:Label>


                                        <%--<div class="row">
                                            <div class="col-md-4 col-md-offset-4 pt">
                                                <a href="foto.html" class="btn btn-default center-block">VER MÁS IMÁGENES </a>

                                            </div>
                                        </div>--%>

                                    </div>
                                </div>
                            </div>




                        </div>


                    </div>
                </div>
                <!--------------------------Contenido galeria VIDEOS---------------------------->
               <%-- <div class="row">
                    <div class="col-md-12 pt pb">

                        <div class="cuadro ">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        GALERIA DE VIDEOS
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <!--  fila 1-->
                                        <div class="row gallery thumbnails">
                                            <div class="col-md-4">
                                                <a href="https://www.youtube.com/embed/icTdKsA1MSo" class="fancybox-media" rel="media-gallery" >
                                                    <img class="img-responsive" src="img/imagen1.jpg"  alt="" />
                                                    <div>
                                                            <span>
                                                                <img  src="img/play.png" alt="">
                                                                VIEW IMAGEN
                                                            </span>
                                                    </div>
                                                </a>
                                            </div>
                                            <div class="col-md-4">
                                                <a href="https://www.youtube.com/embed/icTdKsA1MSo" class="fancybox-media" rel="media-gallery" >
                                                    <img class="img-responsive" src="img/imagen2.jpg" alt="" />
                                                    <div>
                                                                <span>
                                                                    <img src="img/play.png" alt="">
                                                                    VIEW VIDEO
                                                                </span>
                                                    </div>
                                                </a>
                                            </div>
                                            <div class="col-md-4">
                                                <a href="https://www.youtube.com/embed/icTdKsA1MSo" class="fancybox-media" rel="media-gallery" >
                                                    <img class="img-responsive" src="img/imagen3.jpg"  alt="" />
                                                    <div>
                                                            <span>
                                                                <img src="img/play.png" alt="">
                                                                VER VIDEO
                                                            </span>
                                                    </div>
                                                </a>
                                            </div>
                                        </div>

                                        <!-- Fila 2-->
                                        <div class="row gallery thumbnails">
                                            <div class="col-md-4 pt">
                                                <a href="https://www.youtube.com/embed/icTdKsA1MSo" class="fancybox-media" rel="media-gallery" >
                                                    <img class="img-responsive" src="img/imagen4.jpg"  alt="" />
                                                    <div>
                                                            <span>
                                                                <img  src="img/play.png" alt="">
                                                                VER VIDEO
                                                            </span>
                                                    </div>
                                                </a>
                                            </div>
                                            <div class="col-md-4 pt">
                                                <a href="https://www.youtube.com/embed/icTdKsA1MSo" class="fancybox-media" rel="media-gallery" >
                                                    <img class="img-responsive" src="img/imagen5.jpg" alt="" />
                                                    <div>
                                                                <span>
                                                                    <img src="img/play.png" alt="">
                                                                    VIEW VIDEO
                                                                </span>
                                                    </div>
                                                </a>
                                            </div>
                                            <div class="col-md-4 pt">
                                                <a href="https://www.youtube.com/embed/icTdKsA1MSo" class="fancybox-media" rel="media-gallery" >
                                                    <img class="img-responsive" src="img/imagen6.jpg"  alt="" />
                                                    <div>
                                                            <span>
                                                                <img src="img/play.png" alt="">
                                                                VER VIDEO
                                                            </span>
                                                    </div>
                                                </a>
                                            </div>
                                        </div>


                                        <div class="row">
                                            <div class="col-md-4 col-md-offset-4 pt">
                                                <a href="video.html" class="btn btn-default center-block">VER MÁS VIDEOS </a>

                                            </div>
                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>--%>

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
