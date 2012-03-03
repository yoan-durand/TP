<?php
//session_start();
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
            echo "Pw";
        else 
            echo "Pb";
    }

    public function check($from,$to) 
    {
        
        $_SESSION["pawn"] = $this;
        $chessboard = $_SESSION["chessboard"];
        $cpt = 0;
        $array = array (0);
        if ($_SESSION["player"] % 2 == 0)
        {
            if ($this->first == 0 )
            {
                $this->first++;
                if (((($to+1) < 8) && ($from - 1 >= 0)) && $chessboard->board[$to+1][$from-1]->type != "-" && ($chessboard->board[$to + 1][$from - 1]->color != $chessboard->board[$to][$from]->color))
                {
                $array[$cpt] = $from - 1;
                $cpt++;
                    $array[$cpt] = $to + 1;
                    $cpt++;
                }
                if (((($to+1) < 8) && ($from < 8)) &&$chessboard->board[$to+1][$from]->type == "-")
                {
                    $array[$cpt] = $from;
                    $cpt++;
                    $array[$cpt] = $to + 1;
                    $cpt++;
                }
                if (((($to+1) < 8) && ($to+2 < 8) && ($from < 8)) &&$chessboard->board[$to+2][$from]->type == "-")
                {
                    $array[$cpt] = $from;
                    $cpt++;
                    $array[$cpt] = $to + 2;
                    $cpt++;
                }
                if (((($to+1) < 8) && ($from + 1 < 8)) && $chessboard->board[$to+1][$from + 1]->type != "-" && ($chessboard->board[$to + 1][$from + 1]->color != $chessboard->board[$to][$from]->color))
                {
                    $array[$cpt] = $from + 1;
                    $cpt++;
                    $array[$cpt] = $to + 1;
                    $cpt++;
                }

            }
            else
                {
                    if (((($to+1) < 8) && ($from - 1 >= 0)) && $chessboard->board[$to+1][$from-1]->type != "-" && ($chessboard->board[$to + 1][$from - 1]->color != $chessboard->board[$to][$from]->color))
                    {
                        $array[$cpt] = $from - 1;
                        $cpt++;
                        $array[$cpt] = $to + 1;
                        $cpt++;
                    }
                    if (((($to+1) < 8) && ($from< 8)) &&$chessboard->board[$to+1][$from]->type == "-")
                    {
                        $array[$cpt] = $from;
                        $cpt++;
                        $array[$cpt] = $to + 1;
                        $cpt++;
                    }
                    if (((($to+1) < 8) && ($from + 1 < 8)) && $chessboard->board[$to+1][$from + 1]->type != "-" && ($chessboard->board[$to + 1][$from + 1]->color != $chessboard->board[$to][$from]->color))
                    {
                        $array[$cpt] = $from + 1;
                        $cpt++;
                        $array[$cpt] = $to + 1;
                        $cpt++;
                    }
                }

                return ($array);
        }
        else
        {
            if ($this->first == 0 )
            {
                $this->first++;
                if (((($to-1) >= 0) && ($from - 1 >= 0)) && $chessboard->board[$to-1][$from-1]->type != "-" && ($chessboard->board[$to - 1][$from - 1]->color != $chessboard->board[$to][$from]->color))
                {
                $array[$cpt] = $from - 1;
                $cpt++;
                    $array[$cpt] = $to - 1;
                    $cpt++;
                }
                if (((($to-1) >= 0) && ($from < 8)) &&$chessboard->board[$to-1][$from]->type == "-")
                {
                    $array[$cpt] = $from;
                    $cpt++;
                    $array[$cpt] = $to - 1;
                    $cpt++;
                }
                if (((($to-1) >= 0) && ($to-2 >= 0) && ($from < 8)) &&$chessboard->board[$to-2][$from]->type == "-")
                {
                    $array[$cpt] = $from;
                    $cpt++;
                    $array[$cpt] = $to - 2;
                    $cpt++;
                }
                if (((($to-1) >= 0) && ($from + 1 < 8)) && $chessboard->board[$to - 1][$from + 1]->type != "-" && ($chessboard->board[$to - 1][$from + 1]->color != $chessboard->board[$to][$from]->color))
                {
                    $array[$cpt] = $from + 1;
                    $cpt++;
                    $array[$cpt] = $to - 1;
                    $cpt++;
                }

            }
            else
                {
                   if (((($to-1) >= 0) && ($from - 1 >= 0)) && $chessboard->board[$to-1][$from-1]->type != "-" && ($chessboard->board[$to - 1][$from - 1]->color != $chessboard->board[$to][$from]->color))
                    {
                        $array[$cpt] = $from - 1;
                        $cpt++;
                        $array[$cpt] = $to - 1;
                        $cpt++;
                    }
                    if (((($to-1) >= 0) && ($from < 8)) &&$chessboard->board[$to-1][$from]->type == "-")
                    {
                        $array[$cpt] = $from;
                        $cpt++;
                        $array[$cpt] = $to - 1;
                        $cpt++;
                    }
                    if (((($to-1) >= 0) && ($from + 1 < 8)) && $chessboard->board[$to - 1][$from + 1]->type != "-" && ($chessboard->board[$to - 1][$from + 1]->color != $chessboard->board[$to][$from]->color))
                    {
                        $array[$cpt] = $from + 1;
                        $cpt++;
                        $array[$cpt] = $to - 1;
                        $cpt++;
                    }
                }

                return ($array);
        }
    }

    public function move($fromx, $fromy, $tox, $toy) 
    {
        echo "dans move";
        $chess = $_SESSION["chessboard"];
        $tab = array (0);
        $board = $chess->board;
        $board[$toy][$tox] = $chess->board[$fromy][$fromx];
        $board[$fromy][$fromx] = new None($fromx, $fromy, "", FALSE);
        
        $tab[0]=$tox;
        $tab[1]=$toy;
        $tab[2]=$board[$toy][$tox]->type;
        
        
        echo"pre". $tab[0];
        echo "deux".$tab[1];
        echo "piece".$tab[2];
        $chess->board = $board;
        $_SESSION["chessboard"] = $chess;
        return $tab;
    }
}

?>
