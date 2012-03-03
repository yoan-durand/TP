<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE html>
<html>
    <head>
        <?php
        session_start();
        ?>
        <meta charset=UTF-8">
         <link rel="stylesheet" href="image/style.css" /> 
        <title>The Game</title>
        <script src="js/draw_board.js"></script>
    </head>
    <body>
        <section>
            <canvas id="mon_canvas" width="800" height="800" >
            looser tu supporte pas canvas
        </canvas>
        </section>>
        <br/>
        <?php
            
            
            function __autoload($class_name) 
            {
               include $class_name . '.php';
            }
            $chessboard = ChessBoard::get_instance();
           
            $_SESSION["chessboard"] = $chessboard;
            $_SESSION["player"] = 0;
            
            $_SESSION["chessboard"];
            
            
        ?>
    </body>
</html>
