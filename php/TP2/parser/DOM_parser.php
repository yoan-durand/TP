<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>DOM PARSER</title>
    </head>
    <body>
        <?php
            $dom = new DOMDocument();
            $dom->preserveWhiteSpace = False;
            $dom->load('automobile.xml');
            $dom->saveXML();

            $titlelist = $dom->getElementsByTagName('title');
            $linklist = $dom->getElementsByTagName('link');
            $vignlist = $dom->getElementsByTagName('enclosure');
            $description = $dom->getElementsByTagName('description');
            
            for ($i = 1; $i < $titlelist->length; $i++)
            {
                
                echo "<h3>".$titlelist->item ($i)->nodeValue."</h3>\n\t\t";
                echo "<a href=\"".$linklist->item($i)->nodeValue."\">".$linklist->item($i)->nodeValue."</a><br/>\n\t\t";
                if ($i >= 2)
                {
                    echo "<image src=\"".$vignlist->item($i - 2)->attributes->item(0)->nodeValue."\"><br/>\n\t\t";
                    echo "<p>".$description->item($i-1)->nodeValue."</p><br/>\n\t";
                }
            }
        ?>
    </body>
</html>
