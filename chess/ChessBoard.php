<?php
/**
 * Description of ChessBoard
 *
 * @author durand_y
 */

class ChessBoard
{
    private $instance;
    private $board;
    private $length = 8;
    private $height = 8;

    public function  __construct()
    {
        for ($i = 0; $i < $this->height; $i++)
        {
            for ($j = 0; $j < $this->length; $j++)
            {
                switch ($i)
                {
                    case 2:
                        $line[$j] = new Pawn ($i, $j, "White");
                        break;
                    case 7:
                        $line[$i] = new Pawn($i, $j, "Black");
                }
            }
            $this->board[$i] = $line;
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
