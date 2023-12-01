<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h2>Typ całkowity int</h2>
    <?php
    $a = 12;
    var_dump($a);
    $a = "ala ma kota";
    var_dump($a);
    $a = 011; //8-kowy
    $a = 0b11111111; //binarny
    $a = 0x12a; // 16-kowy
    var_dump($a);
    ?>
    <h3>Typ zmiennoprzecinkowy</h3>
    <?php
    $b = 12.0;
    var_dump($b);
    $b = 3e2;
    var_dump($b);
    ?>
    <h2>Typ string</h2>
    <?php
    $imie = "Anna";
    var_dump($imie);
    $nazwisko = 'Nowak';
    var_dump($nazwisko);
    echo $imie . ' ' . $nazwisko . '<br>';
    ?>
    <h2>Typ bool</h2>
    <?php
    $isCorrect = true;
    var_dump($isCorrect);
    var_dump(!$isCorrect);
    ?>
</body>

</html>