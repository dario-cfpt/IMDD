<?php
define('DB_HOST', "127.0.0.1"); //adresse ip de la base.
define('DB_NAME', "morpion"); //nom de la base de donnée.
define('DB_USER', "root"); //utilisateur.
define('DB_PASS', ""); //mdp.
/* Fonction permettant la connexion à la base de données  */
function getConnexion() {
    static $dbb = null;
    if ($dbb === null) {
        try {
            $connectionString = 'mysql:host=' . DB_HOST . ';dbname=' . DB_NAME . '';
            $dbb = new PDO($connectionString, DB_USER, DB_PASS);
            $dbb->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            $dbb->exec("SET CHARACTER SET utf8");
        } catch (PDOException $e) {
            die('Erreur : ' . $e->getMessage());
        }
    }
    return $dbb;
}


/* Fonction permettant d'ajouter dans la base de données les valeurs du jeu du morpion  */
function play($case,$valeur)
{
    $connexion = getConnexion();
    $request = $connexion->prepare("INSERT INTO `morpion` (`case`,`valeur`) VALUES (:case, :valeur)");
    $request->bindParam(':case', $case, PDO::PARAM_INT);
    $request->bindParam(':valeur', $valeur, PDO::PARAM_STR);
    $request->execute();
}

/* Fonction pour les cases du morpion */
function getArray(){
    try {
        $connexion = getConnexion();
        $requete = $connexion->prepare("SELECT * FROM morpion;");
        $requete->execute();
        $resultat = $requete->fetchAll(PDO::FETCH_ASSOC);
        return $resultat;
    } catch (PDOException $e) {
        throw $e;
    }
}

/* Fonctin pour savoir qui as jouer (joueur 1 ou 2) */
function setTurn(){
    try {
        $connexion = getConnexion();
        $requete = $connexion->prepare("SELECT valeur FROM `morpion` WHERE `case` = 10;");
        $requete->execute();
        $resultat = $requete->fetchAll(PDO::FETCH_ASSOC);
        return $resultat;
    } catch (PDOException $e) {
        throw $e;
    }
}

?>
