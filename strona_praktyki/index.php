<!DOCTYPE html>

<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Praktyki zadanie 1</title>
    <link rel="stylesheet" href="css/Bootstrap.css">

    <style>
       body {
            background-image: url('images/tlo.jpg');
            background-size: cover; 
            background-position: center; 
            background-repeat: repeat; 
            
        }

        .content-wrapper {
            background-color: rgba(255, 255, 255, 0.8); 
            padding: 20px;
            border-radius: 10px;
            text-align: center;
            margin: 20px auto;
            max-width: 800px;
        }

        .content-wrapper2 {
            background-color: rgba(255, 255, 255, 0.8); 
            padding: 20px;
            border-radius: 10px;
            text-align: center;
            margin: 20px auto;
            max-width: 300px;
        }

    </style>
</head>
<body>
     <div class="content-wrapper">
        <h1>Witaj na mojej stronie</h1>

        <ul class="nav nav-pills nav-fill">

            <li class="nav-item">
                <a class="nav-link" style="background-color: lightgray; color: blue;" href="Kontakt.html">Kontakt</a>
            </li>
            <li class="nav-item">
                <a class="nav-link active" aria-current="page" href="pliki.html">Przepisy do pobrania</a>
            </li>
        
            <li class="nav-item">
                <a class="nav-link active" style="background-color:lightgray; color: blue;"  href="form.html" >Zaloguj się</a>
            </li>';
            
        </ul>
    </div> <br />
    

    <div class="container";>
        <div class="row">
            <div class="content-wrapper2"; "col-xxl-3 col-sm-6 col-xs-12"; >  <div class="float-end">
                <a class="nav-link active" aria-current="page" href="rafaello.html">Przepis na domowe Rafaello</a> <br> 
                <img src="images/rafaello.jpg" class="img-fluid"> </div>
            </div>
    <! ------------------------------------------------------------------------------------------------------------ ->

            <div class="content-wrapper2"; "col-xxl-3 col-sm-6 col-xs-12"; > <div class="float-center">
                <a class="nav-link active" aria-current="page" href="ciasto_dzien_i_noc.html"> Przepis na Ciasto czekoladowe dzień i noc</a> <br> 
                <img src="images/dzien_i_noc.jpg" class="img-fluid"> </div>
            </div> 
    <!– ------------------------------------------------------------------------------------------------------------ ->     
    
            <div class="content-wrapper2"; "col-xxl-3 col-sm-6 col-xs-12"; >  <div class="float-center">
                <a class="nav-link active" aria-current="page" href="Oponki_serowe.html">Przepis na Oponki serowe</a> <br> 
                <img src="images/oponki.jpg" width="200" height="200" class="img-fluid" > </div> 
            </div>
    <!– ------------------------------------------------------------------------------------------------------------ ->

            <div class="content-wrapper2"; "col-xxl-3 col-sm-6 col-xs-12"; >  <div class="float-center"> 
            <a class="nav-link active" aria-current="page" href="Paszteciki.html" align="center"> Przepis na paszteciki </a> <br> 
            <img src="images/paszteciki.jpg" class="img-fluid"> </div>
            </div>
    <!– ------------------------------------------------------------------------------------------------------------ ->
       
            <div class="content-wrapper2"; "col-xxl-3 col-sm-6 col-xs-12"; >  <div class="float-center">
                <a class="nav-link active" aria-current="page" href="ogorki.html">Przepis na ogórki w przyprawie curry </a> <br> 
                <img src="images/ogorki_curry.jpg" class="img-fluid"> </div>
            </div>
    <!– ------------------------------------------------------------------------------------------------------------ ->

            <div class="content-wrapper2"; "col-xxl-3 col-sm-6 col-xs-12"; > <div class="float-center">
                <a class="nav-link active" aria-current="page" href="gofry.html"> Przepis na Gofry</a> <br> 
                <img src="images/gofry.jpg" class="img-fluid"> </div>
            </div> 

            </div>         
    </div>

    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js"
            integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r"
            crossorigin="anonymous"></script>

    <script src="js/Bootstrap.js"></script>
    <script>
        document.addEventListener('contextmenu', function (event) {
            event.preventDefault();
        });

        document.addEventListener('copy', function (event) {
            event.preventDefault();
        });

        document.addEventListener('selectstart', function (event) {
            event.preventDefault();
        });
    </script>
    



</body>
</html>
