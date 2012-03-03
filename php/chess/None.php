<?php

/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 * Description of None
 *
 * @author yoan
 */
class None extends Piece
{
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->type = "-";
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
              echo "--";
    }

    public function check($from, $to) {
        
    }

    public function move($fromx, $fromy, $tox, $toy) 
    {
        //echo "dans move";
        $chess = $_SESSION["chessboard"];
        $tab = array (0);
        $board = $chess->board;
        $board[$toy][$tox] = $chess->board[$fromy][$fromx];
        $board[$fromy][$fromx] = new None($fromx, $fromy, "", FALSE);
        
        $tab[0]=$tox;
        $tab[1]=$toy;
        $tab[2]=$board[$toy][$tox]->type;
        $tab[3]=$board[$toy][$tox]->color;
        
        
       //echo"pre". $tab[0];
        //echo "deux".$tab[1];
        //echo "piece".$tab[2];
        $chess->board = $board;
        $_SESSION["chessboard"] = $chess;
        return $tab;
    }
}

?>
