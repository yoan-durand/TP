<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of King
 *
 * @author durand_y
 */
class King extends Piece
{
    private $has_moved;
    
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;   
        $this->type = "K";
        $this->has_moved = false;
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
     
    
    
    public function eat ()
    {
        
    }
    
    public function display()
    {
        if ($this->color == "White")
            echo "Kw";
        else 
            echo "Kb";
    }

    public function check($from, $to) 
    {
        $board = $_SESSION["chessboard"];
        $cpt = 0;
        $px = $from;
        $py = $to;
        $tabres = array(0);
        
        if ($px + 1 < 8)
        {
            $tabres[$cpt] = $px + 1;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        if ($px - 1 >= 0)
        {
            $tabres[$cpt] = $px - 1;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        if ($py + 1 < 8)
        {
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py + 1;
            $cpt++;
        }
        if ($px - 1 >= 0)
        {
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py - 1;
            $cpt++;
        }
            
        if ($px + 1 < 8 && $py + 1 < 8)
        {
            $tabres[$cpt] = $px + 1;
            $cpt++;
            $tabres[$cpt] = $py + 1;
            $cpt++;
        }
        
        if ($px - 1 < 8 && $py + 1 < 8)
        {
            $tabres[$cpt] = $px - 1;
            $cpt++;
            $tabres[$cpt] = $py + 1;
            $cpt++;
        }
        
        if ($px - 1 < 8 && $py - 1 < 8)
        {
            $tabres[$cpt] = $px - 1;
            $cpt++;
            $tabres[$cpt] = $py - 1;
            $cpt++;
        }
        
        if ($px + 1 < 8 && $py - 1 < 8)
        {
            $tabres[$cpt] = $px + 1;
            $cpt++;
            $tabres[$cpt] = $py - 1;
            $cpt++;
        }
        return $tabres; 
    }

    public function move($fromx, $fromy, $tox, $toy) {
        
    }
}

?>
