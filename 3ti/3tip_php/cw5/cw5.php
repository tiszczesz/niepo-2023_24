<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw5.css">
    <title>Document</title>
</head>

<body>
    <?php
    //  spl_autoload_register(function($class){
    //     require_once $class.".php";
    // });
    spl_autoload_register(fn ($class) => require_once $class . ".php");
    $dt = new DocText(
        content: ["ala ma kota", "lorem ipsum", "kolejny wiersz"],
        name: "dokument 1",
        size: 450
    );
    $di = new DocImage(heigh:300,width:400,genre:"jpg",name:"Obrazek 1",size:1000);
    //var_dump($dt);
    //var_dump($di);
    echo $dt->getInfo();
    ?>
</body>

</html>