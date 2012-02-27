<?php
    header("Content-Type: application/json");
    session_start();
    
    
    
    $x = 0;
    $y = 0;
   
    function __autoload($class_name) 
    {
        include $class_name . '.php';
    }
    
    print_r($_SESSION["ancient"]);
    
    $x = $_GET["mx"];
    $y = $_GET["my"];
   // echo "x".$x."<br/>";
  //  echo "y ". $y."<br/>";
    $test = $_SESSION["chessboard"];
    $tab = array(0);
    //echo "session player".$_SESSION["player"];
    
    
    if (($_SESSION["player"] % 2 == 0))
    {
        if ($test->board[$y][$x]->type != "-")
        {
            $tab = $test->board[$y][$x]->check($x, $y);
            print_r($tab);
        }
        elseif ($test->board[$y][$x]->type == "-" || $test->board[$y][$x]->color == "Black")
        {
          echo "dans else";
          // echo sizeof($_SESSION["ancient"]);
          // echo "ancient=>".$_SESSION["ancient"];
            for ($i = 0; $i < sizeof($_SESSION["ancient"]); $i++)
            {
          echo "dans le for";
                if ($i % 2 == 0)
                {
                  //  echo "ancient[i]".($_SESSION["ancient"][$i]);
                    echo "x".$x;
                    if ($_SESSION["ancient"][$i] == $x)
                    {
                        if ($_SESSION["ancient"][$i + 1] == $y)
                        {
                            echo "deuxieme if";
                            $tab = $test->board[$y][$x]->move($_SESSION["ax"], $_SESSION["ay"],$x, $y);
                            echo "tab";
                            print_r($tab);
                            $_SESSION["player"]++;
                            break;
                        }
                    }
                }
                
            }
        }
    }
    elseif (($_SESSION["player"] % 2 == 1))
    {
        //echo "elseif black:;";
        if ($test->board[$y][$x]->type != "-")
            {
        //    echo "check b;ack";
                $tab = $test->board[$y][$x]->check($x, $y);
            }
        elseif ($test->board[$y][$x]->type == "-" || $test->board[$y][$x]->color == "White")
            {
                for ($i = 0; $i < sizeof($_SESSION["ancient"]); $i++)
                {
      //              echo "fort black";
                    if ($i % 2 == 0)
                    {
                        if ($_SESSION["ancient"][$i] == $x)
                        {
    //                        echo "if x black";
                            if ($_SESSION["ancient"][$i + 1] == $y)
                            {
  //                              echo "if y black";
                                $tab = $test->board[$y][$x]->move($_SESSION["ax"], $_SESSION["ay"], $x, $y);
                                $_SESSION["player"]++;
                                print_r($tab);
                                break;
                            }
                        }
                    }
                
                }
            }
    }
    
    $ancient = $tab;
    $_SESSION["ancient"] = $ancient;
    $_SESSION["ax"] = $x;
    $_SESSION["ay"] = $y;
   // $test->display();
    $my_encode_array = json_encode($tab);

    echo $my_encode_array;
      //  $_SESSION["chessboard"]->display ();
?>
