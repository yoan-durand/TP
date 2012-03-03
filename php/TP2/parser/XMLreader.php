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
            $cpt = 0;
            
            while ($pxml->read())
            {
                if ($cpt % 2 == 0)
                {
                    switch ($pxml->name)
                    {
                        case "title" :
                            echo "<h3>".$pxml->readString()."</h3><br/>\n\t\t";
                            break;
                        case "link" :
                            echo "<a href=\"".$pxml->readString()."\">".$pxml->readString()."</a><br/>\n\t\t";
                            break;
                        case "enclosure" :
                            echo "<img src=\"".$pxml->getAttribute("url")."\"><br>\n\t\t";
                            break;
                    }        
                }
                 $cpt++;
            }
            $pxml->close ();

        ?>
    </body>
</html>
