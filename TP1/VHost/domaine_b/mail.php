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

            $destinataire='durand.yona@free.fr';
            $email_expediteur='durand.yoan.facture@gmail.com';
            $email_reply='yoan.durand@epita.fr';
            $sujet = 'test';
            $message_txt = 'Yeah'."\n\n".'message format texte';
            $message_html='<html>
                    <head>
                        <title> TITRE </title>
                    </head>
                    <body>
                        message de test TP-netbeans
                    </body>
                        </html>';

            $frontiere="----=".  md5(uniqid(mt_rand()));
            
            $header = 'From:"Nom" <'.$email_expediteur.'>'."\n";
            $header .= 'Return-Path <'.$email_reply.'>'."\n";
            $header .= 'MIME-Versions:1.0'."\n";
            $header .= 'Content-Type: multipart/alternative; boundary="'.$frontiere.'"';

            $message = "This is a multipart message in MIME format\n";
            $message .= '--'.$frontiere.'--'."\n";
            $message .= 'Content-Type: test/html; charset="iso-8859-1"'."\n";
            $message .= 'Content-Transfer-Encoding:8bit'."\n\n";
            $message .= $message_txt."\n\n";
            $message .= '--'.$frontiere.'--'."\n";
            $message .= 'Content-Type: test/html; charset="iso-8859-1"'."\n";
            $message .= 'Content-Transfer-Encoding:8bit'."\n\n";
            $message .= $message_html."\n";
            $message .= '--'.$frontiere.'--'."\n";
            
            
            if (mail($destinataire, $sujet, $message, $header))
            {
                echo "mail send <br/>";
            }
            else
            {
                echo "fail";
            }
        ?>
    </body>
</html>
