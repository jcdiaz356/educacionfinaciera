<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportePorAsesor.aspx.cs" Inherits="Presentacion.ReportePorAsesor" %>
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
                                        TOTAL REPORTES POR ASESOR
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <h3>
                                                Cantidad de Colegios: <asp:Label ID="lblNumColegios" runat="server" Text="Num"></asp:Label></h3>
                                            </div>
                                        </div>
                                        

                                        <div class="row">
                                            <div class="col-md-8">
                                                <div class="text-center"><h4>Numero de Colegios por ASESOR</h4></div>
                                                <div class="table-responsive">
                                                    <table class="table">
                                                        <thead>
                                                            <tr>
                                                                <th>ASESOR</th>
                                                                <th>Num. Colegios</th>
                                                                <th>%</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <asp:Label ID="lblNumSchoolForAsesor" runat="server" Text=""></asp:Label>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
                                            </div>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-8">
                                                <div class="text-center"><h4>Numero de Profesores por ASESOR</h4></div>
                                                <div class="text-center"><h5>Total profesores: <asp:Label ID="lblCountTeachers" runat="server" Text=""></asp:Label></h5></div>
                                                <div class="table-responsive">
                                                    <table class="table">
                                                        <thead>
                                                            <tr>
                                                                <th>ASESOR</th>
                                                                <th>Num. Profesores</th>
                                                                <th>%</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <asp:Label ID="lblNumTeacherForAsesor" runat="server" Text=""></asp:Label>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                            <div class="col-md-4">
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
