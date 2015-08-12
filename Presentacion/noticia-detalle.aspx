<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="noticia-detalle.aspx.cs" Inherits="Presentacion.noticia_detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
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
                                        NOTICIA
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
                                                    <a href="noticias.aspx" class="btn btn-default btn-xs pull-right" role="button">Volver</a>
                                                </div>
                                            </div>

                                            <asp:Label ID="lblDetalleNoticia" runat="server" Text=""></asp:Label>

                                        </div>

                                    </div>


                                     <div class="cuadro-content">
                                        <div class="detalle-nota">
                                            <!-- --------COMENTARIOS------------->
                                            <div class="row">

                                                <div class="col-md-12">
                                                    <div class="comentario">
                                                        <h1>Cometarios</h1>
                                                        <asp:Label ID="lblComentario" runat="server" Text=""></asp:Label>

                                                        
                                                        
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- ---------FORMULARIO COMENTARIO---------------->
                                            <div class="row">

                                                <div class="col-md-12">
                                                    <h1>Ingrese un comentario</h1>

                                                    <form class="form-horizontal">
                                                        <div class="form-group">
                                                            <label for="inputEmail3" class="col-sm-2 control-label">Email</label>
                                                            <div class="col-sm-10">
                                                                
                                                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required placeholder="Email" TextMode="Email"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                        <div class="form-group">
                                                            <label for="inputComentario3" class="col-sm-2 control-label">Commentario</label>
                                                            <div class="col-sm-10">
                                                                
                                                                <asp:TextBox ID="txtComentario" CssClass="form-control" required placeholder="Ingrese su comentario" runat="server" TextMode="MultiLine" ></asp:TextBox>
                                                            </div>
                                                        </div>

                                                        <div class="form-group">
                                                            <div class="col-sm-offset-2 col-sm-10">
                                                                <%--<button type="submit" >Enviar comentario</button>--%>
                                                                <asp:Button class="btn btn-default" ID="cmdGuardar" runat="server" Text="Enviar comentario" OnClick="cmdGuardar_Click" />

                                                            </div>
                                                        </div>
                                                    </form>
                                                </div>
                                            </div> 

                                            
                                            <!-- -->
                                        </div>

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
