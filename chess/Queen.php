<?php


/**
 * Description of Queen
 *
 * @author durand_y
 */
class Queen extends Piece
{
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->type = "Q";
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
            echo "Qw";
        else 
            echo "Qb";
    }

    public function check($to) {
        
    }
}

?>
