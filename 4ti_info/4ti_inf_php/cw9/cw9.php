<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw9.css">
    <title>Document</title>
</head>
<body>
    <?php
    require "functions.php";
    $workers = getWorkers();
    echo ShowWorkers($workers);
    ?>
</body>
</html>