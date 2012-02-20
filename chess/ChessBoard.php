<?php
/**
 * Description of ChessBoard
 *
 * @author durand_y
 */
error_reporting (E_ALL);
ini_set ("display_errors", 1);

class ChessBoard
{
    //attributs
    private $instance;
    private $board;
    private $length = 8;
    private $height = 8;
    private $correspondance;
    
    //auto-load 
    
   
    function __autoload($class_name) 
            {
               include $class_name . '.php';
            }
            
     //constructor
    public function  __construct()
    {
         $this->correspondance["a"] = 0;
         $this->correspondance["b"] = 1;
         $this->correspondance["c"] = 2;
         $this->correspondance["d"] = 3;
         $this->correspondance["e"] = 4; 
         $this->correspondance["f"] = 5;
         $this->correspondance["g"] = 6;
         $this->correspondance["h"] = 7;
            
        for ($i = 0; $i < $this->height; $i++)
        {
           
            for ($j = 0; $j < $this->length; $j++)
            {
                switch ($i)
                {
                    case 0:
                        switch ($j)
                        {
                            case 0:
                                $this->board[$i][$j] = new Tower($i, $j, "White", TRUE);
                                break;
                            case 1:
                                $this->board[$i][$j] = new Knight($i, $j, "White", TRUE);
                                break;
                            case 2:
                                $this->board[$i][$j] = new Bishop($i, $j, "White", TRUE);
                                break;
                            case 3:
                                $this->board[$i][$j] = new Queen($i, $j, "White", TRUE);
                                break;
                            case 4:
                                $this->board[$i][$j] = new King($i, $j, "White", TRUE);
                                break;
                            case 5:
                                $this->board[$i][$j] = new Bishop($i, $j, "White", TRUE);
                                break;
                            case 6:
                                $this->board[$i][$j] = new Knight($i, $j, "White", TRUE);
                                break;
                            case 7:
                                $this->board[$i][$j] = new Tower($i, $j, "White", TRUE);
                                break;
                        }
                        break;
                    case 1:
                        $this->board[$i][$j] = new Pawn ($i, $j, "White", true);
                        break;
                    case 6:
                        $this->board[$i][$j] = new Pawn($i, $j, "Black", TRUE);
                        break;
                    case 7:
                        switch ($j)
                        {
                            case 0:
                                $this->board[$i][$j] = new Tower($i, $j, "Black", TRUE);
                                break;
                            case 1:
                                $this->board[$i][$j] = new Knight($i, $j, "Black", TRUE);
                                break;
                            case 2:
                                $this->board[$i][$j] = new Bishop($i, $j, "Black", TRUE);
                                break;
                            case 3:
                                $this->board[$i][$j] = new Queen($i, $j, "Black", TRUE);
                                break;
                            case 4:
                                $this->board[$i][$j] = new King($i, $j, "Black", TRUE);
                                break;
                            case 5:
                                $this->board[$i][$j] = new Bishop($i, $j, "Black", TRUE);
                                break;
                            case 6:
                                $this->board[$i][$j] = new Knight($i, $j, "Black", TRUE);
                                break;
                            case 7:
                                $this->board[$i][$j] = new Tower($i, $j, "Black", TRUE);
                                break;
                        }
			break;
                        default :
                            $this->board[$i][$j] = new None($i, $j, "", FALSE);
                        break;
                    echo "fin moncul";
                }
            }
        }
    }
    
    public function is_valid ($from, $to)
    {
        if ($this->board[$this->correspondance[$from[0]]][$from[1]] != "-")
        {
            if ($this->board[$this->correspondance[$from[0]]][$from[1]]->check ($to) == true)
            {
                return true;
            }
            else
                return false;
        }
        return false;
    }
    
    
    public function display ()
    {
        for ($i = 0; $i < $this->height; $i++)
        {
            echo "|" ;
            for ($j = 0; $j < $this->length; $j++)
            {
                echo $this->board[$i][$j]->display()."|";
            }
            echo "<br/>";
        }
    }

    public static function get_instance ()
    {
        if (isset (self::$instance))
        {
            return (self::$instance);
        }
        return new ChessBoard ();
    }
}
?>
