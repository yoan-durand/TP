<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE html>
<html>
    <head>
        <?php
       // header("Content-Type: application/json");
        session_start();
        ?>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>The Game</title>
        <script src="js/draw_board.js"></script>
    </head>
    <body>
        <canvas id="mon_canvas" width="800" height="800">
            looser tu supporte pas canvas
        </canvas>
        <br/>
        <?php
            
            
            function __autoload($class_name) 
            {
               include $class_name . '.php';
            }
            $chessboard = ChessBoard::get_instance();
           
            $_SESSION["chessboard"] = $chessboard;
            
            $_SESSION["chessboard"];
            
            
        ?>
    </body>
</html>
