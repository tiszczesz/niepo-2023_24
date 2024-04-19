<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
   <h1>Lista userów</h1>
   <div>
    <a href="cw19_1.php">Tabelka użytkowników</a>
   </div>
    <?php
    $conn = new mysqli("localhost", "root", null, "4ti_inf_2024_cw1");
    $conn->set_charset("utf8"); //ustawienie kodowania połączenia
    if ($conn->connect_errno !== 0)
        die("Błąd połączenia: " . $conn->connect_errno); //zakonczenie skryptu gdy bład połaczenia z DB
    $sqlQuery = "SELECT firstname,lastname,division FROM students ";
    $result = $conn->query($sqlQuery);
    var_dump($result);
    //$data = $result->fetch_all();    
    //$row = $result->fetch_row();
   // $row = $result->fetch_array();
   // var_dump($row);
   // $row = $result->fetch_assoc();
   // var_dump($row);
   echo gettype(13.0);
    echo "<ul>\n";
    while($row = $result->fetch_row()){
        echo "<li>Imię: {$row[0]}, nazwisko: {$row[1]}, klasa: {$row[2]}</li>\n";
    }
    echo "</ul>\n";
    $conn->close();//!!!!!!!
    ?>
  
</body>

</html>