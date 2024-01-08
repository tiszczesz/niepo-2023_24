<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    include "functions.php";
    $numbers = GenerTab(20);
    echo "<p>Maksymalna wartość w tablicy: <br>";
    ShowTable($numbers);
    echo "<br> wynosi: ".GetMax($numbers)."</p>";
    echo "<p>Minimalna wartość w tablicy: ";   
    echo " wynosi: ".GetMin($numbers)."</p>";
    ?>
</body>
</html>