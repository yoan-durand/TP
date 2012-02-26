<?php
    header("Content-Type: application/json");
    session_start();
    
    
    
    $x = 0;
    $y = 0;
   
    function __autoload($class_name) 
    {
        include $class_name . '.php';
    }
    
    $x = $_GET["mx"];
    $y = $_GET["my"];
    $test = $_SESSION["chessboard"];
    if (($_SESSION["player"] % 2 == 0))
    {
        if ($test->board[$y][$x]->type != "-" && $test->board[$y][$x]->color == "White")
        {
            $tab = $test->board[$y][$x]->check($x, $y);
        }
        elseif ($test->board[$y][$x]->type == "-" || $test->board[$y][$x]->color == "Black")
        {
           
            for ($i = 0; $i < sizeof($_SESSION["ancient"]); $i++)
            {
                if ($i % 2 == 0)
                {
                    if ($_SESSION["ancient"][$i] == $x)
                    {
                        if ($_SESSION["ancient"][$i + 1] == $y)
                        {
                            $tab = $test->board[$x][$y]->move($_SESSION["ax"], $_SESSION["ay"],$x, $y);
                            $_SESSION["player"]++;
                        }
                    }
                }
                
            }
        }
    }
    elseif (($_SESSION["player"] % 2 == 1))
    {
        if ($test->board[$y][$x]->type != "-" && $test->board[$y][$x]->color == "Black")
            {
                $tab = $test->board[$y][$x]->check($x, $y);
            }
        elseif ($test->board[$y][$x]->type == "-" || $test->board[$y][$x]->color == "White")
            {
                for ($i = 0; $i < sizeof($_SESSION["ancient"]); $i++)
            {
                if ($i % 2 == 0)
                {
                    if ($_SESSION["ancient"][$i] == $x)
                    {
                        if ($_SESSION["ancient"][$i + 1] == $y)
                        {
                            $tab = $test->board[$x][$y]->move($_SESSION["ax"], $_SESSION["ay"], $x, $y);
                            $_SESSION["player"]++;
                        }
                    }
                }
                
            }
            }
    }
    else
        $tab = null;
    $ancient = $tab;
    $_SESSION["ancient"] = $ancient;
    $_SESSION["ax"] = $x;
    $_SESSION["ay"] = $y;
   // $test->display();
    echo $_SESSION["ax"];
    echo $_SESSION["ay"];
    echo $_SESSION["player"];
    $my_encode_array = json_encode($tab);
    
    echo $my_encode_array;
    
?>
