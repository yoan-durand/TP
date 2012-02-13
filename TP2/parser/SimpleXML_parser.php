<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>SimpleXML Parser</title>
    </head>
    <body>
        <?php
            $filexml = simplexml_load_file('automobile.xml');
           foreach ($filexml->channel->children () as $child => $value)
           {
                echo "<h3>".$value->title[0]."</h3><br/>\n\t\t";
                echo "<a href=\"".$value->link[0]."\">".$value->link[0]."</a><br/>\n\t\t";
                echo "<image src=\"".$value->enclosure['url']."\"/><br/>\n\t\t";
           }
        ?>
    </body>
</html>
