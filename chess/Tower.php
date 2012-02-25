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
    
    //getter setter
    
    public function __get($name) 
    {
        return $this->$name;
    }

    public function __set($name, $value) 
    {
        $this->$name = $value;
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

    public function check($from,$to)         
    {
        $board = $_SESSION["chessboard"];
        $cpt = 0;
        $px = $from;
        $py = $to;
        $tabres;
        
        while (($py < 8) && ($board->board[$py][$px]->type == "-"))
        {
            $py++;
            $tabres[$cpt] = $from;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
            
        }
        $py = $to;
        while (($py >= 0) && ($board->board[$py][$px]->type == "-"))
        {
            $py--;
            $tabres[$cpt] = $from;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
            
        }
        
        while (($px < 8) && ($board->board[$py][$px]->type == "-"))
        {
            $px++;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $to;
            $cpt++;
            
        }
        $px = $from;
        while (($px >= 0) && ($board->board[$py][$px]->type == "-"))
        {
            $px--;
            $tabres[$cpt] = $x;
            $cpt++;
            $tabres[$cpt] = $to;
            $cpt++;
        }
        return $tabres;
    }
    
    
    
}

?>
