<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE html>
<html>
    <head>
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
            
            //echo "<img src=\"affiche_image.php\" alt=\"echequier\"/><br/><br/><br/><br/>";           
            $chessboard = ChessBoard::get_instance();
           
            $chessboard->display();
        ?>
    </body>
</html>
