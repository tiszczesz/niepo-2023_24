<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        p{font-size: 1.2em;color: blue;font-weight: bold;}
    </style>
</head>

<body>
    <h1>Pierwsza częśc skryptu</h1>
    <?php
    //php 1
    $a = "Roman";//definicja zmiennej a 
    echo "<p>Ala ma kota {$a}</p>"; //przetwarzane przez php
    echo '<p>Ala ma kota {$a}</p>'; //tylko wyswietlane
    print "<div>to jest z Print()</div>";//inny sposób wyswietlania
    ?>

    <h1>Kolejna częśc skryptu</h1>
    <?php
    //php 2
    //$a typu string
    $liczba = 123.78; //typ zmiennej float
    $liczba2 = 12;   //typ zmiennej int
    var_dump($a); //sprawdza zawartosc i typ zmiennej
    //var_dump($b);//niezdefiniowana zmienna
    var_dump($liczba);
    var_dump($liczba2);
    //dopisac do skryptu 3 zmienne imie ,nazwisko wiek
    // i wyswietlic jako div w ramce z padding i background-color
    ?>
</body>

</html>