<?php
/**
 * Created by PhpStorm.
 * User: JOVANOVICD_INFO
 * Date: 13.04.2018
 * Time: 10:26
 */


function getTurn()
{
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
    //test pour le prochain tour
    if ($victory = null){
        $turn = $board[9];
        if ( $turn == 'X' ){
            $board[9] = 'O';
        }else{
            $board[9] = 'X';
        }
        return $turn;
    }else{
        return $victory;
    }
}

?>