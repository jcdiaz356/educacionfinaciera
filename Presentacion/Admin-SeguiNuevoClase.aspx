<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-SeguiNuevoClase.aspx.cs" Inherits="Presentacion.Admin_SeguiNuevoClase" %>
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
                                                <h3>Nueva ficha de acompañamiento en clase</h3>

                                                <div class="form-group ">
                                                        <div class="row">
                                                            <div class="col-md-5">
                                                                <label for="codigo">Fecha</label>
                                                               
                                                                <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                                                            </div>
                                                        </div>
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
                                                        
                                                         <asp:DropDownList ID="ddlDocente" CssClass="form-control" runat="server" onchange="poblandoGradeSection(this)"></asp:DropDownList>
                                                    </div>


                                                   <div class="form-group">
                                                        <label for="Sesion">Grado y sección</label>
                                                        <asp:ListBox ID="lblGradoSeccion" runat="server" CssClass="form-control input-sm"   Height="143px" onchange="poblandoNombSesion(this)">
                                                             
                                                         </asp:ListBox>
                                                        
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Nombre de sesión por Grado</label>
                                                        <asp:DropDownList ID="ddlNombSesion" CssClass="form-control" runat="server" onchange="poblandoNumSesion(this)">
                                                        </asp:DropDownList>
                                                        
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Participantes">N° de sesión</label>
                                                        <asp:DropDownList ID="ddlSesion" CssClass="form-control" runat="server">
                                                            
                                                        </asp:DropDownList>
                                                        
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Nro. de Estudiantes Asistentes a la clase</label>
                                                   
                                                        <asp:TextBox ID="txtEstidianteAsistentes" CssClass="form-control" runat="server" placeholder="Ingrese Nro. de Estudiantes Asistentes a la clase" TextMode="Number"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">La sesión esta de acuerdo a lo planificado</label>
                                                                <asp:RadioButtonList ID="rblPlanificado" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1" Selected="True"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0"> No</asp:ListItem>   
                                                                </asp:RadioButtonList>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Si es "NO" cual es el motivo</label>
                                                   
                                                        <asp:TextBox ID="txtMotivo" CssClass="form-control" runat="server" placeholder="Ingrese cual es el motivo" Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Desarrollo innovaciones</label>
                                                                <asp:RadioButtonList ID="rblInnovacion" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1" Selected="True"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0"> No</asp:ListItem>   
                                                        </asp:RadioButtonList>
                                                    </div>

                                                    <!-- Temas a desarrollar-->

                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">
                                                            <h4>¿Que innovaciones desarrolla?</h4>
                                                            </div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos informáticos(sistemas, programas, apps, blog, webs, etc.) </label>
                                                                
                                                                <asp:TextBox ID="txtRecursosInformáticos" CssClass="form-control" runat="server" placeholder="Detalle brevemente"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos audiovisuales(videos, música, proyección de diapositivas, etc.)</label>
                                                                <asp:TextBox ID="txtRecursosAudiovisuales" CssClass="form-control" runat="server" placeholder="Detalle brevemente"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Materiales Didácticos empleados para la sesión. (tarjetas de bancos, cheques, Boucher, Etc.)</label>
                                                                <asp:TextBox ID="txtMaterialesDidactico" CssClass="form-control" runat="server" placeholder="Detalle brevemente"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Dinámicas utilizadas en la sesión</label>
                                                                <asp:TextBox ID="txtDinamicasUsadas" CssClass="form-control" runat="server" placeholder="Detalle brevemente"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Otros (celulares, vistas, etc.)</label>
                                                                <asp:TextBox ID="TxtOtros" CssClass="form-control" runat="server" placeholder="Detalle brevemente"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>


                                                   <div class="form-group">
                                                        <label for="Sesion">¿El asesor intervino en la sesión?</label>
                                                                <asp:RadioButtonList ID="rblIntervino" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0" Selected="True"> No</asp:ListItem>   
                                                        </asp:RadioButtonList>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">¿Cómo intervino?</label>
                                                                <asp:RadioButtonList ID="rblComoIntervino" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="Apoyo"> Apoyo</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="Hizo la sesión"> Hizo la sesión</asp:ListItem>   
                                                        </asp:RadioButtonList>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Intervención de otros colaboradores</label>
                                                                <asp:RadioButtonList ID="rblOtrosColaboradores" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0" Selected="True"> No</asp:ListItem>   
                                                        </asp:RadioButtonList>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Observaciones">¿Quien?</label>
                                                      
                                                         <asp:TextBox ID="txtQuien" CssClass="form-control" runat="server" placeholder="Ingrese Quien " Enabled="False" ></asp:TextBox>
                                                    </div>

                                                     <div class="form-group">
                                                        <label for="Observaciones">¿Cómo intervino?</label>
                                                      
                                                         <asp:TextBox ID="txtComoIntervino" CssClass="form-control" runat="server" placeholder="Ingrese ¿Cómo intervino " Enabled="False" ></asp:TextBox>
                                                    </div>
                                                    
                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">
                                                            <h4>Participa en el juego</h4>
                                                            </div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                 <asp:RadioButtonList ID="rblParticipaJuego" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1" Selected="True"> Si</asp:ListItem>
                                                                     
                                                                    <asp:ListItem CssClass="form-control" Value="0"> No</asp:ListItem>  
                                                                      
                                                                 </asp:RadioButtonList>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">¿En que etapa están?</label>
                                                                <asp:TextBox ID="txtEtapa" CssClass="form-control" runat="server" placeholder="Ingrese en que etapa están" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">¿Cual es la razón?</label>
                                                                <asp:TextBox ID="txtRazon" CssClass="form-control" runat="server" placeholder="Ingrese cual es la razón" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            
                                                        </div>
                                                    </div>

                                                    
                                                    <div class="form-group">
                                                         <label for="Observaciones">Principal Incidencia</label>
                                                         <asp:TextBox ID="txtInsidencia" CssClass="form-control" runat="server" placeholder="Ingrese principal Incidencia " TextMode="MultiLine"></asp:TextBox>
                                                    </div>

                                                    

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
    <script>

        $("#<%=rblPlanificado.ClientID%>").change(function () {
            var rbvalue = $("input[name='<%=rblPlanificado.UniqueID%>']:radio:checked").val();

            if (rbvalue == "1") {
                // alert("Woohoo, Thanks!");
                $("#<%=txtMotivo.ClientID%>").prop('disabled', true);
            } else if (rbvalue == "0") {
                // alert("Well, I really hope it's soon");
                $("#<%=txtMotivo.ClientID%>").prop('disabled', false);
            }
        });


        $("#<%=rblOtrosColaboradores.ClientID%>").change(function () {
            var rbvalue = $("input[name='<%=rblOtrosColaboradores.UniqueID%>']:radio:checked").val();

            if (rbvalue == "1") {
                // alert("Woohoo, Thanks!");
                $("#<%=txtQuien.ClientID%>").prop('disabled', false);
                $("#<%=txtComoIntervino.ClientID%>").prop('disabled', false);
            } else if (rbvalue == "0") {
                // alert("Well, I really hope it's soon");
                $("#<%=txtQuien.ClientID%>").prop('disabled', true);
                $("#<%=txtComoIntervino.ClientID%>").prop('disabled', true);
            }
        });

        $("#<%=txtEtapa.ClientID%>").prop('disabled', false);
        $("#<%=rblParticipaJuego.ClientID%>").change(function () {
            var rbvalue = $("input[name='<%=rblParticipaJuego.UniqueID%>']:radio:checked").val();

            if (rbvalue == "1") {
                // alert("Woohoo, Thanks!");
                $("#<%=txtEtapa.ClientID%>").prop('disabled', false);
                $("#<%=txtRazon.ClientID%>").prop('disabled', true);
            } else if (rbvalue == "0") {
                // alert("Well, I really hope it's soon");
                $("#<%=txtEtapa.ClientID%>").prop('disabled', true);
                $("#<%=txtRazon.ClientID%>").prop('disabled', false);
            }
        });




        ///////
        $("input[name='<%=rblComoIntervino.UniqueID%>']").attr('disabled', true);
        $("#<%=rblIntervino.ClientID%>").change(function () {
            var rbvalue = $("input[name='<%=rblIntervino.UniqueID%>']:radio:checked").val();
            console.log(rbvalue);
            if (rbvalue == "1") {
                // alert("Woohoo, Thanks!");
                $("input[name='<%=rblComoIntervino.UniqueID%>']").attr('disabled', false);
                $("input[name='<%=rblComoIntervino.UniqueID%>']").attr('checked', false);
            } else if (rbvalue == "0") {
                // alert("Well, I really hope it's soon");
                $("input[name='<%=rblComoIntervino.UniqueID%>']").attr('disabled', true);
                $("input[name='<%=rblComoIntervino.UniqueID%>']").attr('checked', false);
            }
        });






        $("#<%= ddlSchool.ClientID %>").attr("disabled", true);
        $("#<%= ddlDocente.ClientID %>").attr("disabled", true); 
        $("#<%= ddlNombSesion.ClientID %>").attr("disabled", true);
        $("#<%= ddlSesion.ClientID %>").attr("disabled", true);

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
                 $("#<%= ddlDocente.ClientID %>").append("<option value=0>--Seleccione docente--</option>");
                 $.each(data, function (i, item) {
                     console.log(item);


                     $("#<%= ddlDocente.ClientID %>").append("<option value=\"" + item.id + "\">" + item.FullName + "</option>");
                });
            }

            } 

        function poblandoGradeSection(ddl) {
            
            var selected = [];
            var selectedId = "";
            var selectedNombre = "";
            $('#' + ddl.id + ' :selected').each(function () {
                var id = $(this).val();
                var getPedido = "";
                getPedido = "&tipo=allGradeSectionForTeacher&idDocente=" + id;
                $.ajax({
                    url: "Admin-OperationsJSON.aspx",
                    dataType: "json",
                    type: "POST",
                    data: getPedido,
                    success: poblandoComboGrade
                });

            });
            function poblandoComboGrade(data) {
                $("#<%= lblGradoSeccion.ClientID %>").attr("disabled", false);
                $("#<%= lblGradoSeccion.ClientID %>").empty();
                $.each(data, function (i, item) {
                    console.log(item);


                    $("#<%= lblGradoSeccion.ClientID %>").append("<option value=\"" + item.Id + "\">" + item.Grade + "|" + item.Seccion  + "</option>");
                });
            }
        }

        function poblandoNombSesion(ddl) {

            var selected = [];
            var selectedId = "";
            var selectedNombre = "";
            $('#' + ddl.id + ' :selected').each(function () {
                var id = $(this).text();
                var getPedido = "";
                var grade = id.split('|');
                var grade1 = grade[0];
                getPedido = "&tipo=allTemForGrade&grade=" + grade1;
                $.ajax({
                    url: "Admin-OperationsJSON.aspx",
                    dataType: "json",
                    type: "POST",
                    data: getPedido,
                    success: poblandoComboGrade
                });

            });
            function poblandoComboGrade(data) {
                $("#<%= ddlNombSesion.ClientID %>").attr("disabled", false);
                $("#<%= ddlNombSesion.ClientID %>").empty();
                $("#<%= ddlNombSesion.ClientID %>").append("<option value=0>--Seleccione Tema--</option>");
                $.each(data, function (i, item) {
                    console.log(item);


                    $("#<%= ddlNombSesion.ClientID %>").append("<option value=\"" + item.Id + "\">" + item.Name + "</option>");
                });
            }
        }

        function poblandoNumSesion(ddl) {
            var selected = [];
            var selectedId = "";
            var selectedNombre = "";
            $('#' + ddl.id + ' :selected').each(function () {
                var id = $(this).val();
                var getPedido = "";
                getPedido = "&tipo=allNumSesionForTem&tema_id=" + id;
                $.ajax({
                    url: "Admin-OperationsJSON.aspx",
                    dataType: "json",
                    type: "POST",
                    data: getPedido,
                    success: poblandoComboGrade
                });

            });
            function poblandoComboGrade(data) {
                $("#<%= ddlSesion.ClientID %>").attr("disabled", false);
                $("#<%= ddlSesion.ClientID %>").empty();
                $("#<%= ddlSesion.ClientID %>").append("<option value=0>--Seleccione Num. Sesión--</option>");
                $.each(data, function (i, item) {
                    console.log(item);


                    $("#<%= ddlSesion.ClientID %>").append("<option value=\"" + item.Id + "\">" + item.NumSesion + "</option>");
                });
            }
        }
        
    </script>

    <script  type="text/javascript">





        $('#forSend').submit(function () {
            //alert('The time sheet you submited is not complete');
            confirmar = confirm("Está seguro que desea guaradar la ficha.");
            if (confirmar) {
                //alert("Seleccionaste aceptar")
                return true;
            }

            else {
                //alert("Seleccionaste cancelar")
                return false;
            }

        });


</script> 
   

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
