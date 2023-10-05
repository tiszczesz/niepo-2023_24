<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ćwiczenie 4</title>
</head>

<body>
    <h1>Pętle c.d.</h1>
    <h3>Pętla while(...){....}</h3>
    <?php
    $sum = 0;
    //define("RANGE",100);
    const RANGE = 100;
    while ($sum < RANGE) {
        $random = rand(0,20);
        $sum += $random;
        $char = $sum < RANGE ? ' + ': ' = ';
        echo $random . $char;        
    }
    echo " {$sum}<br />";
    ?>
</body>

</html>