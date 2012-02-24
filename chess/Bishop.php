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
    
    public function move($from, $to) 
    {
        
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
        $chessboard = ChessBoard::get_instance();
       
        if (($chessboard->correspondance[$to[0]] >= 0)&& ($chessboard->correspondance[$to[0]] < 8) && ($to[1] >= 0) && ($to[1] < 8))
        {
            $p1 = $chessboard->correspondance[$from[0]];
            $p2 = $from[1];
            if ((($chessboard->correspondance[$to[0]] > $chessboard->correspondance[$from[0]]) && ($to[1] > $from[1])))
            {  
               while (($chessboard[$p2][$p1]->type == "-") && (($p1 < $chessboard->correspondance[$to[0]]) && ($p2 < $to[1])) )
               {
                   $p1++;
                   $p2++;
               }
               if (($p1 == $chessboard->correspondance[$to[0]])&&($p2 == $to[1]))
               {
                  return true; 
               }
               else
                   return false;
            }
            elseif ((($chessboard->correspondance[$to[0]] > $chessboard->correspondance[$from[0]]) && ($to[1] < $from[1])))
            {
               while (($chessboard[$p2][$p1]->type == "-") && (($p1 < $chessboard->correspondance[$to[0]]) && ($p2 > $to[1])) )
               {
                   $p1++;
                   $p2--;
               }
               if (($p1 == $chessboard->correspondance[$to[0]])&&($p2 == $to[1]))
               {
                  return true; 
               }
               else
                   return false; 
            }
            elseif ((($chessboard->correspondance[$to[0]] < $chessboard->correspondance[$from[0]]) && ($to[1] > $from[1])))
            {
               while (($chessboard[$p2][$p1]->type == "-") && (($p1 > $chessboard->correspondance[$to[0]]) && ($p2 < $to[1])) )
               {
                   $p1--;
                   $p2++;
               }
               if (($p1 == $chessboard->correspondance[$to[0]])&&($p2 == $to[1]))
               {
                  return true; 
               }
               else
                   return false;
            }elseif ((($chessboard->correspondance[$to[0]] < $chessboard->correspondance[$from[0]]) && ($to[1] < $from[1])))
            {
               while (($chessboard[$p2][$p1]->type == "-") && (($p1 > $chessboard->correspondance[$to[0]]) && ($p2 > $to[1])) )
               {
                   $p1--;
                   $p2--;
               }
               if (($p1 == $chessboard->correspondance[$to[0]])&&($p2 == $to[1]))
               {
                  return true; 
               }
               else
                   return false;
            }
            else
                return FALSE;
        }
    }
}

?>
