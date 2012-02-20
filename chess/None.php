<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of None
 *
 * @author yoan
 */
class None extends Piece
{
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->type = "-";
    }
    
    public function move($from, $to) 
    {
        $from = 0;
        $to = 0;
    }
    
    public function eat ()
    {
        
    }
    
    public function display()
    {
              echo "--";
    }

    public function check($to) {
        
    }
}

?>
