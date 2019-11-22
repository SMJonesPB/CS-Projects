<?php
if (isset($_POST["submit"])){
    $q = $_POST["quiz"];
    $a = $_POST["hw"];
    $m = $_POST["midterm"];
    $f = $_POST["final"];
    $grade = $q * .15 + $a * .4 + $m * .2 + $f * .25;
    echo "Grade- " . $grade . "% ";
    if ($grade < 60){
        echo "F";
    }

    elseif ($grade >= 60 and $grade < 63) {
        echo "D-";
    }

    elseif ($grade >= 63 and $grade < 68) {
        echo "D";
    }

    elseif ($grade >= 68 and $grade < 70) {
        echo "D+";
    }

    elseif ($grade >= 70 and $grade < 73){
        echo "C-";
    }

    elseif ($grade >= 73 and $grade < 78){
        echo "C";
    }

    elseif ($grade >= 78 and $grade < 80){
        echo "C+";
    }

    elseif ($grade >= 80 and $grade < 83){
        echo "B-";
    }

    elseif ($grade >= 83 and $grade <88){
        echo "B";
    }

    elseif ($grade >= 88 and $grade < 90){
        echo "B+";
    }

    elseif ($grade >= 90 and $grade < 93){
        echo "A-";
    }

    elseif ($grade >= 93 and $grade < 98){
        echo "A";
    }

    elseif ($grade >= 98){
        echo "A+";
    }
}
?>