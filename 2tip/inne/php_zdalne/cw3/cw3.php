<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <pre>
    <?php
    $text1 = "ala ma kota";
    $text2 = "żółta";
    echo "<div>Napis: {$text1} ma długość: " . strlen($text1) . "</div>";
    echo "<div>Napis: {$text2} ma długość: " . mb_strlen($text2) . "</div>";
    for ($i = 0; $i < strlen($text1); $i++) {
        echo $text1[$i] . ' ';
    }
    function my_split(string $text,string $char): string {
        //musi być return
    }

    echo "<hr>";
    for ($i = 0; $i < mb_strlen($text2); $i++) {
        // echo $text2[$i].' ';
        echo mb_substr($text2, $i, 1) . ' ';
    }
    var_dump(str_split($text1));
    var_dump(mb_str_split($text2));
    echo "<p>".my_split($text2,'-')."</p>"; // --> ż-ó-ł-t-a
    ?>
    </pre>
</body>

</html>