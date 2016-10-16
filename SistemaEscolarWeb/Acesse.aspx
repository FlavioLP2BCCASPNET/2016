<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Acesse.aspx.cs" Inherits="Acesse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>AcessoConta</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
 
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
   <div>
       <div class="navbar navbar-default navbar-fixed-top" role="navigation" style="left: 0; right: 0; top: 0; height: 52px">
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
                       <li class="active"><a href="Acesse.aspx">Entrar</a></li>
                   
                   </ul>
               </div>
           </div>
       </div>
         
        </div>
        <!--- Usa memorio do Cache, salva o nome do usuario cadastrado -->
         <!--- Acesse inicio -->



        <div class="container">
            <div class=" form-horizontal">
                <h2>Acesse</h2>
                <hr />
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" Text="Nome do Usuario"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTextBox1" CssClass="text-danger" runat="server" ErrorMessage="É necessário preencher o nome do usuário" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
                        
                         </div>
                </div>

                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label" Text="Senha"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="Senha" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorSenha" CssClass="text-danger" runat="server" ErrorMessage="É necessário preencher a senha " ControlToValidate="Senha"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-2"></div>
                    <div class="col-md-6">
                        
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                        <asp:Label ID="Label3" runat="server" CssClass="control-label" Text="Lembre-me ?"></asp:Label>
                        

                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-2"></div>
                    <div class="col-md-6">
                        
                        <asp:Button ID="Button1" runat="server" Text="Acesse" CssClass="btn-default" style="width: 68px" OnClick="Button1_Click"/>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Inscricao.aspx">Inscrever-se</asp:LinkButton>
                    </div>
                </div>
               <div class="form-group"></div>
                <div class="col-md-2"></div>
                    <div class="col-md-6">
                        <asp:Label ID="lblErro" runat="server" CssClass ="text-danger"></asp:Label>
            </div>
        </div>


        <!--- Acesse  fim -->


    </form>
 <!--- Footer  -->

        <hr />

        <footer>
            <div class="container">
                <p class="pull-right"><a href="#"><span class="text-primary">Retornar ao Topo ^&nbsp; </span></a></p>
                <p>&copy; 2016 2°BCC - FEMA  - FlavioHAlves &middot; <a href="Page2.aspx">Inicío</a> &middot; <a href="http://www2.fema.edu.br/">Sobre</a> &middot; <a href="https://github.com/flavio-halves">Contato</a> &middot; <a href="#">Turmas</a></p>
            </div>
        </footer>

        <!--- Footer -->


         
   
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
        <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>

