<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h2>Pętla for(...;...;...){...}</h2>
    <?php
    for($i=1;$i<=6;$i++){
        echo "<h{$i}>To jest nagłówek stopnia: {$i}</h{$i}>\n";
    }
    echo "<ol>\n";
    for($i=1;$i<=10;$i++){
        echo "\t<li>Element listy nr {$i}</li>";
    }
    echo "</ol>\n"
    ?>
    <h2>Pętla while(...){....}</h2>
    <?php
    $sum = 0;
    while($sum<100){
        $randomNumber = rand(0,20);
        echo $randomNumber.' ';
        $sum += $randomNumber;
    }
    echo "<br> suma = {$sum}<br>";
    ?>
    <h2>Pętla do{...}while(...)</h2>
    <?php
     $randomNumber = 0;
     $count = 0;
     $sum=0;
     do{
        $randomNumber = rand(0,5);
        echo $randomNumber .' ';
        if($randomNumber!==0){
             $sum+=$randomNumber;
             $count++;
        }
       
     }while($randomNumber!==0);

     echo "<p>Suma liczb: {$sum}</p>";
     echo "<p>Ilość liczb: {$count}</p>";
    ?>
</body>
</html>