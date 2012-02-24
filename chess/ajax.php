<?php
    header("Content-Type: application/json");
    session_start();
    
    $x = 0;
    $y = 0;
   
    function __autoload($class_name) 
    {
        include $class_name . '.php';
    }
    
    $x = $_GET["mx"];
    $y = $_GET["my"];
    echo $x;
    echo $y;
    $test = $_SESSION["chessboard"];
    $chess = ChessBoard::get_instance();
    $chess->board = $test;
    $tab = $chess->board[$x][$y]->check($x, $y);
    $my_encode_array = json_encode($tab);
    echo $my_encode_array;
    
?>
