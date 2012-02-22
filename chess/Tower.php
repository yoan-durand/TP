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
        $chessboard = ChessBoard::get_instance();
       
        if (($chessboard->correspondance[$to[0]] >= 0)&& ($chessboard->correspondance[$to[0]] < 8) && ($to[1] >= 0) && ($to[1] < 8))
        {
            if (($to[0] == $from[0]) && ($to[1] != $from[1]))
            {
                $p = $this->pos_x;
                if ($to[1] > $from[1])
                {
                    while ($chessboard[$p][$chessboard->correspondance[$from[0]]]->type == "-" && ($p < $to[1]))
                    {
                        $p++;
                    }
                    if ($p == $to[1])
                    {
                        return true;
                    }
                    else 
                        return FALSE;
                }
                else
                {
                    while ($chessboard[$p][$chessboard->correspondance[$from[0]]]->type == "-" && ($p > $to[1]))
                    {
                        $p--;
                    }
                    if ($p == $to[1])
                    {
                        return true;
                    }
                    else 
                        return FALSE;
                }
            }
            elseif (($chessboard->correspondance[$to[0]] != $chessboard->correspondance[$from[0]]) && ($to[1] == $from[1]))
            {
                $p = $this->pos_x;
                if ($chessboard->correspondance[$to[0]] > $chessboard->correspondance[$from[0]])
                {
                    while ($chessboard[$to[1]][$p]->type == "-" && ($p < $chessboard->correspondance[$to[0]]))
                    {
                        $p++;
                    }
                    if ($p == $to[1])
                    {
                        return true;
                    }
                    else 
                        return FALSE;
                }
                else
                {
                    while ($chessboard[$to[1]][$p]->type == "-" && ($p > $chessboard->correspondance[$to[0]]))
                    {
                        $p++;
                    }
                    if ($p == $to[1])
                    {
                        return true;
                    }
                    else 
                        return FALSE;
                }
            }
            else
                return false;
        }
    }
    
}

?>
