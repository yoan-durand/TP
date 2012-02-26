<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of Bishop
 *
 * @author durand_y
 */
class Bishop extends Piece
{
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->type = "B";
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
            echo "Bw";
        else 
            echo "Bb";
    }

    public function check($from,$to) 
    {
        $chess= $_SESSION["chessboard"];
        
        $px = $from;
        $py = $to;
        $cpt = 0;
        
        $tabres = array(0);
        
        while (($px < 8)&&($py < 8) && ($chess->board[$py][$px]->type == "-"))
        {
            $px++;
            $py++;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        while (($px >= 0)&&($py < 8) && ($chess->board[$py][$px]->type == "-"))
        {
            $px--;
            $py++;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        while (($px >= 0)&&($py >= 0) && ($chess->board[$py][$px]->type == "-"))
        {
            $px--;
            $py--;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        while (($px < 8)&&($py >= 0) && ($chess->board[$py][$px]->type == "-"))
        {
            $px++;
            $py--;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
       
        return $tabres;
        
    }

    public function move($fromx, $fromy, $tox, $toy) {
        
    }
}

?>
