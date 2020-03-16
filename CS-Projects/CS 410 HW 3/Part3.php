<?php
if (isset($_POST["submit"])){
    $car = $_POST["car"];
    $days = $_POST["days"];
    $insurance = $_POST["insurance"];
    $cost = 0;
    if ($car == "0"){
        if ($insurance == "0"){
            $cost += 30 * $days + 15 * $days;
        }

        else{
            $cost += 30 * $days;
        }
    }

    elseif ($car == "1"){
        if ($insurance == "0"){
            $cost += 40 * $days + 15 * $days;
        }

        else{
            $cost += 40 * $days;
        }
    }

    elseif (car.value == "2"){
        if($insurance == "0"){
            $cost += 50 * $days + 15 * $days;
        }

        else{
            $cost += 50 * $days;
        }
    }

    echo "Cost- " . "$" . $cost;
}
?>