<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Pawn
 *
 * @author durand_y
 */
class Pawn extends Piece 
{
    private $first;
    
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->first = 0;
    }
    
    public function color_move() 
    {
        if ($this->first == 0)
        {
            
        }
        
    }
    
    public function eat ()
    {
        
    }
}

?>
