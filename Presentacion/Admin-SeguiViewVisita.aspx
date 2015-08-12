<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-SeguiViewVisita.aspx.cs" Inherits="Presentacion.Admin_SeguiViewVisita" %>
<%@ Register TagPrefix="AdminMenuLeftSegui" tagname="AdminMenuLeftSegui" src="UscControl/AdminMenuLeftSegui.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!------------CONTENEDOR-->
    <div class="container" >
        <div class="row">
            <!-- COLUMNA IZQUIERDA-->
            <div class="col-md-3 pt">
                <!----------MENU LEFT------------->
                <AdminMenuLeftSegui:AdminMenuLeftSegui id="AdminMenuLeftSegui1" runat="server" ></AdminMenuLeftSegui:AdminMenuLeftSegui>
            </div>
            <!-- COLUMNA DERECHA-->
            <div class="col-md-9">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">
                          
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <h3>&nbsp;Ficha de Visita</h3>

                                                <div class="form-group ">
                                                        <div class="row">
                                                            <div class="col-md-5">
                                                                <label for="codigo">Fecha</label>
                                                                <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server" TextMode="Date" Enabled="False"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <%--<div class="form-group">
                                                        <label for="Microred">Nombre</label>
                                                        
                                                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="Ingrese Nombre" required></asp:TextBox>
                                                    </div>--%>


                                                    <div class="form-group">
                                                        <label for="Asesor">Asesor</label>
                                                        
                                                        <asp:TextBox ID="txtAsesor" CssClass="form-control" runat="server" placeholder="Ingrese Asesor" Enabled="False"></asp:TextBox>
                                                        <%--<asp:DropDownList ID="ddlAsesor" CssClass="form-control" runat="server" onchange="poblandoColegio(this)"></asp:DropDownList>--%>
                                                    </div>

                                                

                                                <div class="form-group">
                                                        <label for="Sesion">Ínstitución Educativa</label>
                                                        <asp:TextBox ID="txtSchool" CssClass="form-control" runat="server" placeholder="Ingrese Asesor" Enabled="False"></asp:TextBox>
                                                        <%--<asp:DropDownList ID="ddlSchool" CssClass="form-control" runat="server" onchange="poblandoProfesor(this)"></asp:DropDownList>--%>
                                                    </div>



                                                <div class="form-group">
                                                       
                                                        <label for="Sesion">Docente</label>
                                                         <%--<asp:DropDownList ID="ddlDocente" CssClass="form-control" runat="server"></asp:DropDownList>--%>
                                                        <asp:TextBox ID="txtDocente" CssClass="form-control" runat="server" placeholder="Ingrese Asesor" Enabled="False"></asp:TextBox>
                                                    </div>

                                                <div class="form-group">
                                                       <label for="Sesion">Director</label>
                                                        <asp:TextBox ID="txtDirector" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                         <%--<asp:DropDownList ID="ddlDirector" CssClass="form-control" runat="server"></asp:DropDownList>--%>
                                                    </div>


                                                    <div class="form-group">
                                                        <label for="Sesion">Motivos de la visita</label><br />

                                                        <asp:TextBox ID="txtMotivoVisita" CssClass="form-control" runat="server" placeholder="Ingrese Asesor" Enabled="False"></asp:TextBox>

                                                        <%--<asp:CheckBox ID="chkA"   runat="server" Text="Coordinaciones con el Director" /><br />
                                                        <asp:CheckBox ID="chkB"   runat="server" Text="Coordinaciones con el Docente" /><br />
                                                        <asp:CheckBox ID="chkC"   runat="server" Text="Acompañamiento al docente fuera de clases"/><br />
                                                        <asp:CheckBox ID="chkD"   runat="server" Text="Acompañamiento al docente en clase" />    --%>   
                                                    </div>
                                                           
                                                       


                                                    <div class="form-group">
                                                        <label for="Observaciones">Observaciones</label>
                                                      
                                                         <asp:TextBox ID="txtObservacion" CssClass="form-control" runat="server" placeholder="Ingrese Observaciones " TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Observaciones">Pendientes para la próxima visita</label>
                                                      
                                                         <asp:TextBox ID="TxtPendientes" CssClass="form-control" runat="server" placeholder="Ingrese Observaciones " TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <asp:Button ID="CmdVolver" CssClass="btn btn-default" runat="server" Text="Volver" OnClick="CmdVolver_Click"  />
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
    <script>

       <%-- $("#<%= ddlSchool.ClientID %>").attr("disabled", true);
        $("#<%= ddlDocente.ClientID %>").attr("disabled", true);
        $("#<%= ddlDirector.ClientID %>").attr("disabled", true);--%>

       
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>

