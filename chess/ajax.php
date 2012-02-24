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
    $test = $_SESSION["chessboard"];
    
    $tab = $test->board[$y][$x]->check($x, $y);
    $my_encode_array = json_encode($tab);
    echo $my_encode_array;
    
?>
