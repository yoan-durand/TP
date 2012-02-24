<?php
    header("Content-Type: application/json");
    session_start();
    
    
    $_SESSION["chessboard"] = $chessboard;

    $_SESSION["chessboard"]->display();
    
    $x = 0;
    $y = 0;

    $x = $_GET["mx"];
    $y = $_GET["my"];

    $tab = $_SESSION["chessboard"][$x][$y]->check ($x, $y);
    $my_encode_array = json_encode($tab);
    echo $my_encode_array;
    $chessboard = ChessBoard::get_instance();

    $_SESSION["chessboard"] = $chessboard;

    $_SESSION["chessboard"]->display();
?>
