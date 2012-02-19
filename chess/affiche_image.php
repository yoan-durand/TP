<?php
error_reporting (E_ALL);
ini_set ("display_errors", 1);
/*header ("Content-Type : image/png");
$noir = imagecreatefrompng("image/carre_noir.png");
$gris = imagecreatefrompng("image/carre_grise.png");
//recuperation de la taille des images.
$width_black = imagesx($noir);
$heigth_black = imagesy($noir);                  
$width_grey = imagesx($gris);
$heigth_grey = imagesy($gris);
$width = 8 * $width_black;
$heigth = 8 * $heigth_black;

// the chessboard

$chess = imagetruecolor($width, $heigth);

for ($i = 0; $i < 8; $i++)
{
    for ($j = 0; $j < 8; $j++)
    {
        if ($i % 2 == 0)
        {
            if ($j % 2 == 0)
            {
                imagecopymerge($chess, $noir, ($j*$width_black), ($i * $width_black), 0, 0, $width_black, $heigth_black, 50);
            }
            else
                imagecopymerge($chess, $gris, ($j*$width_black), ($i * $width_black), 0, 0, $width_grey, $heigth_grey, 50);

        }
        else
        {
            if ($j%2 == 0)
                imagecopymerge($chess, $gris, ($j * $width_black), ($i * $width_black), 0, 0, $width_black, $heigth_black, 50);

            else
                imagecopymerge($chess, $noir, ($j * $width_black), ($i * $width_black), 0, 0, $width_black, $heigth_black, 50);

        }

    }
    echo "coucou";
    imagepng($chess, "images/new.png");
    $new = imagecreatefrompng("image/new.png");
    imagepng($new);
    imagedestroy($chess);
    imagedestroy($noir);
    imagedestroy($gris);*/
$image = imagecreate(160, 160);

$noir = imagecolorallocate($image, 0, 0, 0);
//$white = imagecolorallocate($image, 255, 255, 255);
    for ($i =  0; $i < 8; $i++)
    {
        for ($j = 0; $j < 8; $j++)
        {
            if ($j % 2 == 0)
                imagefilledrectangle($image, $j * 20, $i * 20, (($j + 1) * 20) + 8, (($i + 1)* 20 ) + 8, $noir);
            else
                imagerectangle($image, $j * 20, $i * 20, (($j + 1) * 20) + 8, (($i + 1)* 20 ) + 8, $noir);
        }
    }
    imagejpeg($image);
?>
