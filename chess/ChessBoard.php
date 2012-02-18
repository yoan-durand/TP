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
        for ($i = 0; $i < $length; $i++)
        {
            $line[$i] = new Piece();
        }

        for ($i = 0; $i < $height; $i++)
        {
            $board[$i] = $line;
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
