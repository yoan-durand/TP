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
            echo "Nw";
        else 
            echo "Nb";
    }

   

    public function check($from, $to) 
    {
        $board = $_SESSION["chessboard"];
        $cpt = 0;
        $px = $from;
        $py = $to;
        $tabres = array(0);
        
        if (($px + 1 < 8) && ($py + 2 < 8) && (($board->board[$py + 2][$px + 1]->type == "-") || ($board->board[$py + 2][$px + 1]->color != $board->board[$to][$from]->color)))
        {   
            $px++;
            $py += 2;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        if (($px - 1 >= 0) && ($py + 2 < 8) && (($board->board[$py + 2][$px - 1]->type == "-") || ($board->board[$py + 2][$px - 1]->color != $board->board[$to][$from]->color)))
        {
            $px--;
            $py += 2;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
            
        }
        
        $px = $from;
        $py = $to;
        
        if (($px - 2 >= 0) && ($py + 1 >= 0) && (($board->board[$py + 1][$px - 2]->type == "-") || ($board->board[$py + 1][$px - 2]->color != $board->board[$to][$from]->color)))
        {
            $px -= 2;
            $py++;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        if (($px - 2 >= 0) && ($py - 1 >= 0) && (($board->board[$py - 1][$px - 2]->type == "-") || ($board->board[$py - 1][$px - 2]->color != $board->board[$to][$from]->color)))
        {
            $px -= 2;
            $py--;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        
        
        $px = $from;
        $py = $to;
        
        if (($px + 1 < 8) && ($py - 2 >= 0) && (($board->board[$py - 2][$px + 1]->type == "-") || ($board->board[$py - 2][$px + 1]->color != $board->board[$to][$from]->color)))
        {
            $px++;
            $py -= 2;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        if (($px - 1 >= 0) && ($py - 2 >= 0) && (($board->board[$py - 2][$px - 1]->type == "-") || ($board->board[$py - 2][$px - 1]->color != $board->board[$to][$from]->color)))
        {
            $px--;
            $py -= 2;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        if (($px + 2 < 8) && ($py - 1 >= 0) && (($board->board[$py - 1][$px + 2]->type == "-") || ($board->board[$py - 1][$px + 2]->color != $board->board[$to][$from]->color)))
        {
            $px += 2;
            $py--;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        $px = $from;
        $py = $to;
        
        if (($px + 2 < 8) && ($py + 1 < 8) && (($board->board[$py + 1][$px + 2]->type == "-") ||($board->board[$py + 1][$px + 2]->color != $board->board[$to][$from]->color)))
        {
            $px += 2;
            $py++;
            $tabres[$cpt] = $px;
            $cpt++;
            $tabres[$cpt] = $py;
            $cpt++;
        }
        
        return $tabres;
    }

    public function move($fromx, $fromy, $tox, $toy) 
        {
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
