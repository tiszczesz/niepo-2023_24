<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    echo date("Y-m-d") . "<br>";
    echo date("\d\z\i\s\i\a\j\: d/m/Y") . "<br>";
    echo "dzisiaj: " . date("d/m/Y") . "<br>";
    echo date("d-m-Y", time() + 3600 * 24 * 3) . "<br>";
    echo date("d-m-Y", mktime(0, 0, 0, 6, 12, 2025)) . "<br>";
    echo date("d-m-Y", strtotime('2023-12-09')) . "<br>";
    echo date("d-m-Y", 24 * 3600) . "<br>";
    echo "<hr>";
    $dd = new DateTime();
    $old = new DateTime("2024-02-12");
    var_dump($dd);
    echo $dd->format("d-m-Y") . "<br>";
    echo $old->format("d-m-Y") . "<br>";
    $interval = $dd->diff($old);
    var_dump($interval);
    echo $interval->m . "<br>";
    echo $interval->days. "<br>";

    ?>
</body>

</html>