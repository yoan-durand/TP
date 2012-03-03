<?php
    header("Content-Type: image/jpeg");
    $img_src = imagecreatefromjpeg("../image/XV_france.jpg");
    $img_lg = imagecreatefrompng("../../chess/image/carre_grise.png");
    $img_dst = imagecreatetruecolor (800, 600);
    
    $lrg_src = imagesx($img_src);
    $ht_src = imagesy($img_src);
    $lrg_dst = imagesx($img_dst);
    $ht_dst = imagesy($img_dst);
    
    $lrg_lg = imagesx($img_lg);
    $ht_lg = imagesy ($img_lg);
    
    $posx = $lrg_dst - ($lrg_lg + 5);
    $posy = $ht_dst - ($ht_lg + 5);
    
    
    imagecopyresampled($img_dst, $img_src, 0, 0, 0, 0, $lrg_dst, $ht_dst, $lrg_src, $ht_src);
    imagecopymerge($img_dst, $img_lg, $posx, $posy, 0, 0, $lrg_lg, $ht_lg, 60);
    
    imagejpeg($img_dst, '../image/new_logo.jpeg', 70);
    $new = imagecreatefromjpeg("../image/new_logo.jpeg");
    imagejpeg($new);

    imagedestroy($img_dst);
    imagedestroy($img_src);
    imagedestroy($img_lg);
    imagedestroy($new);
?>