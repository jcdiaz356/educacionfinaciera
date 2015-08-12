<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="escolares-informan.aspx.cs" Inherits="Presentacion.escolares_informan" %>
<%@Register TagPreFix="ucSocialFacebook" TagName="MenuSocialFacebook" src="~/SocialFacebook.ascx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

     <!------------CONTENEDOR-->
    <div class="container" >
        <div class="row">
            <!-- COLUMNA IZQUIERDA-->
            <div class="col-md-3 pt">
                <!----------MENU LEFT------------->
                <div class="menu-left">
                        <nav class="navbar navbar-default">
                            <div class="container-fluid">
                                <!-- Brand and toggle get grouped for better mobile display -->
                                <div class="navbar-header">
                                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-2">
                                        <span class="sr-only">Toggle navigation</span>
                                        <span class="icon-bar"></span>
                                        <span class="icon-bar"></span>
                                        <span class="icon-bar"></span>
                                    </button>
                                </div>

                                <!-- Collect the nav links, forms, and other content for toggling -->
                                <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-2">
                                    <ul class="nav navbar-nav">
                                        <li class="active"><a href="#">REPORTEROS ESCOLARES <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                                        <li><a href="blog.aspx">LOS BLOGS<div class="triangulo_top_right" ></div></a></li>
                                    </ul>
                                </div><!-- /.navbar-collapse -->
                            </div><!-- /.container-fluid -->
                        </nav>

                </div>
            </div>
            <!-- COLUMNA DERECHA-->
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        HISTORIA
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <h1>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad consectetur cumque, eos</h1>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad consectetur cumque, eos esse est exercitationem facilis maxime, numquam odio quam, quasi quis repudiandae sit tempore voluptate. Dolor facilis maiores sit!!</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi doloribus ipsa iusto molestias quia quos recusandae saepe voluptatibus! Ab assumenda autem dolor officiis saepe, sapiente veritatis voluptatum! Blanditiis, in, pariatur?</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aperiam asperiores cum eius, error esse eveniet impedit ipsum itaque nemo non optio rem repellendus sapiente sed vitae voluptates voluptatum. Dolores, quod.</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad consectetur cumque, eos esse est exercitationem facilis maxime, numquam odio quam, quasi quis repudiandae sit tempore voluptate. Dolor facilis maiores sit!!</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi doloribus ipsa iusto molestias quia quos recusandae saepe voluptatibus! Ab assumenda autem dolor officiis saepe, sapiente veritatis voluptatum! Blanditiis, in, pariatur?</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aperiam asperiores cum eius, error esse eveniet impedit ipsum itaque nemo non optio rem repellendus sapiente sed vitae voluptates voluptatum. Dolores, quod.</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad consectetur cumque, eos esse est exercitationem facilis maxime, numquam odio quam, quasi quis repudiandae sit tempore voluptate. Dolor facilis maiores sit!!</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi doloribus ipsa iusto molestias quia quos recusandae saepe voluptatibus! Ab assumenda autem dolor officiis saepe, sapiente veritatis voluptatum! Blanditiis, in, pariatur?</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aperiam asperiores cum eius, error esse eveniet impedit ipsum itaque nemo non optio rem repellendus sapiente sed vitae voluptates voluptatum. Dolores, quod.</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad consectetur cumque, eos esse est exercitationem facilis maxime, numquam odio quam, quasi quis repudiandae sit tempore voluptate. Dolor facilis maiores sit!!</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi doloribus ipsa iusto molestias quia quos recusandae saepe voluptatibus! Ab assumenda autem dolor officiis saepe, sapiente veritatis voluptatum! Blanditiis, in, pariatur?</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aperiam asperiores cum eius, error esse eveniet impedit ipsum itaque nemo non optio rem repellendus sapiente sed vitae voluptates voluptatum. Dolores, quod.</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad consectetur cumque, eos esse est exercitationem facilis maxime, numquam odio quam, quasi quis repudiandae sit tempore voluptate. Dolor facilis maiores sit!!</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi doloribus ipsa iusto molestias quia quos recusandae saepe voluptatibus! Ab assumenda autem dolor officiis saepe, sapiente veritatis voluptatum! Blanditiis, in, pariatur?</p>
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aperiam asperiores cum eius, error esse eveniet impedit ipsum itaque nemo non optio rem repellendus sapiente sed vitae voluptates voluptatum. Dolores, quod.</p>
                                        <p>
                                            <a href="#">link1</a><br/>
                                            
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>


            <div class="col-md-3">
                <!-- REDES SOCIALES-->
                <div class="row">
                    <div class="col-md-12">
                        <!------------CUADRO 1 FACEBOOK------>
                        <ucSocialFacebook:MenuSocialFacebook id="MenuSocial" runat="server" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
