<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-SeguiNuevoVisita.aspx.cs" Inherits="Presentacion.Admin_SeguiNuevoVisita" %>
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
                                                <h3>Nueva Ficha de Visita</h3>

                                                <div class="form-group ">
                                                        <div class="row">
                                                            <div class="col-md-5">
                                                                <label for="codigo">Fecha</label>
                                                                <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server" TextMode="Date"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    <%--<div class="form-group">
                                                        <label for="Microred">Nombre</label>
                                                        
                                                        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="Ingrese Nombre" required></asp:TextBox>
                                                    </div>--%>


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
                                                       <asp:CheckBox ID="chkDocente"   runat="server" Text="Docente" /><br />
                                                        
                                                         <asp:DropDownList ID="ddlDocente" CssClass="form-control" runat="server"></asp:DropDownList>
                                                    </div>

                                                <div class="form-group">
                                                       <asp:CheckBox ID="chkDirector"   runat="server" Text="Director" /><br />
                                                        
                                                         <asp:DropDownList ID="ddlDirector" CssClass="form-control" runat="server"></asp:DropDownList>
                                                    </div>


                                                    <div class="form-group">
                                                        <label for="Sesion">Motivos de la visita</label><br />
                                                        <asp:CheckBox ID="chkA"   runat="server" Text="Coordinaciones con el Director" /><br />
                                                        <asp:CheckBox ID="chkB"   runat="server" Text="Coordinaciones con el Docente" /><br />
                                                        <asp:CheckBox ID="chkC"   runat="server" Text="Acompañamiento al docente fuera de clases"/><br />
                                                        <asp:CheckBox ID="chkD"   runat="server" Text="Acompañamiento al docente en clase" />       
                                                    </div>
                                                           
                                                       


                                                    <div class="form-group">
                                                        <label for="Observaciones">Observaciones</label>
                                                      
                                                         <asp:TextBox ID="txtObservacion" CssClass="form-control" runat="server" placeholder="Ingrese Observaciones " TextMode="MultiLine"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Observaciones">Pendientes para la próxima visita</label>
                                                      
                                                         <asp:TextBox ID="TxtPendientes" CssClass="form-control" runat="server" placeholder="Ingrese Pendientes para la próxima visita " TextMode="MultiLine"></asp:TextBox>
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
        $("#<%= ddlDirector.ClientID %>").attr("disabled", true);

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
                        success: poblandoComboProfesor
                    });



                    var id = $(this).val();
                    var getPedido = "";
                    getPedido = "&tipo=allDirectorSchool&idSchool=" + id;
                    $.ajax({
                        url: "Admin-OperationsJSON.aspx",
                        dataType: "json",
                        type: "POST",
                        data: getPedido,
                        success: poblandoComboDirector
                    });

                });

                function poblandoComboProfesor(data) {
                    //$("#<%= ddlDocente.ClientID %>").attr("disabled", false);
                    $("#<%= ddlDocente.ClientID %>").empty();
                    $("#<%= ddlDocente.ClientID %>").append("<option value=0>--Seleccione Profesor--</option>");
                    $.each(data, function (i, item) {
                        //console.log(item);


                        $("#<%= ddlDocente.ClientID %>").append("<option value=\"" + item.id + "\">" + item.FullName + "</option>");
                     });
                }

                function poblandoComboDirector(data) {
                    //$("#<%= ddlDirector.ClientID %>").attr("disabled", false);
                    $("#<%= ddlDirector.ClientID %>").empty();
                    $("#<%= ddlDirector.ClientID %>").append("<option value=0>--Seleccione Director--</option>");
                    console.log(data.id);

                    if (data.id != 0) {
                        $("#<%= ddlDirector.ClientID %>").append("<option value=\"" + data.id + "\">" + data.FullName + "</option>");
                    } else {
                        
                    }
                   <%-- $.each(data, function (i, item) {
                       // console.log(item);
                        var valor = item.id;
                        if (valor != 0) {

                        } else {
                        $("#<%= ddlDirector.ClientID %>").append("<option value=\"" + item.id + "\">" + item.FullName + "</option>");
                        }

                        
                    });--%>
                }

            }


        $("#<%=chkDocente.ClientID%>").click(function () {

            if ($("#<%= ddlDocente.ClientID %> option").length > 0) {
                    if ($(this).prop("checked") == true) {
                        $("#<%= ddlDocente.ClientID %>").attr("disabled", false);

                    }
                    if ($(this).prop("checked") == false) {
                        $("#<%= ddlDocente.ClientID %>").attr("disabled", true);
                    }
            }
           

        });


        $("#<%=chkDirector.ClientID%>").click(function () {

            if ($("#<%= ddlDirector.ClientID %> option").length > 0) {
                 if ($(this).prop("checked") == true) {
                     $("#<%= ddlDirector.ClientID %>").attr("disabled", false);

                    }
                    if ($(this).prop("checked") == false) {
                        $("#<%= ddlDirector.ClientID %>").attr("disabled", true);
                    }
                }


        });






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
