<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Presentacion.Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!------------CONTENEDOR-------------------->
    <div class="container" >
        <div class="row">
            <div class="col-md-6 col-md-offset-3 area-form">
                <div class="row">
                    <div class="col-md-6">
                        <div class="cuadro">
                            <div class="title">
                                INICIAR SESIÓN
                                <div class="triangulo_top_right" ></div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class="row">
                    <div class="col-md-12">
                        <div class="cuadro-form">
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <p>Inicia sesión ahora, para poder ver contenido</p>
                                    <label for="inputEmail3" class="col-sm-4 control-label">CORREO</label>
                                    <div class="col-sm-8">
                                        <%--<input type="email"  id="inputEmail3" >--%>
                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required placeholder="Email"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label for="inputPassword3" class="col-sm-4 control-label">CONTRASEÑA</label>
                                    <div class="col-sm-8">
                                        <%--<input type="password" class="form-control" id="inputPassword3" >--%>
                                        <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" required placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">

                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-4 col-sm-8">
                                        <%--<button type="submit" class="btn btn-default">INICIAR SESIÓN</button>--%>
                                        <asp:Button ID="cmdLogin" runat="server" Text="INICIAR SESIÓN"  CssClass="btn btn-default" OnClick="cmdLogin_Click" />
                                        <%--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>--%>
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

