<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="excell.aspx.cs" Inherits="Presentacion.excell" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
    <asp:Button ID="cmdExportar" runat="server" Text="Exportar a Excell" OnClick="cmdExportar_Click" />

    <table class="table">
                                                    <caption>Listado de Asesores.</caption>
                                                    <thead>
                                                    <tr>
                                                        <th>Nº</th>
                                                        <th>Codigo</th>
                                                        <th>Nombre Asesor</th>
                                                        <th>Fecha Creación</th>
                                                        <th>Operaciones</th>
                                                    </tr>
                                                    </thead>
                                                    <tbody>
                                                    
                                                        <asp:Label ID="FilasListaAsesores" runat="server" Text=""></asp:Label>
                                                    </tbody>
                                                </table>

    <div>
            <!-- BUTTON CONTROL TO EXPORT DATA TO EXCEL. -->
            <p><asp:Button ID="cmdExportar4" runat="server" Text="Exportar Otra libreria" OnClick="cmdExportar4_Click" />
            </p>

            <!-- SHOW MESSAGE. -->
            <p>&nbsp;</p>

            
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
