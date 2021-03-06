<?php
/*
 * Author : Dylan Peiry
 * Date : 09.03.2018
 * Name : imdd
 * Description : A definir
 * Version : 1.0
 */
require_once 'php/imdd.php';
$index = filter_input(1, 'i', FILTER_SANITIZE_NUMBER_INT);
$errormsg;
$title;

if (empty($index)) {
    $errormsg = "Un des paramètres reçu n'est pas correct.";
    $title = "Home";
} else {
    $title = $index;
}
var_dump(IMDD::getInstance());
?>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <!-- CSS & Libraries-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
          integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"
            integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"
            crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"
            integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"
            crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"
            integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"
            crossorigin="anonymous"></script>
    <link rel="stylesheet" href="css/style.css">

    <title>IMDD - <?php if (isset($title)) echo $title; ?></title>
</head>
<body>
<nav class="navbar navbar-expand-lg navbar-light" style="background-color: #e3f2fd;">
    <a class="navbar-brand" href="#">IMDD</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>

    <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item active">
                <a class="nav-link" href="#">Accueil <span class="sr-only">(current)</span></a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Configuration</a>
            </li>
            <li class="nav-item dropdown">
                <a class="nav-link dropdown-toggle" href="#" id="dropdownGames" role="button" data-toggle="dropdown"
                   aria-haspopup="true" aria-expanded="false">
                    Jeux
                </a>
                <div class="dropdown-menu" aria-labelledby="dropdownGames">
                    <a class="dropdown-item disabled" href="#" disabled>Tic Tac Toe</a>
                    <a class="dropdown-item" href="pages/snake.html">Snake</a>
                    <a class="dropdown-item disabled" href="#">Pong</a>
                    <a class="dropdown-item disabled" href="#">Taquin</a>
                </div>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Photos</a>
            </li>
        </ul>
    </div>
</nav>
<?php if (isset($errormsg)) { ?>
    <div class="alert alert-danger"><?= $errormsg; ?></div>
<?php } ?>
</body>
</html>
