<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteAcomClases.aspx.cs" Inherits="Presentacion.ReporteAcomClases" %>
<%@ Register TagPrefix="AdminMenuLeftRepo" tagname="AdminMenuLeftRepo" src="UscControl/AdminMenuLeftRepo.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" >
        <div class="row">
            <!-- COLUMNA IZQUIERDA-->
            <div class="col-md-3 pt">
                <!----------MENU LEFT------------->
                <AdminMenuLeftRepo:AdminMenuLeftRepo id="AdminMenuLeftRepo1" runat="server" ></AdminMenuLeftRepo:AdminMenuLeftRepo>
            </div>
            <!-- COLUMNA DERECHA-->
            <div class="col-md-9">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        Reportes Acompañamiento a Clases
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <a href="?opcion=asesor&id=6"><button type="button" class="btn btn-primary">Por Asesor</button></a>
                                                <!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
                                                <a href="?opcion=profesor&id=6"><button type="button" class="btn btn-primary">Por Profesor</button></a>
                                                <a href="?opcion=temas&id=6"><button type="button" class="btn btn-primary">Por Temas</button></a>
                                            </div>
                                        </div>
                                        
                                        <%if (Request.Params["opcion"] == "asesor")
                                          {%>
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <h3>
                                                    Numero de Acompañamientos a Clase por Asesor</h3>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-8">
                                                    <div class="text-center"><h4>Cantidad de Visitas: <asp:Label ID="lblNumAcomp" runat="server" Text="Num"></asp:Label></h4></div>
                                                    <%--<div class="text-center"><h4>Numero de Asesores <asp:Label ID="lblQAsesor" runat="server" Text=""></asp:Label></h4></div>--%>
                                                    <div class="table-responsive">
                                                        <table class="table">
                                                            <thead>
                                                                <tr>
                                                                    <th>Asesor</th>
                                                                    <th>Num. de acompañamientos</th>
                                                                    <th>%</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                                <asp:Label ID="lblNumAcompaForAsesor" runat="server" Text=""></asp:Label>
                                                            </tbody>
                                                        </table>
                                                    </div>
                                                </div>
                                                <div class="col-md-4">
                                                </div>
                                            </div>

                                        <%} %>
                                        <%if (Request.Params["opcion"] == "profesor")
                                          {%>
                                            <div class="row">
                                                <div class="col-md-12 text-center">
                                                    <h3>
                                                    Numero de Acompañamientos a Clase por Profesor</h3>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <div class="text-center"><h4>Cantidad de Visitas: <asp:Label ID="lblNumAcomProfe" runat="server" Text="Num"></asp:Label></h4></div>
                                                    <%--<div class="text-center"><h4>Numero de Asesores <asp:Label ID="lblQAsesor" runat="server" Text=""></asp:Label></h4></div>--%>
                                                    <div class="table-responsive">
                                                        <table class="table">
                                                            <thead>
                                                                <tr>
                                                                    <th>Orden</th>
                                                                    <th>Codigo</th>
                                                                    <th>Profesor</th>
                                                                    <th>Nro. de acompañamientos</th>
                                                                    <th>Nro. de bloques temáticos aplicados</th>
                                                                    <th>Nro. de sesiones aplicadas</th>
                                                                    <th>Nro. Veces que asesor intervino</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                                <asp:Label ID="lblNumAcompaForProfesor" runat="server" Text=""></asp:Label>
                                                            </tbody>
                                                        </table>
                                                    </div>
                                                </div>
                                            </div>
                                        <%} %>

                                        <%if (Request.Params["opcion"] == "temas")
                                          {%>
                                            <div class="row">
                                                <div class="col-md-12 text-center">
                                                    <h3>
                                                    Numero de Profesores por Tema</h3>
                                                </div>
                                            </div>
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <div class="text-center"><h4>Participan en el Juego</h4></div>
                                                    <div class="text-center"><h4>Numero de colegios: <asp:Label ID="NumColJuego" runat="server" Text="Num"></asp:Label></h4></div>
                                                    <div class="text-center"><h4>Numero de profesores: <asp:Label ID="NumProfJuego" runat="server" Text="Num"></asp:Label></h4></div>
                                                    <div class="table-responsive">
                                                        <table class="table">
                                                            <thead>
                                                                <tr>
                                                                    <th>Orden</th>
                                                                    <th>Boques temáticos</th>
                                                                    <th>Nro. de sesiones aplicadas</th>
                                                                    <th>Nro. docentes</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                                <asp:Label ID="lblNumAcompaForTema" runat="server" Text=""></asp:Label>
                                                            </tbody>
                                                        </table>
                                                    </div>
                                                </div>
                                            </div>
                                        <%} %>
                                        
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
