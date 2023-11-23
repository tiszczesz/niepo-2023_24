<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h2>Definicja tablicy</h2>
    <pre>
    <?php
        $t1 = [3,7,9,'ala',true,'inny napis'];
       // $t2 = array(5,6,7,7);
        //var_dump($t2);
        print_r($t1);
        var_dump($t1);
        $t1[] = "nowy na koncu";  //push
       // array_push($t1,"hhhhh"); //push2
        print_r($t1);
        $t1[3] = "to na miejsce trzecie";
        $t1[23] = "gggggggg";
        unset($t1[1]);
        print_r($t1);
     
        // for($i=0;$i<count($t1);$i++){
        //     echo $t1[$i].' ';
        // }
        foreach($t1 as $elm){
            echo $elm.' ';
        }
        $result = array_shift($t1);
        print_r($t1);
        print_r($result);
        array_unshift($t1,"cos nowego na początek");
        print_r($t1);
        print_r(array_keys($t1));
        print_r(array_values($t1));
    ?>
    </pre>
</body>
</html>