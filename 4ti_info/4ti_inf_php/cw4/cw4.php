<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h2>Instrulcje sterujące</h2>
    <?php
    $a = 23;
    $b = 10;
    echo "<p>{$a} + {$b} = " . ($a + $b) . "</p>";
    echo "<p>{$a} - {$b} = " . ($a - $b) . "</p>";
    echo "<p>{$a} * {$b} = " . ($a * $b) . "</p>";
    if ($b === 0) { //instrukcja warunkowa
        echo "<p>{$a} / {$b} = BRAK WYNIKU</p>";
    } else {
        echo "<p>{$a} / {$b} = " . ($a / $b) . "</p>";
    }
    if (0 === '0') echo "<div>0 ==='0'</div>";
    else echo "<div>0 nie równe '0'</div>";
    if (0 =='0') echo "<div>0 =='0'</div>";
    else echo "<div>0 nie równe '0'</div>";
    $napis = "aladd";
    $styl = mb_strlen($napis)>5 
                    ? "style='color:red' "
                    :"style='color:green'";
    echo "<div {$styl}>{$napis}</div>";  
    $students = [
        
    ]              
    ?>
</body>

</html>