<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw18.css">
    <title>Document</title>
</head>

<body>
    <h1>Strona z przepisami świątecznymi</h1>
    <!-- <pre> -->
    <?php
    include_once "functions.php";
    $recipes = getAllRecipes("dane/dane.json");
    foreach($recipes as $recipe){
        echo Card($recipe);
    }
    //var_dump($recipes);
    ?>
    <!-- </pre> -->

</body>

</html>