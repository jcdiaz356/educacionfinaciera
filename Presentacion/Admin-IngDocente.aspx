﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin-IngDocente.aspx.cs" Inherits="Presentacion.Admin_IngDocente" %>
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
                                                <h3>Nuevo Docente</h3>
                                                
                                                    <div class="form-group ">
                                                        <div class="row">
                                                            <div class="col-md-5">
                                                                <label for="codigo">Código de Docente</label>
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

                                                    <div class="form-group">
                                                        <label for="Docente">Grados que tiene a su cargo</label>
                                                       
                                                        
                                                    </div>
                                                       
                                                    
                                                    <%-- 1ero --%>
                                                    <div class="panel panel-default">
                                                        <div class="panel-heading">
                                                             <asp:CheckBox ID="chk1" runat="server" Text="1ro. Secundaria"  />
                                                            </div>
                                                        <div id="panel1" class="panel-body">
                                                            <div class="row">
                                                                <div class="col-md-2">
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1A" CssClass="controlChk1" Text="A"  runat="server" />
                                                                            <asp:TextBox ID="txt1A"  CssClass="controlTxt1A" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1B" CssClass="controlChk1" Text="B"  runat="server" />
                                                                            <asp:TextBox ID="txt1B"  CssClass="controlTxt1B" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                   
                                                                    
                                                                </div>
                                                                <div class="col-md-2">
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1C" CssClass="controlChk1" Text="C"  runat="server" />
                                                                            <asp:TextBox ID="txt1C"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1D" CssClass="controlChk1" Text="D"  runat="server" />
                                                                            <asp:TextBox ID="txt1D"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                   
                                                                </div>
                                                                <div class="col-md-2">
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                          <asp:CheckBox ID="chk1E" CssClass="controlChk1" Text="E"  runat="server" />
                                                                            <asp:TextBox ID="txt1E"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                          <asp:CheckBox ID="chk1F" CssClass="controlChk1" Text="F"  runat="server" />
                                                                            <asp:TextBox ID="txt1F"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                   
                                                                    
                                                                </div>
                                                                <div class="col-md-2">
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1G" CssClass="controlChk1" Text="G"  runat="server" />
                                                                            <asp:TextBox ID="txt1G"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                          <asp:CheckBox ID="chk1H" CssClass="controlChk1" Text="H"  runat="server" />
                                                                            <asp:TextBox ID="txt1H"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                   
                                                                    
                                                                </div>
                                                                <div class="col-md-2">
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1I" CssClass="controlChk1" Text="I"  runat="server" />
                                                                            <asp:TextBox ID="txt1I"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1J" CssClass="controlChk1" Text="J"  runat="server" />
                                                                            <asp:TextBox ID="txt1J"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                   
                                                                    
                                                                </div>
                                                                 <div class="col-md-2">
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1K" CssClass="controlChk1" Text="K"  runat="server" />
                                                                            <asp:TextBox ID="txt1K"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                    <div class="form-group">
                                                                        <label class="checkbox-inline">
                                                                            <asp:CheckBox ID="chk1L" CssClass="controlChk1" Text="L"  runat="server" />
                                                                            <asp:TextBox ID="txt1L"  CssClass="controlTxt1" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                        </label>
                                                                    </div>
                                                                    
                                                                    
                                                                </div>

                                                            </div>
                                                            

                                                        </div>
                                                    </div>


                                                    <%-- 2do --%>
                                                    <div class="panel panel-default">
                                                            <div class="panel-heading">
                                                                 <asp:CheckBox ID="chk2" runat="server" Text="2do. Secundaria"  />
                                                                </div>
                                                            <div id="panel2" class="panel-body">
                                                                <div class="row">
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2A" CssClass="controlChk2" Text="A"  runat="server" />
                                                                                <asp:TextBox ID="txt2A"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2B" CssClass="controlChk2" Text="B"  runat="server" />
                                                                                <asp:TextBox ID="txt2B"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2C" CssClass="controlChk2" Text="C"  runat="server" />
                                                                                <asp:TextBox ID="txt2C"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2D" CssClass="controlChk2" Text="D"  runat="server" />
                                                                                <asp:TextBox ID="txt2D"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk2E" CssClass="controlChk2" Text="E"  runat="server" />
                                                                                <asp:TextBox ID="txt2E"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk2F" CssClass="controlChk2" Text="F"  runat="server" />
                                                                                <asp:TextBox ID="txt2F"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2G" CssClass="controlChk2" Text="G"  runat="server" />
                                                                                <asp:TextBox ID="txt2G"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk2H" CssClass="controlChk2" Text="H"  runat="server" />
                                                                                <asp:TextBox ID="txt2H"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2I" CssClass="controlChk2" Text="I"  runat="server" />
                                                                                <asp:TextBox ID="txt2I"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2J" CssClass="controlChk2" Text="J"  runat="server" />
                                                                                <asp:TextBox ID="txt2J"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                     <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2K" CssClass="controlChk2" Text="K"  runat="server" />
                                                                                <asp:TextBox ID="txt2K"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk2L" CssClass="controlChk2" Text="L"  runat="server" />
                                                                                <asp:TextBox ID="txt2L"  CssClass="controlTxt2" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                    
                                                                    
                                                                    </div>

                                                                </div>
                                                            

                                                            </div>
                                                        </div>


                                                    <%-- 3ero --%>
                                                    <div class="panel panel-default">
                                                            <div class="panel-heading">
                                                                 <asp:CheckBox ID="chk3" runat="server" Text="3ro. Secundaria"  />
                                                                </div>
                                                            <div id="panel3" class="panel-body">
                                                                <div class="row">
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3A" CssClass="controlChk3" Text="A"  runat="server" />
                                                                                <asp:TextBox ID="txt3A"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3B" CssClass="controlChk3" Text="B"  runat="server" />
                                                                                <asp:TextBox ID="txt3B"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3C" CssClass="controlChk3" Text="C"  runat="server" />
                                                                                <asp:TextBox ID="txt3C"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3D" CssClass="controlChk3" Text="D"  runat="server" />
                                                                                <asp:TextBox ID="txt3D"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk3E" CssClass="controlChk3" Text="E"  runat="server" />
                                                                                <asp:TextBox ID="txt3E"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk3F" CssClass="controlChk3" Text="F"  runat="server" />
                                                                                <asp:TextBox ID="txt3F"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3G" CssClass="controlChk3" Text="G"  runat="server" />
                                                                                <asp:TextBox ID="txt3G"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk3H" CssClass="controlChk3" Text="H"  runat="server" />
                                                                                <asp:TextBox ID="txt3H"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3I" CssClass="controlChk3" Text="I"  runat="server" />
                                                                                <asp:TextBox ID="txt3I"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3J" CssClass="controlChk3" Text="J"  runat="server" />
                                                                                <asp:TextBox ID="txt3J"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                     <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3K" CssClass="controlChk3" Text="K"  runat="server" />
                                                                                <asp:TextBox ID="txt3K"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk3L" CssClass="controlChk3" Text="L"  runat="server" />
                                                                                <asp:TextBox ID="txt3L"  CssClass="controlTxt3" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                    
                                                                    
                                                                    </div>

                                                                </div>
                                                            

                                                            </div>
                                                        </div>

                                                    <%-- 4to --%>
                                                    <div class="panel panel-default">
                                                            <div class="panel-heading">
                                                                 <asp:CheckBox ID="chk4" runat="server" Text="4to. Secundaria"  />
                                                                </div>
                                                            <div id="panel4" class="panel-body">
                                                                <div class="row">
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4A" CssClass="controlChk4" Text="A"  runat="server" />
                                                                                <asp:TextBox ID="txt4A"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4B" CssClass="controlChk4" Text="B"  runat="server" />
                                                                                <asp:TextBox ID="txt4B"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4C" CssClass="controlChk4" Text="C"  runat="server" />
                                                                                <asp:TextBox ID="txt4C"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4D" CssClass="controlChk4" Text="D"  runat="server" />
                                                                                <asp:TextBox ID="txt4D"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk4E" CssClass="controlChk4" Text="E"  runat="server" />
                                                                                <asp:TextBox ID="txt4E"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk4F" CssClass="controlChk4" Text="F"  runat="server" />
                                                                                <asp:TextBox ID="txt4F"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4G" CssClass="controlChk4" Text="G"  runat="server" />
                                                                                <asp:TextBox ID="txt4G"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk4H" CssClass="controlChk4" Text="H"  runat="server" />
                                                                                <asp:TextBox ID="txt4H"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4I" CssClass="controlChk4" Text="I"  runat="server" />
                                                                                <asp:TextBox ID="txt4I"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4J" CssClass="controlChk4" Text="J"  runat="server" />
                                                                                <asp:TextBox ID="txt4J"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                     <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4K" CssClass="controlChk4" Text="K"  runat="server" />
                                                                                <asp:TextBox ID="txt4K"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk4L" CssClass="controlChk4" Text="L"  runat="server" />
                                                                                <asp:TextBox ID="txt4L"  CssClass="controlTxt4" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                    
                                                                    
                                                                    </div>

                                                                </div>
                                                            

                                                            </div>
                                                        </div>

                                                    <%-- 5to --%>
                                                    <div class="panel panel-default">
                                                            <div class="panel-heading">
                                                                 <asp:CheckBox ID="chk5" runat="server" Text="5to. Secundaria"  />
                                                                </div>
                                                            <div id="panel5" class="panel-body">
                                                                <div class="row">
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5A" CssClass="controlChk5" Text="A"  runat="server" />
                                                                                <asp:TextBox ID="txt5A"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5B" CssClass="controlChk5" Text="B"  runat="server" />
                                                                                <asp:TextBox ID="txt5B"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5C" CssClass="controlChk5" Text="C"  runat="server" />
                                                                                <asp:TextBox ID="txt5C"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5D" CssClass="controlChk5" Text="D"  runat="server" />
                                                                                <asp:TextBox ID="txt5D"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk5E" CssClass="controlChk5" Text="E"  runat="server" />
                                                                                <asp:TextBox ID="txt5E"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk5F" CssClass="controlChk5" Text="F"  runat="server" />
                                                                                <asp:TextBox ID="txt5F"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5G" CssClass="controlChk5" Text="G"  runat="server" />
                                                                                <asp:TextBox ID="txt5G"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                              <asp:CheckBox ID="chk5H" CssClass="controlChk5" Text="H"  runat="server" />
                                                                                <asp:TextBox ID="txt5H"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                    <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5I" CssClass="controlChk5" Text="I"  runat="server" />
                                                                                <asp:TextBox ID="txt5I"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5J" CssClass="controlChk5" Text="J"  runat="server" />
                                                                                <asp:TextBox ID="txt5J"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                   
                                                                    
                                                                    </div>
                                                                     <div class="col-md-2">
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5K" CssClass="controlChk5" Text="K"  runat="server" />
                                                                                <asp:TextBox ID="txt5K"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                        <div class="form-group">
                                                                            <label class="checkbox-inline">
                                                                                <asp:CheckBox ID="chk5L" CssClass="controlChk5" Text="L"  runat="server" />
                                                                                <asp:TextBox ID="txt5L"  CssClass="controlTxt5" runat="server" text="0" TextMode="Number" Width="44px" ></asp:TextBox>
                                                                            </label>
                                                                        </div>
                                                                    
                                                                    
                                                                    </div>

                                                                </div>
                                                            

                                                            </div>
                                                        </div>
                                                   
                                                    
                                                            
                                                       
                                                    


                                                   

                                                    <%--<div class="form-group">
                                                        <label for="Docente">Grados que tiene a su cargo</label>
                                                         <asp:ListBox ID="lblGradosaCargo" runat="server" CssClass="form-control input-sm" SelectionMode="Multiple"  Height="143px">
                                                           
                                                         </asp:ListBox>
                                                    </div>--%>

                                                    <div class="form-group">
                                                        <label for="Contrato">Tipo de Contrato</label>
                                                        
                                                        <asp:DropDownList ID="ddlContrato" runat="server"  CssClass="form-control input-sm">
                                                            <asp:ListItem>Contratado </asp:ListItem>
                                                            <asp:ListItem>Nombrado </asp:ListItem>
                                                        </asp:DropDownList>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Docente">Areas Curriculares que enseña</label>
                                                         <asp:ListBox ID="lblCursos" runat="server" CssClass="form-control input-sm" SelectionMode="Multiple"  Height="143px">
                                                             
                                                         </asp:ListBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <label for="Docente">Turnos en que enseña</label>
                                                         <asp:ListBox ID="lblTurnos" runat="server" CssClass="form-control input-sm" SelectionMode="Multiple"  Height="143px">
                                                             
                                                         </asp:ListBox>
                                                    </div>

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

        

        $("#panel1" ).find(":checkbox").attr("disabled", true);
        $("#panel1").find("input[type=number]").attr("disabled", true);

        $("#panel2").find(":checkbox").attr("disabled", true);
        $("#panel2").find("input[type=number]").attr("disabled", true);

        $("#panel3").find(":checkbox").attr("disabled", true);
        $("#panel3").find("input[type=number]").attr("disabled", true);


        $("#panel4").find(":checkbox").attr("disabled", true);
        $("#panel4").find("input[type=number]").attr("disabled", true);

        $("#panel5").find(":checkbox").attr("disabled", true);
        $("#panel5").find("input[type=number]").attr("disabled", true);

        $("#<%=chk1.ClientID%>").click(function () {
            if ($(this).prop("checked") == true) {
                // $(".inputclassname").show();

                console.log("Si");
                $("#panel1").find(":checkbox").attr("disabled", false);
                $("#panel1").find(":checkbox").prop("checked", false);
                $("#panel1").find("input[type=number]").attr("disabled", false);
                $("#panel1").find("input[type=number]").prop("value", "0");

            }
            if ($(this).prop("checked") == false) {
                // $(".inputclassname").hide();
                console.log("No");
                $("#panel1").find(":checkbox").attr("disabled", true);
                $("#panel1").find(":checkbox").prop("checked", false);
                $("#panel1").find("input[type=number]").attr("disabled", true);
                $("#panel1").find("input[type=number]").prop("value", "0");

            }
        });

        $("#<%=chk2.ClientID%>").click(function () {
            if ($(this).prop("checked") == true) {
                // $(".inputclassname").show();

                console.log("Si");
                $("#panel2").find(":checkbox").attr("disabled", false);
                $("#panel2").find(":checkbox").prop("checked", false);
                $("#panel2").find("input[type=number]").attr("disabled", false);
                $("#panel2").find("input[type=number]").prop("value", "0");

            }
            if ($(this).prop("checked") == false) {
                // $(".inputclassname").hide();
                console.log("No");
                $("#panel2").find(":checkbox").attr("disabled", true);
                $("#panel2").find(":checkbox").prop("checked", false);
                $("#panel2").find("input[type=number]").attr("disabled", true);
                $("#panel2").find("input[type=number]").prop("value", "0");

            }
        });

        $("#<%=chk3.ClientID%>").click(function () {
            if ($(this).prop("checked") == true) {
                // $(".inputclassname").show();

                console.log("Si");
                $("#panel3").find(":checkbox").attr("disabled", false);
                $("#panel3").find(":checkbox").prop("checked", false);
                $("#panel3").find("input[type=number]").attr("disabled", false);
                $("#panel3").find("input[type=number]").prop("value", "0");

            }
            if ($(this).prop("checked") == false) {
                // $(".inputclassname").hide();
                console.log("No");
                $("#panel3").find(":checkbox").attr("disabled", true);
                $("#panel3").find(":checkbox").prop("checked", false);
                $("#panel3").find("input[type=number]").attr("disabled", true);
                $("#panel3").find("input[type=number]").prop("value", "0");

            }
        });

        $("#<%=chk4.ClientID%>").click(function () {
            if ($(this).prop("checked") == true) {
                // $(".inputclassname").show();

                console.log("Si");
                $("#panel4").find(":checkbox").attr("disabled", false);
                $("#panel4").find(":checkbox").prop("checked", false);
                $("#panel4").find("input[type=number]").attr("disabled", false);
                $("#panel4").find("input[type=number]").prop("value", "0");

            }
            if ($(this).prop("checked") == false) {
                // $(".inputclassname").hide();
                console.log("No");
                $("#panel4").find(":checkbox").attr("disabled", true);
                $("#panel4").find(":checkbox").prop("checked", false);
                $("#panel4").find("input[type=number]").attr("disabled", true);
                $("#panel4").find("input[type=number]").prop("value", "0");

            }
        });

        $("#<%=chk5.ClientID%>").click(function () {
            if ($(this).prop("checked") == true) {
                // $(".inputclassname").show();

                console.log("Si");
                $("#panel5").find(":checkbox").attr("disabled", false);
                $("#panel5").find(":checkbox").prop("checked", false);
                $("#panel5").find("input[type=number]").attr("disabled", false);
                $("#panel5").find("input[type=number]").prop("value", "0");

            }
            if ($(this).prop("checked") == false) {
                // $(".inputclassname").hide();
                console.log("No");
                $("#panel5").find(":checkbox").attr("disabled", true);
                $("#panel5").find(":checkbox").prop("checked", false);
                $("#panel5").find("input[type=number]").attr("disabled", true);
                $("#panel5").find("input[type=number]").prop("value", "0");

            }
        });
    </script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>