<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    include "functions.php";
    if (isset($_POST['a'])) {
        $a = $_POST['a'];
        $b = $_POST['b'];
       // var_dump($a, $b);
       $result = NWD($a,$b);
       echo "<div>NWD({$a},{$b}) = ".NWDRec($a,$b)."</div>";
    }

    ?>
</body>

</html>