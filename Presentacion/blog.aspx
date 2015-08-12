﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="Presentacion.blog" %>
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
                                    <li><a href="#">REPORTEROS ESCOLARES <div class="triangulo_top_right" ></div><span class="sr-only">(current)</span></a></li>
                                    <li class="active"><a href="blog.aspx">LOS BLOGS<div class="triangulo_top_right" ></div></a></li>

                                </ul>
                            </div><!-- /.navbar-collapse -->
                        </div><!-- /.container-fluid -->
                    </nav>

                </div>
            </div>
            <!-- COLUMNA DERECHA-->
            <div class="col-md-9">
                <div class="row">
                    <div class="col-md-12 pt pb">
                        <!--------------------------Contenido---------------------------->
                        <div class="cuadro ">
                            <div class="row">
                                <div class="col-md-5">
                                    <div class="title">
                                        DETALLE BLOG
                                        <div class="triangulo_top_right" ></div>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <div class="cuadro-content">
                                        <div class="detalle-nota">
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <a href="blog.html" class="btn btn-default btn-xs pull-right" role="button">Volver</a>
                                                </div>
                                            </div>

                                            <h1>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ad consectetur cumque,</h1>
                                            <img class="img-responsive" src="img/imagen2.jpg" alt=""/>
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


                                            <!-- --------COMENTARIOS------------->

                                            <div class="row">

                                                <div class="col-md-12">
                                                    <div class="comentario">
                                                        <h1>Cometarios</h1>
                                                        <blockquote>
                                                            <h4>jcdiaz356@hotmail.com</h4>
                                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                                                            Someone famous in <cite title="Source Title">Source Title</cite>
                                                        </blockquote>
                                                        <blockquote>
                                                            <h4>jcdiaz356@hotmail.com</h4>
                                                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer posuere erat a ante.</p>
                                                            Someone famous in <cite title="Source Title">Source Title</cite>
                                                        </blockquote>
                                                    </div>
                                                </div>
                                            </div>


                                            <!-- ---------FORMULARIO COMENTARIO---------------->

                                            <div class="row">

                                                <div class="col-md-12">

                                                    <h1>Ingrese un comentario</h1>

                                                    <form class="form-horizontal">
                                                        <div class="form-group">
                                                            <label for="inputEmail3" class="col-sm-2 control-label">Email</label>
                                                            <div class="col-sm-10">
                                                                <input type="email" class="form-control" id="inputEmail3" placeholder="Email">
                                                            </div>
                                                        </div>


                                                        <div class="form-group">
                                                            <label for="inputComentario3" class="col-sm-2 control-label">Password</label>
                                                            <div class="col-sm-10">
                                                                <textarea class="form-control" rows="6" id="inputComentario3" placeholder="Comentario"></textarea>
                                                            </div>
                                                        </div>



                                                        <div class="form-group">
                                                            <div class="col-sm-offset-2 col-sm-10">
                                                                <button type="submit" class="btn btn-default">Enviar comentario</button>
                                                            </div>
                                                        </div>
                                                    </form>
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
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
