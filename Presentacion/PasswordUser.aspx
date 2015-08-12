<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasswordUser.aspx.cs" Inherits="Presentacion.PasswordUser" %>
<%@ Register TagPrefix="AdminMenuLeft" tagname="AdminMenuLeft" src="UscControl/AdminMenuLeft.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" >
        <div class="row">
            <!-- COLUMNA IZQUIERDA-->
            <div class="col-md-3 pt">
                <!----------MENU LEFT------------->
                <AdminMenuLeft:AdminMenuLeft id="AdminMenuLeft1" runat="server" ></AdminMenuLeft:AdminMenuLeft>
            </div>
            <!-- COLUMNA DERECHA-->
            <div class="col-md-9">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">
                           <%-- <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        QUE HACEMOS
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>--%>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <h3>Asignar o cambiar contraseña</h3>
                                               
                                                    <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
                                                    <div class="form-group ">
                                                                <label for="correo">Correo</label>
                                                                <asp:TextBox ID="txtCorreo" CssClass="form-control" placeholder="Ingrese Correo" runat="server" required></asp:TextBox>
                                                    </div>

                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">
                                                            <h4>Cambiar o asignar nueva contraseña</h4>
                                                            </div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Contraseña </label>
                                                                
                                                                <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" placeholder="Detalle brevemente" TextMode="Password"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Repita la contraseña</label>
                                                                <asp:TextBox ID="txtRePassword" CssClass="form-control" runat="server" placeholder="Detalle brevemente" TextMode="Password"></asp:TextBox>
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
                </div>

            </div>
            
        </div>
    </div>
</asp:Content>

