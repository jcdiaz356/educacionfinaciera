<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteConsolidado.aspx.cs" Inherits="Presentacion.ReporteConsolidado" %>
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
                                        REPORTE CONSOLIDADO
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="row">
                                            <div class="col-md-2">
                                            </div>
                                            <div class="col-md-8 text-center">
                                                <div class="table-responsive">
                                                    <table class="table">
                                                        <thead>
                                                            <tr>
                                                                <th>Descripción</th>
                                                                <th>Numero</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>
                                                                <td>Total Instituciones educativas asistidas</td>
                                                                <td><asp:Label ID="lblNumColegios" runat="server" Text="Num"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td>Cantidad de Fichas Microredes ingresadas</td>
                                                                <td><asp:Label ID="lblQFichasMicroredes" runat="server" Text="Num"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td>Cantidad Fichas acompañamiento a clase ingresadas</td>
                                                                <td><asp:Label ID="lblQFichasAcomClase" runat="server" Text="Num"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td>Cantidad Fichas de Visitas a IE ingresadas</td>
                                                                <td><asp:Label ID="lblQFichasVisitas" runat="server" Text="Num"></asp:Label></td>
                                                            </tr>
                                                            <tr>
                                                                <td>Cantidad de IE Visitados</td>
                                                                <td><asp:Label ID="lblQIEVisits" runat="server" Text="Num"></asp:Label></td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                            <div class="col-md-2">
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
