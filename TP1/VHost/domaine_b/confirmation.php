<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        error_reporting(E_ALL);
        ini_set("display_errors", 1);
        
        foreach ($_FILES["userfile"]["error"] as $key => $error)
        {
         if ($error == UPLOAD_ERR_OK)
         {
            $tmp_name = $_FILES["userfile"]["tmp_name"][$key];
            $name = $_FILES["userfile"]["name"][$key];
            if (is_uploaded_file($tmp_name))
            {
                if (move_uploaded_file($tmp_name, "../upload/$name") == TRUE)
                {
                    echo "UPload ok <br/>";
                }
                else
                {
                    echo "Upload fail <br/>";
                }
            }
         }
        }
         ?>
    </body>
</html>
