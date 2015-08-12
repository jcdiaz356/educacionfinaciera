
<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="noticias.aspx.cs" Inherits="Presentacion.noticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<%@ Register TagPrefix="UscPaginador" tagname="UscPaginador" src="UscControl/Paginador.ascx" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">



     <!------------CONTENEDOR-->
    <div class="container" >
        <div class="row">

            <!-- COLUMNA DERECHA-->
            <div class="col-md-12">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        NOTICIAS
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <!-- ----------------------fila de noticia------------------------>
                                        <div class="row">

                                       

                                             <!-- ---------NOTICIA------------->
                                                

                                            <asp:Label ID="lblNoticia" runat="server" Text=""></asp:Label>
                                       
                                        
                                        </div>


                                         <!-- --------------------PAGINADOR --------------------->
                                         

                                        <UscPaginador:UscPaginador id="UscPaginador" runat="server"></UscPaginador:UscPaginador>

                                        <!-- -------------------- END PAGINADOR --------------------->

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
