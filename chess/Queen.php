<?php


/**
 * Description of Queen
 *
 * @author durand_y
 */
class Queen extends Piece
{
    public function __construct($x, $y, $color, $alive) 
    {
        $this->pos_x = $y;
        $this->pos_y = $x;
        $this->color = $color;
        $this->alive = $alive;
        $this->type = "Q";
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
            echo "Qw";
        else 
            echo "Qb";
    }

    public function check($from, $to)
    {
        $board = $_SESSION["chessboard"];
        $cpt = 0;
        $px = $from;
        $py = $to;
        $tabres = array(0);
        
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
        
        $px = $from;
        $py = $to;
        while (($px < 8)&&($py < 8) && ($board->board[$py][$px]->type == "-"))
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
        
        while (($px >= 0)&&($py < 8) && ($board->board[$py][$px]->type == "-"))
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
        
        while (($px >= 0)&&($py >= 0) && ($board->board[$py][$px]->type == "-"))
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
        
        while (($px < 8)&&($py >= 0) && ($board->board[$py][$px]->type == "-"))
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
