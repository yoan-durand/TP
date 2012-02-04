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
        <ul>
                <form enctype="multipart/form-data" action="confirmation.php" method="post">
                <input type="hidden" name="MAX_FILE_SIZE" value="30000000"/>
            
                    <?php
                        for ($i = 0; $i < 10; $i++)
                        {
                            echo '<li><input name="userfile[]" type="file"></li>';
                        }
                    ?>
                <input type="submit" value="Envoyer">
                </form>
        </ul>

    </body>
</html>
