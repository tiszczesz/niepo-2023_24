<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    function Wizytowka():void {                 //definicja funkcji składa sie z nagłówka 
        echo "<div>Hello from function</div>"; //i ciała
    }
    function Wizytowka2(string  $name):void{
       // echo sqrt($name);
        echo "<div>Hello from function with {$name}</div>";
       // return;
    }
    function Wizytowka3(string $firstname,string $lastname):string {
        return "<div>Witaj {$firstname} {$lastname}</div>";
    }
    ?>
    <h2>Funkcje w php</h2>

    <?php
    Wizytowka();//wywolanie czyli uruchomienie funkcji
    Wizytowka2("Roman");
    Wizytowka2("Tomasz");
    Wizytowka2("Anna");
   // Wizytowka2(345);
    echo  Wizytowka3("Eryk","Meryk");
    
    ?>
</body>

</html>