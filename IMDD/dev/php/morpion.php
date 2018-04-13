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
    <title>Menu</title>
    <link href="../css/bootstrap.css" rel="stylesheet">
    <link rel="stylesheet" href="../css/style.css">
    <link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet">
    <script
            src="https://code.jquery.com/jquery-3.3.1.slim.js"
            integrity="sha256-fNXJFIlca05BIO2Y5zh1xrShK3ME+/lYZ0j+ChxX2DA="
            crossorigin="anonymous"></script>
    <script src="./js/bootstrap.js"></script>
</head>
<body>
<div style="background-color: #2aabd2" class="content">

</div>
</body>
<script>
    $(document).ready(function () {
        $('body').click(function () {

        })
    })
</script>
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



if ($board[$_GET['id']])
?>
