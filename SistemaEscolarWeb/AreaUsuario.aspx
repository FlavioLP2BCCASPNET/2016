﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AreaUsuario.aspx.cs" Inherits="AreaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Seja Bem Vindo</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <link href="css/Custom-Cs.css" rel="stylesheet" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;<div class="navbar navbar-default navbar-fixed-top" role="navigation" style="left: 0; right: 0; top: 0; height: 52px">
           <div class="container">
               <div class="navbar-header">
                   <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                       <span class="sr-only">Toggle navigation</span>
                       <span class="icon-bar"></span>
                       <span class="icon-bar"></span>
                       <span class="icon-bar"></span>
                   </button>
                   <a class="navbar-brand" href="Page2.aspx"><span>
                       <img alt="Logo" src="Imagens/Logo1.png" height="30" /></span>Learning Toghter</a>
                   <!-- <a class="navbar-brand" href="Page2.aspx" > <span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <img alt="Logo" src="Imagens/Logo1.png" height="70" /></span></a><a class="auto-style1" href="Page2.aspx" ><span class="auto-style3">Learning Toghter</span></a>  -->
               </div>
             
               <div class="navbar-collapse collapse">
                   <ul class="nav navbar-nav navbar-right">
                       <li><a href="Page2.aspx">Inicío</a></li>
                       <li><a href="http://www2.fema.edu.br/">Sobre</a></li>
                       <li><a href="https://github.com/flavio-halves  ">Contato</a></li>
                       <li class="dropdown">
                           <a href="#" class="dropdown-toggle" data-toggle="dropdown">Cursos<b class="caret"></b></a>
                           <ul class="dropdown-menu">
                               <li class="dropdown-header">Infantil</li>
                               <li role="separator" class="divider"></li>
                               <li><a href="#">Iniciante</a></li>
                               <li><a href="#">Médio</a></li>
                               <li><a href="#">Avançado</a></li>
                               <li role="separator" class="divider"></li>
                               <li class="dropdown-header">Adolescente/Adulto</li>
                               <li role="separator" class="divider"></li>
                               <li><a href="#">Iniciante</a></li>
                               <li><a href="#">Médio</a></li>
                               <li><a href="#">Avançado</a></li>
                           </ul>
                       </li>
                       <li>
                           <asp:Button ID="btnSair" runat="server"  CssClass="btn btn-default navbar-btn" Text="Sair" OnClick="btnSair_Click" />
                       </li>
                      
                   </ul>
               </div>
           </div>
       </div>
         <asp:Label ID="lblSucesso" runat="server" CssClass ="text-success"></asp:Label>
    </form>
<!--- Footer  -->

        <hr />

        <footer>
            <div class="container">
                <p class="pull-right"><a href="#"><span class="text-primary">Retornar ao Topo ^&nbsp; </span></a></p>
                <p>&copy; 2016 2°BCC - FEMA  - FlavioHAlves &middot; <a href="Page2.aspx">Inicío</a> &middot; <a href="http://www2.fema.edu.br/">Sobre</a> &middot; <a href="https://github.com/flavio-halves  ">Contato</a> &middot;</p>
            </div>
        </footer>

        <!--- Footer -->


   
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
        <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>

