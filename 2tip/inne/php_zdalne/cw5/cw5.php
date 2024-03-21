<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    const FILENAME = "dane.txt";
    if (!file_exists(FILENAME)) die("BRAK Pliku");
    $f = fopen(FILENAME, 'r');
    //var_dump($f);
    if ($f) {
        while ($line = fgets($f)) {
            echo "<p>{$line}</p>";
        }
        fclose($f);
    }
    ?>
    <hr>
    <?php
    $dane = ["ala ma kota", "sadad asad a", "wad a daa a", "dsf sds fsfs s "];
    $f = fopen("result.txt", 'w');
    if ($f) {
        foreach ($dane as $line) {
            fwrite($f, $line.PHP_EOL);
        }
        fclose($f);
        //file() a jaką funkcją zapisać do pliku???
    }

    ?>
</body>

</html>