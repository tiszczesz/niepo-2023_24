<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw6.css">
    <title>Document</title>
</head>

<body>
   
    <?php
    require_once "functions.php";

    $recipes = fromJson("dane.json");
    foreach($recipes as $recipe){
        echo toCard($recipe);
    }
    //var_dump($recipes);
    ?>
    
</body>

</html>