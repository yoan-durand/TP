<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE html>
<?php
    if (!(isset($_COOKIE["cookie"])))
    {
        setcookie("cookie", "Cookie creer en domaine-a", (time() + 1), "/", "mon-rack.local");
    }
    
    session_start();
    $_SESSION['prenom']='yoan';
    $_SESSION['nom']='durand';
    $_SESSION['spe']='mti';
?>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title></title>
    </head>
    <body>
        <?php
            if (isset($_COOKIE["cookie"]))
            {
                echo "Cookie : ". $_COOKIE["cookie"] . "<br />";
            }
            else
            {
                echo "le cookie n'existe pas. <br />";
            }
            
           
        ?>
    </body>
</html>
