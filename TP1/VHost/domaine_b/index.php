<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE html>
<?php
    if (!(isset($_COOKIE['cookie'])))
    {
        setcookie('cookie', "Cookie creer en domaine-b", 0, '/', 'mon-rack.local');
    }
?>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title></title>
    </head>
    <body>
        <?php
            if (isset($_COOKIE['cookie']))
            {
                echo "Cookie : ". $_COOKIE['cookie'] . "<br />";
            }
            else
            {
                echo "le cookie n'existe pas. <br />";
            }
        ?>
        
        <a href="upload.php">Exercice upload </a>
    </body>
</html>
