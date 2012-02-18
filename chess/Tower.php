<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Tower
 *
 * @author durand_y
 */
class Tower extends Piece 
{
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $x;
        $this->pos_y = $y;
        $this->color = $color;
        $this->alive = $alive;
    }
    
    public function color_move() 
    {
        
    }
    
    public function eat ()
    {
        
    }
    
}

?>
