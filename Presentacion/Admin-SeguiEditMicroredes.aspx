<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-SeguiEditMicroredes.aspx.cs" Inherits="Presentacion.Admin_SeguiEditMicroredes" %>
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
                                                <h3>Nueva Ficha</h3>

                                                  <div class="form-group ">
                                                         
                                                                <label for="codigo">Fecha</label>
                                                               
                                                                <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server" TextMode="Date" required></asp:TextBox>
                                                             
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="Asesor">Asesor</label>
                                                        
                                                        <%--<asp:TextBox ID="txtAsesor" CssClass="form-control" runat="server" placeholder="Ingrese Asesor"></asp:TextBox>--%>
                                                        <asp:DropDownList ID="ddlAsesor" CssClass="form-control" runat="server" onchange="poblandoColegio(this)"></asp:DropDownList>
                                                    </div>

                                                

                                                <div class="form-group">
                                                        <label for="Sesion">Ínstitución Educativa</label>
                                                   
                                                        <asp:DropDownList ID="ddlSchool" CssClass="form-control" runat="server" onchange="poblandoProfesor(this)"></asp:DropDownList>
                                                    </div>



                                                <div class="form-group">
                                                        <label for="Microred">Docente</label>
                                                        
                                                         <asp:DropDownList ID="ddlDocente" CssClass="form-control" runat="server"></asp:DropDownList>
                                                    </div>


                                                    <div class="form-group">
                                                        <label for="Microred">Nombre de Microred</label>
                                                        
                                                        <asp:TextBox ID="txtMircrored" CssClass="form-control" runat="server" placeholder="Ingrese Nombre de Microred" required></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Lugar de Sesión</label>
                                                   
                                                        <asp:TextBox ID="txtSesion" CssClass="form-control" runat="server" placeholder="Ingrese Lugar de Sesión" required></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Inicio">Hora Inicio</label>
                                                        
                                                        <asp:TextBox ID="txtInicio" CssClass="form-control" runat="server" placeholder="Ingrese Hora Inicio" TextMode="Time" required></asp:TextBox>
                                                        <label for="termino">Hora de termino</label>
                                                       
                                                        <asp:TextBox ID="txtTermino" CssClass="form-control" runat="server" placeholder="Ingrese  Hora de termino" TextMode="Time" required></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Participantes">N° de Participantes</label>
                                                        
                                                        <asp:TextBox ID="txtParticipante" CssClass="form-control" runat="server" placeholder="Ingrese N° de Participantes" TextMode="Number" required></asp:TextBox>
                                                    </div>


                                                    <!-- Temas a desarrollar-->

                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">Temas desarrollados</div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Educación Financiera</label>
                                                                
                                                                <asp:TextBox ID="txtEducacion" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Enfoques Educativos</label>
                                                                <asp:TextBox ID="txtEnfoque" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Programación Pedagógica</label>
                                                                <asp:TextBox ID="txtProgramacion" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Habilidades Pedagógicas</label>
                                                                <asp:TextBox ID="txtHabilidades" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>



                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">Metodología de la sesión</div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Trabajo grupal o en parejas</label>
                                                               
                                                                <asp:TextBox ID="txtTrabajo" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Participativo</label>
                                                                <asp:TextBox ID="txtParticipativo" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Expositivo</label>
                                                                <asp:TextBox ID="txtExpositivo" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Dinámicas Lúdicas</label>
                                                                <asp:TextBox ID="txtDinamicas" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>



                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">Materiales utilizados</div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos Informáticos</label>
                                                                 <asp:TextBox ID="txtRecursos" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos Audiovisuales</label>
                                                                 <asp:TextBox ID="txtAudiovisuales" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Materiales Didácticos</label>
                                                                 <asp:TextBox ID="txtMateriales" CssClass="form-control" runat="server" placeholder="Especificar" TextMode="MultiLine"></asp:TextBox>
                                                            </div>


                                                        </div>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Observaciones">Observaciones</label>
                                                      
                                                         <asp:TextBox ID="txtObservacion" CssClass="form-control" runat="server" placeholder="Ingrese Observaciones " TextMode="MultiLine"></asp:TextBox>
                                                    </div>

                                                    <asp:Button ID="CmdGuardar" CssClass="btn btn-default" runat="server" Text="Guardar" OnClick="CmdGuardar_Click" />
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

        $("#<%= ddlSchool.ClientID %>").attr("disabled", true);
        $("#<%= ddlDocente.ClientID %>").attr("disabled", true);

        function poblandoColegio(ddl) {

           <%-- var lblPrueba = document.getElementById('<%= lblPrueba1.ClientID %>');--%>
            // lblPrueba.value = "Hola";
            //console.log(ddl.id);
            var selected = [];
            var selectedId = "";
            var selectedNombre = "";
            $('#' + ddl.id + ' :selected').each(function () {
                //selected[$(this).val()] = $(this).text();
                // selectedId += $(this).val() + "|";
                // selectedNombre += $(this).text() + "|";


                var id = $(this).val();
                var getPedido = "";
                getPedido = "&tipo=allSchoolAsesor&idAsesor=" + id;
                $.ajax({
                    url: "Admin-OperationsJSON.aspx",
                    dataType: "json",
                    type: "POST",
                    data: getPedido,
                    success: poblandoComboColegios
                });

            });

            function poblandoComboColegios(data) {
                $("#<%= ddlSchool.ClientID %>").attr("disabled", false);
                $("#<%= ddlSchool.ClientID %>").empty();
                $("#<%= ddlSchool.ClientID %>").append("<option value=0>--Seleccione colegio--</option>");
                $.each(data, function (i, item) {
                    //console.log(item.id);


                    $("#<%= ddlSchool.ClientID %>").append("<option value=\"" + item.id + "\">" + item.Nombre + "</option>");
                });
                }

            }



            function poblandoProfesor(ddl) {

           <%-- var lblPrueba = document.getElementById('<%= lblPrueba1.ClientID %>');--%>
            // lblPrueba.value = "Hola";
            //console.log(ddl.id);
            var selected = [];
            var selectedId = "";
            var selectedNombre = "";
            $('#' + ddl.id + ' :selected').each(function () {
                //selected[$(this).val()] = $(this).text();
                // selectedId += $(this).val() + "|";
                // selectedNombre += $(this).text() + "|";


                var id = $(this).val();
                var getPedido = "";
                getPedido = "&tipo=allDocenteSchool&idSchool=" + id;
                $.ajax({
                    url: "Admin-OperationsJSON.aspx",
                    dataType: "json",
                    type: "POST",
                    data: getPedido,
                    success: poblandoComboColegios
                });

            });

            function poblandoComboColegios(data) {
                $("#<%= ddlDocente.ClientID %>").attr("disabled", false);
                 $("#<%= ddlDocente.ClientID %>").empty();
                 $("#<%= ddlDocente.ClientID %>").append("<option value=0>--Seleccione colegio--</option>");
                 $.each(data, function (i, item) {
                     console.log(item);


                     $("#<%= ddlDocente.ClientID %>").append("<option value=\"" + item.id + "\">" + item.FullName + "</option>");
                });
            }

        }
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>