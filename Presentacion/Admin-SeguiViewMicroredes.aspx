<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-SeguiViewMicroredes.aspx.cs" Inherits="Presentacion.Admin_SeguiViewMicroredes" %>
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
                                                               
                                                                <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server" TextMode="Date" required Enabled="False"></asp:TextBox>
                                                             
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="Asesor">Asesor</label>
                                                        
                                                        <asp:TextBox ID="txtAsesor" CssClass="form-control" runat="server"   Enabled="False"></asp:TextBox>
                                                       
                                                       

                                                    </div>

                                                

                                                <div class="form-group">
                                                        <label for="Sesion">Ínstitución Educativa</label>
                                                   
                                                       <asp:ListBox ID="ddlSchool" CssClass="form-control" runat="server"  SelectionMode="Multiple"  Height="143px" Enabled="False" ></asp:ListBox>
                                                    </div>



                                                <div class="form-group">
                                                        <label for="Microred">Docente</label>
                                                        
                                                        <asp:ListBox ID="ddlDocente" CssClass="form-control" runat="server" SelectionMode="Multiple"  Height="143px" Enabled="False" ></asp:ListBox>
                                                    </div>

                                                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                                    <div class="form-group">
                                                        <label for="Microred">Nombre de Microred</label>
                                                        
                                                        <asp:TextBox ID="txtMircrored" CssClass="form-control" runat="server"  required Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Lugar de Sesión</label>
                                                   
                                                        <asp:TextBox ID="txtSesion" CssClass="form-control" runat="server"  required Enabled="False" ></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Inicio">Hora Inicio</label>
                                                        
                                                        <asp:TextBox ID="txtInicio" CssClass="form-control" runat="server"   TextMode="Time" required Enabled="False"></asp:TextBox>
                                                        <label for="termino">Hora de termino</label>
                                                       
                                                        <asp:TextBox ID="txtTermino" CssClass="form-control" runat="server"  TextMode="Time" required Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Participantes">N° de Participantes</label>
                                                        
                                                        <asp:TextBox ID="txtParticipante" CssClass="form-control" runat="server" TextMode="Number" required Enabled="False"></asp:TextBox>
                                                    </div>


                                                    <!-- Temas a desarrollar-->

                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">Temas desarrollados</div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Educación Financiera</label>
                                                                
                                                                <asp:TextBox ID="txtEducacion" CssClass="form-control" runat="server" TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Enfoques Educativos</label>
                                                                <asp:TextBox ID="txtEnfoque" CssClass="form-control" runat="server" TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Programación Pedagógica</label>
                                                                <asp:TextBox ID="txtProgramacion" CssClass="form-control" runat="server"  TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Habilidades Pedagógicas</label>
                                                                <asp:TextBox ID="txtHabilidades" CssClass="form-control" runat="server"  TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>



                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">Metodología de la sesión</div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Trabajo grupal o en parejas</label>
                                                               
                                                                <asp:TextBox ID="txtTrabajo" CssClass="form-control" runat="server" TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Participativo</label>
                                                                <asp:TextBox ID="txtParticipativo" CssClass="form-control" runat="server"   TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Expositivo</label>
                                                                <asp:TextBox ID="txtExpositivo" CssClass="form-control" runat="server"   TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Dinámicas Lúdicas</label>
                                                                <asp:TextBox ID="txtDinamicas" CssClass="form-control" runat="server"   TextMode="MultiLine" Enabled="False" ></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>



                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">Materiales utilizados</div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos Informáticos</label>
                                                                 <asp:TextBox ID="txtRecursos" CssClass="form-control" runat="server" TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos Audiovisuales</label>
                                                                 <asp:TextBox ID="txtAudiovisuales" CssClass="form-control" runat="server"   TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Materiales Didácticos</label>
                                                                 <asp:TextBox ID="txtMateriales" CssClass="form-control" runat="server" TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                            </div>


                                                        </div>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Observaciones">Observaciones</label>
                                                      
                                                         <asp:TextBox ID="txtObservacion" CssClass="form-control" runat="server"  TextMode="MultiLine" Enabled="False"></asp:TextBox>
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

        
         

    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
