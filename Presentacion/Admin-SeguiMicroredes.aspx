<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-SeguiMicroredes.aspx.cs" Inherits="Presentacion.Admin_SeguiMicroredes" %>
<%@ Register TagPrefix="AdminMenuLeftSegui" tagname="AdminMenuLeftSegui" src="UscControl/AdminMenuLeftSegui.ascx" %>
<%@ Register TagPrefix="UscPaginador" tagname="UscPaginador" src="UscControl/Paginador.ascx" %>
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
                                                <h3>Fichas de Acompañamiento a las Microredes</h3>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-2">
                                                <a href="Admin-SeguiNuevoMicroredes.aspx?id=1" class="btn btn-default">
                                                    <span class="glyphicon glyphicon-plus" aria-hidden="true"></span> NUEVO
                                                </a>
                                            </div>
                                            <div class="col-md-4">
                                                <asp:TextBox ID="txtCodDocente" runat="server" CssClass="form-control" placeholder="Ingrese código Asesor"></asp:TextBox>
                                            </div>
                                            <div class="col-md-2">
                                                <asp:Button ID="btnSearch" runat="server" Text="Buscar"  class="btn btn-default" OnClick="btnSearch_Click" />
                                            </div>

                                            <div class="col-md-4">
                                               
                                                <asp:LinkButton  ID="btnReport" runat="server" Text=""  class="btn btn-default " OnClick="btnReport_Click"  >
                                                   <span class="glyphicon glyphicon-save glyphicon-align-left" aria-hidden="true"></span> Reporte Excel
                                                </asp:LinkButton>

                                               
                                               
                                            </div>
                                        </div>
                                        <div class="row">
                                        <div class="col-md-12">
                                                
                                               
                                                
                                                <!-- Inicia ventana Modal -->

                                                <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                                  <div class="modal-dialog">
                                                    <div class="modal-content">
                                                      <div class="modal-header">
                                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                                                        <h4 class="modal-title" id="myModalTitle">Modal title</h4>
                                                      </div>
                                                      <div class="modal-body" id="myModalBody">
                                                        ...
                                                      </div>
                                                      <div class="modal-footer">
                                                        <button type="button" class="btn btn-default" data-dismiss="modal">Cancelar</button>
                                                        <button type="button" id="btAceptar" class="btn btn-primary" >Aceptar</button>
                                                      </div>
                                                    </div>
                                                  </div>
                                                </div>
                                                <!-- fin ventana Modal -->


                                                <!-- Alerta -->
                                                <div class="pt">
                                                    <div id="alerta" class="alert alert-danger" role="alert" style="display:none"></div>
                                                </div>
                                                
                                                <!-- fin Alerta -->
                                                <table class="table">
                                                    <caption><%--Listado de Asesores.--%></caption>
                                                    <thead>
                                                    <tr>
                                                        <th>Nº</th>
                                                        <th>Asesor</th>
                                                        <th>Nombre</th>
                                                        <th>Fecha Creación</th>
                                                        <th>Operaciones</th>
                                                    </tr>
                                                    </thead>
                                                    <tbody>
                                                        <asp:Label ID="FilasListaMicroredes" runat="server" Text=""></asp:Label>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>

                                        <!-- --------------------PAGINADOR --------------------->
                                      


                                        <UscPaginador:UscPaginador id="UscPaginador" runat="server"></UscPaginador:UscPaginador>

                                        <!-- -------------------- END PAGINADOR --------------------->
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
        //$('#myModal').on('shown.bs.modal', function () {
        //    $('#myInput').focus()
        //})

        function showMyModalSetTitle(myTitle, myBodyHtml, id) {
            $('#btAceptar').attr('user_id', id);
            $('#myModalTitle').html(myTitle);
            $('#myModalBody').html(myBodyHtml);
            $('#myModal').modal('show');

        }

        $('#btAceptar').on("click", function () {
            //console.log($(this).text());
            var id = $('#btAceptar').attr("user_id")
            var getPedido = "";
            getPedido = "&tipo=deleteMicrored&idmicrored=" + id;
            $.ajax({
                url: "Admin-OperationsJSON.aspx",
                dataType: "json",
                type: "POST",
                data: getPedido,
                success: function (data, statusCode) {
                    beaches = data
                }
            });


            //Brito pones un ajax para eliminar para quequede bien chevere

            $('#myModal').modal('toggle');
            $("#" + id).remove();


            //Mostrando la Alerta
            $("#alerta").text("Se eliminó correctamente el registro");
            $("#alerta").slideDown(function () {
                setTimeout("$('#alerta').slideUp();", 4000);
            });

        });
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
