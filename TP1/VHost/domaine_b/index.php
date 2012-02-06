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
        echo "version".  phpversion()."<br />";
            $gd_info = gd_info();
            
            if (!$gd_info)
            {
                echo "lib gd pas installe <br/>";
            }
            
            echo "gd version: {$gd_info['GD Version']}"."<br/>";
            if (isset($_COOKIE['cookie']))
            {
                echo "Cookie : ". $_COOKIE['cookie'] . "<br />";
            }
            else
            {
                echo "le cookie n'existe pas. <br />";
            }
        ?>
        
        <a href="mail.php">Envoyer un mail</a>
        <br/>
        <a href="upload.php">Exercice upload </a>
        <br/>
        <a href="image.php">Exercice image </a>
        <br/>
    </body>
</html>
