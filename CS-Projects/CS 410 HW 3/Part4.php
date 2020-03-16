<?php
if (isset($_POST["submit"])){
    $price = $_POST["price"];
    $down = $_POST["down"];
    $apr = $_POST["apr"];
    $years = $_POST["years"];
    $i = $apr / 1200.0;
    $n = $years * 12;
    $monthly = (($price - $down) * $i * (1 + $i) ** $n) / ((1 + $i) ** $n - 1);
    echo "Monthly payment- " . "$" . $monthly;
}
?>