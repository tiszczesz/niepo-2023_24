<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ćwiczenie 2</title>
</head>
<body>
    <h1>Ćwiczenie 2</h1>
    <h4>Definiowanie zmiennych</h4>
    <?php
    $a = '12';
    var_dump($a);
    $a = 12;
    var_dump($a);
    echo "<p>a = {$a}</p>";
    $b = 12;
    var_dump($b);
    echo "<p>b = {$b}</p>";
    echo "<p>{$a} + {$b} = ".($a+$b)."</p>\n";
    echo "<p>{$a} - {$b} = ".($a-$b)."</p>\n";
    echo "<p>{$a} * {$b} = ".($a*$b)."</p>\n";
    if($b!=0){
        echo "<p>{$a} / {$b} = ".($a/$b)."</p>\n";
    }else{
        echo "<p>{$a} / {$b} = BRAK WYNIKU(dzielenie przez zero!!!)</p>\n";
    }
    $c=true;
    var_dump($c);
    $dane = "16";
    if($dane%2==0){
        echo "<p style='color:green;'>{$dane}</p>";
    }else{
        echo "<p style='color:red;'>{$dane}</p>";
    }
    
    echo <<<   TEXT
 <div>sadsad</div>
    <div>asds
        tyrtytrytrad</div>
    <div>asdsadasdsa</div>
TEXT;
    ?>
   
</body>
</html>