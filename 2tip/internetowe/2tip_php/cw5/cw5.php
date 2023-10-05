<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ćwiczenie 5</title>

</head>
<body>
    <h1>Funkcje w PHP</h1>
    <?php
    function Message(int $count,string $text,string $color="red"):void {
        for($i=0;$i<$count;$i++){
            $border = $i%2 ? "style='border:solid 1px {$color}'":"";
            echo "<p {$border} >{$text}</p>\n";
        }
    }
    function Message2(int $count,string $text):string {
        $html = "";
        for($i=0;$i<$count;$i++){            
            $html .= "<p>{$text}</p>\n";
        }
        return $html;
    }
    function Message3():void {
        echo "<div>Hello</p>";
    }
    Message(10,"Ma być cisza jak prowadzę lekcje ... bo ....","green");
    echo Message2(10,"blalbbbb");
    Message3();
    ?>
</body>
</html>