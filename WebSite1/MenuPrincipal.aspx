<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MenuPrincipal.aspx.cs" Inherits="MenuPrincipal" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <link rel="icon" href="/fonts/1.png">

  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <meta name="description" content="">
  <meta name="author" content="">

  <title>Inventory Management System</title>

  <!-- Bootstrap core CSS -->
  <link href="css/bootstrap.min.css" rel="stylesheet">

  <!-- Custom styles for this template -->
  <link href="css/shop-homepage.css" rel="stylesheet">

</head>

<body>

  <!-- Navigation -->
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
    <div class="container">
      <a class="navbar-brand" href="/MenuPrincipal.aspx">A&P</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <%--<div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav ml-auto">
          <li class="nav-item active">
            <a class="nav-link" href="#">Home
              <span class="sr-only">(current)</span>
            </a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">About</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Services</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Contact</a>
          </li>
        </ul>
      </div>--%>
    </div>
  </nav>

  <!-- Page Content -->
  <div class="container">

    <div class="row">

      <div class="col-lg-3">

        <h1 class="my-4">Inventory Management System</h1>
        <div class="list-group">
          <a href="ConsultaCliente.aspx" class="list-group-item">Clientes</a>
          <a href="ConsultaEmpleado.aspx" class="list-group-item">Empleados</a>
          <a href="#" class="list-group-item">Pedidos</a>
            <a href="ConsultaAlmacenes.aspx" class="list-group-item">Almacenes</a>
            <a href="#" class="list-group-item">Locaciones!</a>
            <a href="#" class="list-group-item">Productos</a>
            <a href="#" class="list-group-item">Puestos</a>

        </div>

      </div>
      <!-- /.col-lg-3 -->

      <div class="col-lg-9">

        <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
          <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
          </ol>
          <div class="carousel-inner" role="listbox">
            <div class="carousel-item active">
              <img class="d-block img-fluid" src="https://blog.comparasoftware.com/wp-content/uploads/2019/05/Nociones-y-recomendaciones-para-la-implantaci%C3%B3n-del-software-de-gesti%C3%B3n-de-inventario.jpg" alt="First slide">
            </div>
            <div class="carousel-item">
              <img class="d-block img-fluid" src="http://mdc.org.co/wp-content/uploads/2018/01/inventario.jpg" alt="Second slide">
            </div>
            <div class="carousel-item">
              <img class="d-block img-fluid" src="http://placehold.it/900x350" alt="Third slide">
            </div>
          </div>
          <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Anterior</span>
          </a>
          <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Siguiente</span>
          </a>
        </div>

        <div class="row">

          <div class="col-lg-4 col-md-6 mb-4">
            <div class="card h-100">
              <a href="#"><img class="card-img-top" src="http://www.gesol.com.pk/images/clients.jpg" alt=""></a>
              <div class="card-body">
                <h4 class="card-title">
                  <a href="ConsultaCliente.aspx">Clientes</a>
                </h4>
                
                <p class="card-text">Consulta, Modificacion, Alta y Baja de nuestros clientes principales!</p>
              </div>
              <div class="card-footer">
                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9733;</small>
              </div>
            </div>
          </div>

          <div class="col-lg-4 col-md-6 mb-4">
            <div class="card h-100">
              <a href="#"><img class="card-img-top" src="https://www.icr-evolution.com/wp-content/uploads/2017/10/people.jpg" alt=""></a>
              <div class="card-body">
                <h4 class="card-title">
                  <a href="ConsultaEmpleado.aspx">Empleados</a>
                </h4>
                
                <p class="card-text">Consulta, Modificacion, Alta y Baja de nuestros colaboradores!</p>
              </div>
              <div class="card-footer">
                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9733;</small>
              </div>
            </div>
          </div>


          
          <div class="col-lg-4 col-md-6 mb-4">
            <div class="card h-100">
              <a href="#"><img class="card-img-top" src="https://insights.la/wp-content/uploads/2018/04/pedidos-a-domicilio-latinoamerica-tendencias.jpg" alt=""></a>
              <div class="card-body">
                <h4 class="card-title">
                  <a href="#">Pedidos</a>
                </h4>
                
                <p class="card-text">Consulta, Modificacion, Alta y Baja de nuestros colaboradores!</p>
              </div>
              <div class="card-footer">
                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9733;</small>
              </div>
            </div>
          </div>


            <div class="col-lg-4 col-md-6 mb-4">
            <div class="card h-100">
              <a href="#"><img class="card-img-top" src="https://timsacr.com/esp/wp-content/uploads/2015/09/Sistema-Racks-Drive-In-1.jpg" alt=""></a>
              <div class="card-body">
                <h4 class="card-title">
                  <a href="ConsultaAlmacenes.aspx">Almacenes</a>
                </h4>
                
                <p class="card-text">Consulta, Modificacion, Alta y Baja de Almacenes!</p>
              </div>
              <div class="card-footer">
                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9733;</small>
              </div>
            </div>
          </div>


            <div class="col-lg-4 col-md-6 mb-4">
            <div class="card h-100">
              <a href="#"><img class="card-img-top" src="http://www.fotoestudiomonterrey.com/wp-content/uploads/2017/05/Sesio%CC%81n-Industrial-Foto-Industria-Empresa-Fotografia-Bodega-2-1.jpg" alt=""></a>
              <div class="card-body">
                <h4 class="card-title">
                  <a href="#">Locaciones</a>
                </h4>
                
                <p class="card-text">Consulta, Modificacion, Alta y Baja de nuestros Locaciones!</p>
              </div>
              <div class="card-footer">
                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9733;</small>
              </div>
            </div>
          </div>


            <div class="col-lg-4 col-md-6 mb-4">
            <div class="card h-100">
              <a href="#"><img class="card-img-top" src="https://taitiong.com/wp-content/uploads/2018/04/various-auto-parts.jpg" alt=""></a>
              <div class="card-body">
                <h4 class="card-title">
                  <a href="#">Productos</a>
                </h4>
                
                <p class="card-text">Consulta, Modificacion, Alta y Baja de nuestros principales productos!</p>
              </div>
              <div class="card-footer">
                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9733;</small>
              </div>
            </div>
          </div>

            <div class="col-lg-4 col-md-6 mb-4">
            <div class="card h-100">
              <a href="#"><img class="card-img-top" src="https://www.apertura.com/__export/1500304656069/sites/revistaap/img/2017/07/17/trabajo_.jpg_1913337537.jpg" alt=""></a>
              <div class="card-body">
                <h4 class="card-title">
                  <a href="#">Puestos</a>
                </h4>
                
                <p class="card-text">Analisis de Puestos Disponibles en nuestra estructura!</p>
              </div>
              <div class="card-footer">
                <small class="text-muted">&#9733; &#9733; &#9733; &#9733; &#9733;</small>
              </div>
            </div>
          </div>
        </div>
        <!-- /.row -->

      </div>
      <!-- /.col-lg-9 -->

    </div>
    <!-- /.row -->

  </div>
  <!-- /.container -->

  <!-- Footer -->
  <footer class="py-5 bg-dark">
    <div class="container">
      <p class="m-0 text-center text-white">Copyright &copy; <%: DateTime.Now.Year %> - A&P Web Application</p>
    </div>
    <!-- /.container -->
  </footer>

  <!-- Bootstrap core JavaScript -->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</body>

</html>
