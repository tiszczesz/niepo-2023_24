<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Losowanie prezentów</h1>
    <?php
    require "functions.php";
    $gifts = generGifts();
    echo ShowGifts($gifts);
    echo "<p>Wylosowano prezent: "
        .RandomGift($gifts)."</p>";
    ?>
</body>
</html>