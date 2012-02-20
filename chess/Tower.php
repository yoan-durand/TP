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
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->type = "T";
    }
    
    public function move($from, $to) 
    {
        
    }
    
    public function eat ()
    {
        
    }
    
    public function display()
    {
        if ($this->color == "White")
            echo "Tw";
        else 
            echo "Tb";
    }

    public function check($to) {
        
    }
    
}

?>
