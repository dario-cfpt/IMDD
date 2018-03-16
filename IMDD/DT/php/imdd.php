<?php
/**
 * Created by PhpStorm.
 * User: JOVANOVICD_INFO
 * Date: 09.03.2018
 * Time: 11:33
 */
if (isset($_GET['id'])) {
    $id = $_GET['id'];
}
?>
<!doctype html>
<html lang="fr">
<head>
    <meta charset="utf-8">
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
            <td><a href="html/snake_index.html">Jeu du snake</a></td>
        </tr>
        <tr>
            <td><a href="html/Taquin.php">Taquin</a></td>
        </tr>
        <tr>
            <td><a href="#">Memory</a></td>
        </tr>
        </tbody>
    </table>
</fieldset>
<!--
<tr>
    <td></td>
</tr>-->
</body>
</html>
<?php
$ecran = array();
for ($i = 1; $i < 10; $i++) {
    $ecran[$i][0] = $i;
    $ecran[$i][1] = "E";
}



if ($_GET['id'] > count($ecran)){
    echo "plus grand que le tableau";
}else if($_GET['id'] <= 0){
        echo"plus petit que 1";
    }
?>
