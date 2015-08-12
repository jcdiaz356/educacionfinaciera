<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-IngEscuela.aspx.cs" Inherits="Presentacion.Admin_IngEscuela" %>
<%@ Register TagPrefix="AdminMenuLeft" tagname="AdminMenuLeft" src="UscControl/AdminMenuLeft.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!------------CONTENEDOR-->
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
                                                <h3>Nueva Escuela</h3>
                                                 
                                                    <div class="form-group ">
                                                        <div class="row">
                                                            <div class="col-md-5">
                                                                <label for="codigo">Código de Escuela</label>
                                                                <asp:TextBox ID="txtCodigo" CssClass="form-control col-md-5" placeholder="Ingrese Código de Escuela" runat="server" required></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    
                                                    <div class="form-group">
                                                        <label for="nombreapellido">Nombres y Número de la Escuela</label>
                                                        <asp:TextBox ID="txtNombreEscuela" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="grado">Telefono</label>
                                                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                                                    </div>


                                                    <div class="form-group">
                                                        <label for="grado">Dirección</label>
                                                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="grado">Distrito</label>
                                                        <asp:DropDownList ID="DdlDistrito" runat="server" CssClass="form-control"></asp:DropDownList>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="grado">Referencia</label>
                                                        <asp:TextBox ID="referencia" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="ugel">Seleccionar UGEL</label>
                                                        <asp:DropDownList ID="DdlUgel" runat="server" CssClass="form-control"></asp:DropDownList>
                                                    </div> 
                                                    
                                                    <%--<div class="form-group">
                                                        <label for="grado">Director</label>
                                                        <asp:TextBox ID="director" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>--%>
                                                    <%--<div class="form-group">
                                                        <label for="grado">Sub Director</label>
                                                        <asp:TextBox ID="SubDirector" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>--%>
                                                    <div class="form-group">
                                                        <label for="grado">Nro. Docentes HGE</label>
                                                        <asp:TextBox ID="NumDocHGE" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>
                                                    <%--<div class="form-group">
                                                        <label for="grado">Nro. Docentes Inicial</label>
                                                        <asp:TextBox ID="NumDocIni" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>--%>
                                                    <%--<div class="form-group">
                                                        <label for="grado">Nro. Docentes Primaria</label>
                                                        <asp:TextBox ID="NumDocPrim" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>--%>
                                                    <div class="form-group">
                                                        <label for="grado">Nro. Docentes Secundaria</label>
                                                        <asp:TextBox ID="NumDocSec" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>
                                                    <%--<div class="form-group">
                                                        <label for="grado">Nro. Alumnos Inicial</label>
                                                        <asp:TextBox ID="NumAlumIni" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>--%>
                                                   <%-- <div class="form-group">
                                                        <label for="grado">Nro. Alumnos Primaria</label>
                                                        <asp:TextBox ID="NumAlumPrim" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>--%>
                                                    <div class="form-group">
                                                        <label for="grado">Nro. Alumnos Secundaria</label>
                                                        <asp:TextBox ID="NumAlumSec" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>
                                                    <%--<div class="form-group">
                                                        <label for="grado">Nro. Aulas</label>
                                                        <asp:TextBox ID="NumAulas" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>--%>
                                                    <%--<div class="form-group">
                                                        <label for="grado">Nro. Secciones Primaria</label>
                                                        <asp:TextBox ID="NumSeccPrim" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>--%>
                                                    <div class="form-group">
                                                        <label for="grado">Nro. Secciones Secundaria</label>
                                                        <asp:TextBox ID="NumSeccSec" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="grado">Latitud</label>
                                                        <asp:TextBox ID="latitud" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="grado">Longitud</label>
                                                        <asp:TextBox ID="longitud" runat="server" CssClass="form-control"></asp:TextBox>
                                                    </div>

                                                    <asp:Button ID="CmdGuardar" runat="server" Text="Guardar" CssClass="btn btn-default" OnClick="CmdGuardar_Click" />
                                               
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
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
