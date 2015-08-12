<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-IngSubDirector.aspx.cs" Inherits="Presentacion.Admin_IngSubDirector" %>
<%@ Register TagPrefix="AdminMenuLeft" tagname="AdminMenuLeft" src="UscControl/AdminMenuLeft.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <!------------CONTENEDOR-->
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
                           <%-- <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        QUE HACEMOS
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>--%>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <h3>Nuevo Sub Director</h3>
                                                
                                                    <div class="form-group ">
                                                        <div class="row">
                                                            <div class="col-md-5">
                                                                <label for="codigo">Código</label>
                                                                <asp:TextBox ID="txtCodigo" CssClass="form-control col-md-5" placeholder="Ingrese Código de Docente" runat="server" required></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    
                                                    <div class="form-group">
                                                        <label for="nombreapellido">Nombres y Apellidos</label>
                                                        
                                                        <asp:TextBox ID="txtNombreApellido" CssClass="form-control" runat="server"  placeholder="Ingrese Nombres y Apellidos" required></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Escuela"> Escuela a la que pertenece</label>
                                                         
                                                        <asp:DropDownList ID="ddlEscuela" runat="server"  CssClass="form-control input-sm">
                                                            
                                                        </asp:DropDownList>
                                                    </div>

                                                    
                                                       
                                                    
                                                  
                                                   
                                                    
                                                            
                                                       
                                                    


                                                   

                                                    <%--<div class="form-group">
                                                        <label for="Docente">Grados que tiene a su cargo</label>
                                                         <asp:ListBox ID="lblGradosaCargo" runat="server" CssClass="form-control input-sm" SelectionMode="Multiple"  Height="143px">
                                                           
                                                         </asp:ListBox>
                                                    </div>--%>

                                                    

                                                  
                                                    

                                                    <div class="form-group">
                                                        <label for="Telefono">Teléfono</label>
                                                        
                                                        <asp:TextBox ID="txtTelefono" CssClass="form-control" runat="server"  placeholder="Ingrese Telefono" required></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Correoelectrónico">Correo electrónico</label>
                                                        
                                                        <asp:TextBox ID="txtCorreo" CssClass="form-control" runat="server"  placeholder="Ingrese Correo electrónico" required></asp:TextBox>
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



    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>