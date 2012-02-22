<?php
/**
 * Description of Piece
 *
 * @author durand_y
 */
 abstract class Piece
{
    protected $color;
    protected $pos_x;
    protected $pos_y;
    protected $alive;
    protected $type;
    


    /*
     * Color move change the color of the board when a piece is selected
     * eat take a piece from the opponent
     */
    abstract public function move ($from, $to);
    abstract public function check ($from,$to);
    abstract public function eat ();
    
    //display the piece
    
    abstract public function display ();
}
?>
