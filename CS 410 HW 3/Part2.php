<?php
if (isset($_POST["submit"])){
    $hours = $_POST["hours"];
    $cost = 0;
    if ($hours <= 3){
        $cost += 5;
    }

    elseif ($hours >= 4){
        $cost += 5 + ($hours - 3) * 1.5;
        if ($cost > 18){
            $cost = 18;
        }
    }

    echo "Cost- " . "$" . $cost;
}
?>