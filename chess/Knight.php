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
        $this->type = "N";
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
            echo "Nw";
        else 
            echo "Nb";
    }

   

    public function check($from, $to) 
    {
        $chessboard = ChessBoard::get_instance();
        
        if (($to[1] >=0) && ($to[1] < 8) && ($chessboard->correspondance[$to[0]] >= 0) && ($chessboard->correspondance[$to[0]] < 8))
        {
            
        }
    
    }
}

?>
