<?php
/**
 * Created by PhpStorm.
 * User: JOVANOVICD_INFO
 * Date: 09.03.2018
 * Time: 11:33
 */
require_once "fonctionsBD.php";
?>
<!doctype html>
<html lang="fr">
<head>
    <meta charset="utf-8">
    <meta http-equiv="refresh" content="1">
    <title>Menu</title>
    <link href="../css/bootstrap.css" rel="stylesheet">
    <link rel="stylesheet" href="../css/style.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet">
    <script src="./js/bootstrap.js"></script>
</head>
<body>
<h1>Écran <?php if (isset($_GET['id'])) {
        echo $_GET['id'];
    }; ?></h1>
<fieldset>
    <table class="table table-striped table-dark">
        <tbody>
        <tr>
            <td><a href="../html/snake_index.html">Jeu du snake</a></td>
        </tr>
        <tr>
            <td><a href="../html/Taquin.php">Taquin</a></td>
        </tr>
        <tr>
            <td><a href="#">Memory</a></td>
        </tr>
        </tbody>
    </table>
</fieldset>

</body>
</html>
<?php
// test pour vérifier qu'il n'y a pas d'erreur dans le nombre d'écran
$ecran = array();
for ($i = 1; $i < 10; $i++) {
    $ecran[$i][0] = $i;
    $ecran[$i][1] = "E";
}
if (isset($_GET['id'])) {
    $id = $_GET['id'];
}
if ($id > count($ecran)) {
    echo "plus grand que le tableau";
} else if ($id <= 0) {
    echo "plus petit que 1";
}
$board = getArray();
$victory = false;
//test victoire ligne
if ($board[0] == $board[1] && $board[0] == $board[2]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}
if ($board[3] == $board[4] && $board[3] == $board[5]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}
if ($board[4] == $board[5] && $board[4] == $board[6]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}

//test victoire colone
if ($board[0] == $board[3] && $board[0] == $board[6]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}
if ($board[1] == $board[4] && $board[1] == $board[7]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}
if ($board[2] == $board[5] && $board[2] == $board[8]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}

//test victoire diagonal
if ($board[0] == $board[4] && $board[0] == $board[8]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}
if ($board[2] == $board[4] && $board[2] == $board[6]) {
    if ($board[0] == "X") {
        $victory = "X";/*victoire X*/
    } else {
        $victory = "O";/*victoire O*/
    }
}

if ($board[$_GET['id']])
?>
