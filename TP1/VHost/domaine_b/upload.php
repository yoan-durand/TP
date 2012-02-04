<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title></title>
    </head>
    <body>
        <form enctype="multipart/form-data" action="_URL_" method="post">
            <input type="hidden" name="MAX_FILE_SIZE" value="30000000"/>
            
            <?php
                for ($i = 0; $i < 10; $i++)
                {
                    echo '<input name="userfile[]" type="file">';
                }
            ?>
            <input type="submit" value="Envoyer">
        </form>
    </body>
</html>
