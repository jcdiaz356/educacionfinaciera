<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="galeria-detalle.aspx.cs" Inherits="Presentacion.galeria_detalle" %>
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
                    <div class="col-md-12 pt pb ">

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
                                        <div class="detalle-nota">
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <asp:Label ID="lblTitulo" runat="server" Text="Label"></asp:Label>   <a href="galeria.aspx" class="btn btn-default btn-xs pull-right" role="button">Volver</a>
                                                </div>
                                            </div>

                                            <asp:Label ID="lblDetalleNoticia" runat="server" Text=""></asp:Label>

                                        </div>

                                    </div>
                                    <div class="cuadro-content">
                                        <!--  fila 1-->
                                        <asp:Label ID="lblGaleria" runat="server" Text="">
                                        

                                       </asp:Label>


                                       

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
