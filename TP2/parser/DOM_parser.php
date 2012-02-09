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
            $dom = new DOMDocument();
            $dom->preserveWhiteSpace = False;
            $dom->load('automobile.xml');
            $dom->formatOutput = TRUE;
            print $dom->saveXML();

            $root = $dom->documentElement;

            echo "rootAttribs [".$root->attributes->length."]:\n";

            for ($i = 0; $i < $root->attributes->length; $i++)
            {
                echo "[".$root->attributes->item($i)->NodeName."] => ";
                echo $root->attributed->item($i)->NodeValue."\n";
                if (hasChildNodes () == true)
                {
                    $child = $root->firstChild;
                    echo "";
                }
            }
        ?>
    </body>
</html>
