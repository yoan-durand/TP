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
        $this->type = "P";
    }
        
    public function move($from, $to) 
    {
        if ($this->first == 0)
        {
            
        }
        
    }
    
    public function eat ()
    {
        
    }
    
    public function display()
    {
        if ($this->color == "White")
            echo "Pw";
        else 
            echo "Pb";
    }
}

?>
