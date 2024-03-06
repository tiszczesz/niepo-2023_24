<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $f = fopen("dane.txt","r");
    if($f){
        while($line = fgets($f)){
            echo "<div>{$line}</div>";
        }
        fclose($f);
    }
    $dane = ["ala ma kota","inny tekst","jeszczejedna linijka tekstu","fghfhfg hfg hfghfhfhf","to działa"];
    //fopen   'w'
    $f = fopen("wynik.txt",'w');

    //fwrite(...)) w pętli foreach($dane as $lie){ .....}
    foreach($dane as $line){
        fwrite($f,$line."\n");
    }
    //fclose(..)
    fclose($f);
    ?>
</body>
</html>