<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Knight
 *
 * @author durand_y
 */
class Knight extends Piece
{
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
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
