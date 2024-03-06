<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $length = strlen("Ryba");
    var_dump($length);
    $length2 = mb_strlen("łódka");
    var_dump($length2);
    $napis = "żółta łódź";
    $napis2 = "ala ma kota";
    echo "<hr>";
    for($i=0;$i<strlen($napis);$i++){
        echo $napis[$i].' ';
    }
    echo "<hr>";
    //echo "<p>".explode('',$napis)."</p>"   
    for($i=0;$i<mb_strlen($napis);$i++){
        echo mb_substr($napis,$i,1).'-';
    }
    print_r (mb_str_split($napis));
    echo strrev($napis2);
    ?>
</body>
</html>