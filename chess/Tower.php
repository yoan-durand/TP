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
    private $has_moved;
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->type = "T";
        $this->has_moved = FALSE;
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
        $tabres = array(0);
        
        if ($py + 1 < 8)
        {
            while (($py < 8) && ($board->board[$py + 1][$from]->type == "-"))
            {
               
                $py++;
                $tabres[$cpt] = $from;
                $cpt++;
                $tabres[$cpt] = $py;
                $cpt++;

            }
        }
        $py = $to;
        if ($py - 1 >= 0)
        {
            while (($py - 1 >= 0) && ($board->board[$py - 1][$from]->type == "-"))
            {
                $py--;
                $tabres[$cpt] = $from;
                $cpt++;
                $tabres[$cpt] = $py;
                $cpt++;

            }
        }
        $px = $from;
        if ($px + 1 < 8)
        {    
            while (($px + 1 < 8) && ($board->board[$to][$px + 1]->type == "-"))
            {
                $px++;
                $tabres[$cpt] = $px;
                $cpt++;
                $tabres[$cpt] = $to;
                $cpt++;

            }
        }
        $px = $from;
        if ($px - 1 > -1)     
        {
            while (($px - 1 >= 0) && ($board->board[$to][$px - 1]->type == "-"))
            {
                $px--;
                $tabres[$cpt] = $px;
                $cpt++;
                $tabres[$cpt] = $to;
                $cpt++;
            }
        }
        return $tabres;
    }

    public function move($fromx, $fromy, $tox, $toy) {
        $chess = $_SESSION["chessboard"];
        $tab = array (0);
        $board = $chess->board;
        $board[$toy][$tox] = $chess->board[$fromy][$fromx];
        $board[$fromy][$fromx] = new None($fromy, $fromx, "", FALSE);
        
        $tab[0]=$tox;
        $tab[1]=$toy;
        $tab[2]=$board[$toy][$tox]->type;
        $chess->board = $board;
        $_SESSION["chessboard"] = $chess;
        return $tab;
    }
    
    
    
}

?>
