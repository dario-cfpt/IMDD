<?php
/**
 * Created by PhpStorm.
 * User: JOVANOVICD_INFO
 * Date: 09.03.2018
 * Time: 11:33
 */
session_start();

$_SESSION['id'] = $_GET['id'];
$sessionID = $_SESSION['id'];
if (isset($_GET['id'])) {
    $id = $_GET['id'];
}
var_dump($_SESSION);
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
<h1>Écran <?php if (isset($id)) {
        echo "$id";
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
$ecran = array();
for ($i = 1; $i < 10; $i++) {
    $ecran[$i][0] = $i;
    $ecran[$i][1] = "E";
}

if (isset($_GET['id'])){
    $id = $_GET['id'];
}
else{
    echo "pas d'ID";
    echo "<br>";
    $id = "";
}

if ($id > count($ecran)){
    echo "plus grand que le tableau";
}else if($id <= 0){
        echo"plus petit que 1";
    }
?>
