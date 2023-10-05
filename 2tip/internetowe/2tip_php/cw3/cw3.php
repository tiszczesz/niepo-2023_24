<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="cw3.css">
</head>

<body>
    <h3>Pętla for(...;...;..){......}</h3>
    <?php
    for ($i = 1; $i <= 6; $i++) {
        echo "<h{$i}>Nagłówek {$i}</h{$i}>\n";
    }
    //lista numerowana 10 elementowa napis "element listy nr. 1
    echo "<ol>\n";
    for ($i = 1; $i <= 10; $i++) {
        echo "\t<li>Elemnt listy nr. {$i}</li>\n";
    }
    echo "</ol>\n";
    ?>
    <h3>Zagnieżdżanie pętli</h3>
    <?php
        $cols = 20; 
        $rows = 18;
        //tabliczka mnożenia 30x40 html table
        echo "<table>\n";
        for($i=0; $i<$rows;$i++){
            
            echo "\t<tr>\n";
            for($j=0;$j<$cols;$j++){
                $gray = ($i==0 || $j==0 )? "class='gray'":"";
                $red = ((($i+1) * ($j+1))%7 == 0)  ? "style='color:red'":"";
                echo "\t\t<td {$gray} $red>".(($i+1)*($j+1))."</td>\n";
            }
            echo "\t</tr>\n";
        }
        echo "</table>\n";
    ?>
</body>

</html>