<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page2.aspx.cs" Inherits="Page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Inicio</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
 
    <link href="css/Custom-Cs.css" rel="stylesheet" />

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            bottom: -50px;
            left: 51%;
            z-index: 15;
            width: 60%;
            text-align: center;
            list-style-type: none;
            margin-left: -30%;
            padding-left: 0;
        }
    </style>
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
                            <img alt="Logo" src="Imagens/Logo1.png" height="30" /></span>Learning Togheter</a>
                    <!-- <a class="navbar-brand" href="Page2.aspx" > <span> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <img alt="Logo" src="Imagens/Logo1.png" height="70" /></span></a><a class="auto-style1" href="Page2.aspx" ><span class="auto-style3">Learning Toghter</span></a>  -->
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li class="active"><a href="Page2.aspx">Inicío</a></li>
                        <li><a href="http://www2.fema.edu.br/">Sobre</a></li>
                        <li><a href="https://github.com/flavio-halves">Contato</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">Cursos<b class="caret"></b></a>
                            <ul class="dropdown-menu">
                                <li class="dropdown-header"> Infantil</li>
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
                        <li><a href="Inscricao.aspx">Cadastre-se</a></li>
                        <li><a href="Acesse.aspx">Junte-se a nós</a></li>
                    </ul>
                </div>
            </div>
         </div>

            <!--- Carousel -->

        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="auto-style1">
    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
    <li data-target="#carousel-example-generic" data-slide-to="1"class=></li>
    <li data-target="#carousel-example-generic" data-slide-to="2"class=></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
      <img src="Imagens/3.jpg" alt="...">
      <div class="carousel-caption">
       <h3><a class="btn btn-lg btn-primary" href="Inscricao.aspx" role="button">Cadastre-se Já</a></h3>
          <h3>Aulas</h3>
    <p>Particulares</p>
          <p>&nbsp;</p>
      </div>
    </div>
    <div class="item">
      <img src="Imagens/1.jpg" alt="...">
      <div class="carousel-caption">
        <h3></h3>
    <p></p>
      </div>
    </div>
    <div class="item">
      <img src="Imagens/4.jpg" alt="...">
      <div class="carousel-caption">
        <h3></h3>
    <p></p>
      </div>
    </div>
  </div>

  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

        <!--- Carousel -->

     </div>
        <br/>
        <br/>
        <!--- Middle Contents -->
        <div class="conteiner center">
            <div class="row">
                <div class="col-lg-4">
                    <img class="img-circle" src="Imagens/musica.jpg" alt="thumb01" width="140" height="140" />
                    <h2>Músicas em inglês para crianças.</h2>  
                    <iframe width="400" height="360" src="https://www.youtube.com/embed/pssHsu06Jzs" frameborder="0" allowfullscreen></iframe>                  
                    <p>Assim como você provavelmente cresceu ouvindo bandas americanas e inglesas, experimente expor seus filhos à músicas em inglês ou até mesmo canções de desenhos animados. Conte a história das letras em português, assim eles irão usar a língua em um contexto significativo e, ao mesmo tempo, aprender sobre outras culturas. Músicas infantis em inglês também são boas opções para praticar a pronúncia e aprender diferentes sotaques.</p>
                    <p><a class="btn btn-default" href="Inscricao.aspx" role="button">Veja mais &raquo;</a></p>
                </div>
                <div class="col-lg-4">
                    <img class="img-circle" src="Imagens/brincado.jpg" alt="thumb02" width="140" height="140" />
                    <h2>Outras ideias para ensinar inglês às crianças</h2> 
                    <iframe width="400" height="360" src="https://www.youtube.com/embed/1IZ6NfpyfMQ" frameborder="0" allowfullscreen></iframe>                
                    <p>Há algumas brincadeiras que podem se transformar em divertidas atividades para aprender inglês brincando. Por exemplo, o jogo de forca e stop. Na brincadeira de forca, um jogador deve escolher uma palavra secreta em inglês, enquanto o outro deve adivinhá-la, seguindo a dica do número de letras e o tema associado à palavra. Cada erro aproxima esse participante de perder o jogo. Já para o jogo de stop, basta formar uma tabela com colunas e categorias a preencher com palavras em inglês. As crianças decidem a letra com que as palavras devem começar, e quem preencher primeiro as colunas grita ‘stop!’ e ganha pontos. Esses são bons exemplos de atividades de inglês para educação infantil que você pode fazer com os pequenos em casa. Tem outras sugestões de atividades de ensino de inglês para crianças? Compartilhe suas dicas conosco e com outros pais nos comentários abaixo.</p>
                    <p><a class="btn btn-default" href="Inscricao.aspx" role="button">Veja mais &raquo;</a></p>
                </div>
                <div class="col-lg-4">
                    <img class="img-circle" src="Imagens/desenhando.jpg" alt="thumb03" width="140" height="140" />
                    <h2>Atividades em inglês para colorir</h2>
                    <iframe width="400" height="360" src="https://www.youtube.com/embed/mRkBITAqRhM" frameborder="0" allowfullscreen></iframe>
                    <p>Praticar o inglês com atividades para colorir pode ser divertido e estimular a criatividade. Há vários recursos disponíveis online que ensinam sobre cores, números, animais e objetos. Se as atividades para colorir em inglês da sua escolha incluem legendas, procure traduzi-las para o português, estimulando o diálogo e a participação. O interessante é que esses exercícios de inglês ajudam a criança a fazer associações entre as duas línguas, permitindo que ela registre as palavras e os sons em sua memória com maior facilidade.</p>
                    <p><a class="btn btn-default" href="Inscricao.aspx" role="button">Veja mais &raquo;</a></p>
                </div>

                <div>
                    
            </div>
            </div>
        </div>
        <!--- Middle Contents -->

        
        <!--- Footer  -->

        <hr />

        <footer>
            <div class="container">
                <p class="pull-right"><a href="#"><span class="text-primary">Retornar ao Topo ^&nbsp; </span></a></p>
                <p>&copy; 2016 2°BCC - FEMA  - FlavioHAlves &middot; <a href="Page2.aspx">Inicío</a> &middot; <a href="http://www2.fema.edu.br/">Sobre</a> &middot; <a href="https://github.com/flavio-halves">Contato</a> &middot; <a href="Inscricao.aspx">Turmas</a></p>
            </div>
        </footer>

        <!--- Footer -->


        </div> 
    </form>
    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
        <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
