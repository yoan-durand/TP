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
            $pxml = new XMLReader();
            $pxml->open('automobile.xml');

            while ($pxml->read())
            {
                
                switch ($pxml->name)
                {
                case "title" :
                    echo "<h3>".$pxml->value."</h3><br/>";
                    break;
                case "link" :
                    echo "<a href=\"".$pxml->value."\">".$pxml->value."</a><br/>";
                    break;
                case "enclosure" :
                    echo "<img src=\"".$pxml->getAttribute("url")."\">";
                    break;
                }
            }

        ?>
    </body>
</html>
