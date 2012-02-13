<!--
To change this template, choose Tools | Templates
and open the template in the editor.
-->
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>SAX Parser</title>
    </head>
    <body>
        <?php
            $file = "automobile.xml";
            
            function startElement($parser, $name, $attribs)
            {
                global $balisename;
                global $img;
                global $pos;


                if ($name == "ENCLOSURE")
                {
                    foreach ($attribs as $attname => $attvalue)
                    {
                        if ($attname == "URL")
                            $img = $attvalue;
                    }
                }
                
                $balisename = $name;
                $pos = true;
            }

            function endElement($parser, $name)
            {
                global $balisename;
                global $text;
                global $img;
                switch ($name)
                {
                    case "TITLE" :
                        echo "<h3>".$text."</h3><br/>";
                        $pos = false;
                        $text = "";
                        break;
                    case "LINK" :
                        echo "<a href=\"".$text."\">".$text."</a><br/>\n\t\t";
                        $pos = false;
                        $text = "";
                        break;
                    case "ENCLOSURE" :
                        echo "<img src=\"".$img."\"/><br/>\n\t\t";
                        $pos = false;
                        $text = "";
                        break;
                    
                }
            }

            function chandler($parser, $data)
            {
                global $balisename;
                global $text;
                if (!$pos)
                {
                    switch ($balisename)
                    {
                        case "TITLE":
                            $text .= $data;
                            break;
                        case "LINK" :
                            $text .= $data;
                            break;
                    }
                }
            }
            
            $parser = xml_parser_create();
            xml_parser_get_option($parser, XML_OPTION_CASE_FOLDING, 0);

            xml_set_element_handler($parser, "startElement", "endElement");
            xml_set_character_data_handler($parser, "chandler");

        $fp = fopen($file, "r");
        if (!$fp) die("Impossible d'ouvrir le fichier XML");

        $xmlstr = file_get_contents($file);
        xml_parse($parser, $xmlstr) or
           die("Erreur XML  ".  xml_error_string(xml_get_error_code($parser))
                ." ".xml_get_current_line_number($parser));
        
    fclose($fp);
            xml_parser_free($parser);
        ?>
    </body>
</html>
