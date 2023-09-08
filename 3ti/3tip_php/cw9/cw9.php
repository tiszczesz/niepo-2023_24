<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw9.css">
    <title>Document</title>
</head>
<body>

    <div class="container">
        <nav>
            <h3>zbiór utworów</h3>
            <ul>
                <?php
                    require_once "functions.php";
                    echo GenerMenu("menu");
                ?>
            </ul>
        </nav>
        <div class="content">

        </div>
    </div>
</body>
</html>