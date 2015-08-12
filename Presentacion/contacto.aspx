<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="Presentacion.contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!------------CONTENEDOR-->
    <div class="container" >
        <div class="row">

            <!-- COLUMNA DERECHA-->
            <div class="col-md-4">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">

                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <h3>Dirección</h3><br>

                                        <address>
                                            <strong>ONG Tierra de Niños</strong><br>
                                            Jr. Huiracocha 2293, 3er. piso - Jesús María<br>
                                            Lima Perú<br>
                                            <abbr title="Phone">P:</abbr> (511) 4628566
                                        </address>

                                        <address>
                                            <strong>Administración Tierra de Niños</strong><br>
                                            <a href="mailto:#">ADMINISTRACION@tierradeninos.org</a>
                                        </address>

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>


            <div class="col-md-8">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">

                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <h3>Ubícanos</h3>
                                        <!-- MAPA CANVAS -->
                                        <div id="map_canvas">
                                            <!-- css3 preLoading-->
                                            <div class="mapPerloading"> <span>Cargando</span>
                                                <span class="l-1"></span>
                                                <span class="l-2"></span>
                                                <span  class="l-3"></span>
                                                <span class="l-4"></span>
                                                <span class="l-5"></span>
                                                <span class="l-6"></span>
                                            </div>
                                        </div>
                                        <!-- END MAPA CANVAS -->

                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
