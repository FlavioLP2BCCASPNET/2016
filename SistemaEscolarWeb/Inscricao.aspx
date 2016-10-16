<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Inscricao.aspx.cs" Inherits="Inscricao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Inscrição</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/Custom-Cs.css" rel="stylesheet" />
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="navbar navbar-default navbar-fixed-top" role="navigation">
                <div class="container">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="Page2.aspx"><span>
                            <img alt="Logo" src="Imagens/Logo1.png" height="30" /></span>Learning Together</a>
                    </div>
                    <div class="navbar-collapse collapse">
                        <ul class="nav navbar-nav navbar-right">
                            <li><a href="Page2.aspx">Inicio</a></li>
                            <li><a href="http://www2.fema.edu.br/">Sobre</a></li>
                            <li><a href="https://github.com/flavio-halves">Contato</a></li>
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
                            <li class="active"><a href="Inscricao.aspx">Casdastre-se</a></li>
                             <li><a href="Acesse.aspx">Entrar</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

        <!-- Sign Up -->
        <div class="center-page">

            <label class="col-xs-11">Usuario</label>
            <div class="col-xs-11">

                <asp:TextBox ID="tbUsuario" runat="server" Class="form-control" placeholder="Usuario"></asp:TextBox>
               
            </div>

            <label class="col-xs-11">Senha</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbSenha" runat="server" Class="form-control" placeholder="Senha" TextMode="Password" ></asp:TextBox>
            </div>

            <label class="col-xs-11">Confirme a Senha</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbCSenha" runat="server" Class="form-control" placeholder="Confime a Senha" TextMode="Password" ></asp:TextBox>
            </div>

            <label class="col-xs-11">Nome</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbNome" runat="server" Class="form-control" placeholder="Nome"></asp:TextBox>
            </div>

            <label class="col-xs-11">Email</label>
            <div class="col-xs-11">
                <asp:TextBox ID="tbEmail" runat="server" Class="form-control" placeholder="Email" TextMode="Email"></asp:TextBox>
            </div>

            <div class="col-xs-11 space-vert">
                <asp:Button ID="btCadastro" runat="server" Class="btn btn-success" Text="Cadastre" OnClick="btCadastro_Click" />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </div>
        </div>
        
        <!-- Sign Up -->

        <!--- Footer  -->

        <hr />

        <footer class="footer-pos">
            <div class="container">
                <p class="pull-right"><a href="#"><span class="text-primary">Retornar ao Topo ^&nbsp; </span></a></p>
                <p>&copy; 2016 2°BCC - FEMA  - FlavioHAlves &middot; <a href="Page2.aspx">Inicío</a> &middot; <a href="http://www2.fema.edu.br/">Sobre</a> &middot; <a href="https://github.com/flavio-halves">Contato</a> &middot;></p>
            </div>
        </footer>

        <!--- Footer -->


    </form>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
