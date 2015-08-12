<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-EditAsesor.aspx.cs" Inherits="Presentacion.Admin_EditAsesor" %>
<%@ Register TagPrefix="AdminMenuLeft" tagname="AdminMenuLeft" src="UscControl/AdminMenuLeft.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!------------//CONTENEDOR-->
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
                           
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <p>Editar Asesor</p>
                                                
                                                    <div class="form-group ">
                                                        <div class="row">
                                                            <div class="col-md-5">
                                                                <label for="codigo">Código de Asesor</label>
                                                                <asp:TextBox ID="txtCodigo" CssClass="form-control col-md-5" placeholder="Ingrese Código de Asesor" runat="server" required></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="nombreapellido">Nombres y Apellidos</label>
                                                        
                                                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="Ingrese Nombres y Apellidos" required></asp:TextBox>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="Telefono">Teléfono</label>
                                                        
                                                        <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server" placeholder="Ingrese Telefono" MaxLength="10"  TextMode="Phone" required></asp:TextBox>
                                                    </div>

                                                    
                                                    <div class="form-group">
                                                        <label for="Docente">Nombre del Escuela a cargo</label>
                                                         <asp:ListBox ID="lblEscuelaACargo" runat="server" CssClass="form-control input-sm" onchange="contadorEscuela(this)" SelectionMode="Multiple"  Height="143px" >
                                                             
                                                         </asp:ListBox>
                                                    </div>
                                               
                                                    <%--<div class="form-group">
                                                        <label for="Docente">Nombre del docente a cargo</label>
                                                         <asp:ListBox ID="lblDocenteCaCargo" runat="server" CssClass="form-control input-sm" onchange="contadorDocente(this)" SelectionMode="Multiple"  Height="143px">
                                                             
                                                         </asp:ListBox>
                                                    </div>--%>

                                                    <div class="form-group">
                                                            <label for="Telefono">Nº de IEs a cargo</label>
                                                            
                                                            <asp:TextBox ID="txtDocenteACargo" CssClass="form-control" runat="server" placeholder=" Nº de docentes a cargo"  MaxLength="3" Enabled="False"  ></asp:TextBox>
                                                    </div>

                                                    <%--<div class="form-group">
                                                            <label for="Telefono">Nº de IEs a cargo</label>
                                                            
                                                            <asp:TextBox ID="txtISACargo" CssClass="form-control" runat="server" placeholder=" Nº de IEs a cargo" Enabled="False"></asp:TextBox>
                                                    </div>--%>

                                                    <div class="form-group">
                                                        <label for="Grupo">Grupo</label>
                                                         <asp:DropDownList ID="ddlGrupo" runat="server"  CssClass="form-control input-sm" >
                                                            <asp:ListItem>A</asp:ListItem>
                                                            <asp:ListItem>B</asp:ListItem>
                                                        </asp:DropDownList>
                                                        
                                                    </div>

                                                    <!-- Temas a desarrollar-->
                                                    <asp:Button ID="cmdGuardar" CssClass="btn btn-default" runat="server" Text="Guardar" OnClick="cmdGuardar_Click" />
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
    <script type="text/javascript">
        

           
        //return false;

            function contadorEscuela(ddl) {
                //alert(ddl.selectedIndex); 
                var sel = document.getElementById('<%= lblEscuelaACargo.ClientID %>');
                var optsLength = sel.options.length;
                var txtDocenteACargo = document.getElementById('<%= txtDocenteACargo.ClientID %>');
                
                var contador = 0;
                //txtDocenteACargo.value = '';
                for (var i = 0; i < optsLength; i++) {
                    if (sel.options[i].selected) {
                        contador++;
                        //txtDocenteACargo.value += 'Selected Value: ' + sel.options[i].value + " Selected Text: " + sel.options[i].text + "<br/>";   
                    }

                }

                txtDocenteACargo.value = contador;

               // return
            }

           <%-- function contadorDocente(ddl) {
                //alert(ddl.selectedIndex); 
                    var sel = document.getElementById('<%= lblDocenteCaCargo.ClientID %>');
                    var optsLength = sel.options.length;
                   // var txtDocenteACargo = document.getElementById('<%= txtDocenteACargo.ClientID %>');
                    var txtISACargo = document.getElementById('<%= txtISACargo.ClientID %>');
                    var contador = 0;
                    //txtDocenteACargo.value = '';
                    for (var i = 0; i < optsLength; i++) {
                        if (sel.options[i].selected) {
                            contador++;
                            //txtDocenteACargo.value += 'Selected Value: ' + sel.options[i].value + " Selected Text: " + sel.options[i].text + "<br/>";

                        }

                    }

                    txtISACargo.value = contador;
            }--%>

        
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
