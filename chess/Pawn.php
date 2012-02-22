<?php

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
        
    public function move($from, $to) 
    {
        $chessboard = ChessBoard::get_instance();
        unset($chessboard->board[$chessboard->correspondance[$to[0]][$to[1]]]);
        $chessboard->board[$chessboard->correspondance[$to[0]][$to[1]]] = new Pawn($chessboard->correspondance[$to[0]], $to[1], $chessboard->board[$chessboard->correspondance[$from[0]][$from[1]]]->color , TRUE);
        unset($chessboard->board[$chessboard->correspondance[$from[0]][$from[1]]]);
        $chessboard->board[$chessboard->correspondance[$from[0]][$from[1]]] = new None($chessboard->correspondance[$from[0]], $from[1], "", FALSE);
        
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
        $chessboard = ChessBoard::get_instance();
        if (($chessboard->correspondance[$to[0]] >= 0) && ($chessboard->correspondance[$to[0]] < 8) && ($to[1] >= 0) && ($to[1] < 8))
        {
            if ($this->first == 0)
            {
                $this->first++;
                if ((($to[1] == ($this->pos_y + 2)) && ($chessboard->correspondance[$to[0]] == $this->pos_x)) && ($chessboard->board[$this->pos_y + 2][$this->pos_x]->type == "-"))
                {
                return true;
                }
                elseif ((($to[1] == ($this->pos_y + 1)) && ($chessboard->correspondance[$to[0]] == $this->pos_x)) && ($chessboard->board[$this->pos_y + 1][$this->pos_x]->type == "-"))
                    return true;
                elseif (($to[1] == ($this->pos_y + 1) && (($chessboard->correspondance[$to[0]] == $this->pos_x + 1) ||
                                                            (($chessboard->correspondance[$to[0]] == $this->pos_x - 1)) ))) 
                {
                    if (($chessboard->board[$this->pos_y + 1][$this->pos_x + 1]->type != "-") || ($chessboard->board[$this->pos_y + 1][$this->pos_x - 1]->type != "-"))
                    {
                        return true;
                    }
                    else
                        return false;

                }
            }
            else
            {
                if (($to[1] == ($this->pos_y + 1) && ($chessboard->correspondance[$to[0]] == $this->pos_x))&& ($chessboard->board[$this->pos_y + 1][$this->pos_x]->type == "-") ) 
                {
                    return true;
                }
                elseif (($to[1] == ($this->pos_y + 1) && (($chessboard->correspondance[$to[0]] == $this->pos_x + 1) ||
                                                            (($chessboard->correspondance[$to[0]] == $this->pos_x - 1)) ))) 
                {
                    if (($chessboard->board[$this->pos_y + 1][$this->pos_x + 1]->type != "-") || ($chessboard->board[$this->pos_y + 1][$this->pos_x - 1]->type != "-"))
                    {
                        return true;
                    }
                    else
                        return false;
                }

            }
        }
        else
        {
            return false;
        }
    }
}

?>
