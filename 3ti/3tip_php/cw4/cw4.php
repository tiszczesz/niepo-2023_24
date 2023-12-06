<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    //  require_once "Animal.php";
    //  require_once "Dog.php";
     spl_autoload_register(function($class){
        require_once $class.".php";
    });
     $animal1 = new Animal("Pluszak","żółty");
     $animal2 = new Animal("Misiek","czarny",45);
     $d1 = new Dog(sound:"hau hao hh",name:"dog1",color:"green");
     var_dump($d1);
     echo "<div>{$animal1}</div>";
     echo "<div>{$animal2}</div>";
    ?>
</body>
</html>