<?php
if (isset($_POST["submit"])){
    $employee = $_POST["employee"];
    $hours = $_POST["hours"];
    $salary = 0;
    if ($employee == "1"){
        $salary += 35 * $hours;
    }

    elseif ($employee == "2"){
        $salary += 50 * $hours;
    }

    elseif ($employee == "3"){
        $salary += 65 * $hours;
    }

    echo "Salary- " . "$" . $salary;
}
?>