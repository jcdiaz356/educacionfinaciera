<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-SeguiViewClase.aspx.cs" Inherits="Presentacion.Admin_SeguiViewClase" %>
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
                                                               
                                                                <asp:TextBox ID="txtFecha" CssClass="form-control" runat="server" TextMode="Date" Enabled="False"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class="form-group">
                                                        <label for="Asesor">Asesor</label>
                                                        
                                                        <%--<asp:TextBox ID="txtAsesor" CssClass="form-control" runat="server" placeholder="Ingrese Asesor"></asp:TextBox>--%>
                                                       
                                                        <asp:TextBox ID="txtAsesor" CssClass="form-control" runat="server" Enabled="False"  ></asp:TextBox>
                                                    </div>

                                                

                                                <div class="form-group">
                                                        <label for="Sesion">Ínstitución Educativa</label>
                                                   
                                                        
                                                        <asp:TextBox ID="txtSchool" CssClass="form-control" runat="server" Enabled="False"  ></asp:TextBox>
                                                    </div>



                                                <div class="form-group">
                                                        <label for="Microred">Docente</label>
                                                        
                                                         
                                                        <asp:TextBox ID="txtDocente" CssClass="form-control" runat="server" Enabled="False" ></asp:TextBox>
                                                    </div>


                                                   <div class="form-group">
                                                        <label for="Sesion">Grado y sección</label>
                                                        <asp:TextBox ID="txtGradoSeccion" CssClass="form-control" runat="server" Enabled="False" ></asp:TextBox>
                                                        
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Nombre de sesión por Grado</label>
                                                        <asp:TextBox ID="txtNombSesion" CssClass="form-control" runat="server" Enabled="False" ></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Participantes">N° de sesión</label>
                                                        <asp:TextBox ID="txtNumSesion" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
                                                        
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Nro. de Estudiantes Asistentes a la clase</label>
                                                   
                                                        <asp:TextBox ID="txtEstidianteAsistentes" CssClass="form-control" runat="server"  TextMode="Number" Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">La sesión esta de acuerdo a lo planificado</label>
                                                                <%--<asp:RadioButtonList ID="rblPlanificado" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1" Selected="True" Enabled="False"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0" Enabled="False"> No</asp:ListItem>   
                                                                </asp:RadioButtonList>--%>
                                                        <asp:TextBox ID="txtSesionPlanificado" CssClass="form-control" runat="server"  TextMode="Number" Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Si es "NO" cual es el motivo</label>
                                                   
                                                        <asp:TextBox ID="txtMotivo" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Desarrollo innovaciones</label>
                                                                <%--<asp:RadioButtonList ID="rblInnovacion" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1" Selected="True"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0"> No</asp:ListItem>   
                                                        </asp:RadioButtonList>--%>
                                                        <asp:TextBox ID="txtInnovacion" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <!-- Temas a desarrollar-->

                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">
                                                            <h4>¿Que innovaciones desarrolla?</h4>
                                                            </div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos informáticos(sistemas, programas, apps, blog, webs, etc.) </label>
                                                                
                                                                <asp:TextBox ID="txtRecursosInformáticos" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Recursos audiovisuales(videos, música, proyección de diapositivas, etc.)</label>
                                                                <asp:TextBox ID="txtRecursosAudiovisuales" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Materiales Didácticos empleados para la sesión. (tarjetas de bancos, cheques, Boucher, Etc.)</label>
                                                                <asp:TextBox ID="txtMaterialesDidactico" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Dinámicas utilizadas en la sesión</label>
                                                                <asp:TextBox ID="txtDinamicasUsadas" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">Otros (celulares, vistas, etc.)</label>
                                                                <asp:TextBox ID="TxtOtros" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                            </div>
                                                        </div>
                                                    </div>


                                                   <div class="form-group">
                                                        <label for="Sesion">¿El asesor intervino en la sesión?</label>
                                                               <%-- <asp:RadioButtonList ID="rblIntervino" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0" Selected="True"> No</asp:ListItem>   
                                                        </asp:RadioButtonList>--%>
                                                       <asp:TextBox ID="txtIntervino" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">¿Cómo intervino?</label>
                                                                <%--<asp:RadioButtonList ID="rblComoIntervino" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="Apoyo"> Apoyo</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="Hizo la sesión"> Hizo la sesión</asp:ListItem>   
                                                        </asp:RadioButtonList>--%>
                                                        <asp:TextBox ID="txtComoIntervinoSesion" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Sesion">Intervención de otros colaboradores</label>
                                                                <%--<asp:RadioButtonList ID="rblOtrosColaboradores" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1"> Si</asp:ListItem>
                                                                    <asp:ListItem CssClass="form-control" Value="0" Selected="True"> No</asp:ListItem>   
                                                        </asp:RadioButtonList>--%>
                                                        <asp:TextBox ID="txtOtrosColaboradores" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Observaciones">¿Quien?</label>
                                                      
                                                         <asp:TextBox ID="txtQuien" CssClass="form-control" runat="server" Enabled="False" ></asp:TextBox>
                                                    </div>

                                                     <div class="form-group">
                                                        <label for="Observaciones">¿Cómo intervino?</label>
                                                      
                                                         <asp:TextBox ID="txtComoIntervino" CssClass="form-control" runat="server" Enabled="False" ></asp:TextBox>
                                                    </div>
                                                    
                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">
                                                            <h4>Participa en el juego</h4>
                                                            </div>
                                                        <div class="panel-body">
                                                            <div class="form-group">
                                                                 <%--<asp:RadioButtonList ID="rblParticipaJuego" runat="server"  >
                                                                    <asp:ListItem CssClass="form-control" Value="1" Selected="True"> Si</asp:ListItem>
                                                                     
                                                                    <asp:ListItem CssClass="form-control" Value="0"> No</asp:ListItem>  
                                                                      
                                                                 </asp:RadioButtonList>--%>
                                                                <asp:TextBox ID="txtParticipaJuego" CssClass="form-control" runat="server" Enabled="False" ></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">¿En que etapa están?</label>
                                                                <asp:TextBox ID="txtEtapa" CssClass="form-control" runat="server" Enabled="False"></asp:TextBox>
                                                            </div>

                                                            <div class="form-group">
                                                                <label for="Financiera">¿Cual es la razón?</label>
                                                                <asp:TextBox ID="txtRazon" CssClass="form-control" runat="server"  Enabled="False"></asp:TextBox>
                                                            </div>

                                                            
                                                        </div>
                                                    </div>

                                                    
                                                    <div class="form-group">
                                                         <label for="Observaciones">Principal Incidencia</label>
                                                         <asp:TextBox ID="txtIncidencia" CssClass="form-control" runat="server"  TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                                    </div>

                                                    

                                                    <asp:Button ID="cmdVolver" CssClass="btn btn-default" runat="server" Text="Volver" OnClick="cmdVolver_Click"  />
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
