<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <pre>
    <?php
    $conn = new mysqli("localhost", "root", null, "4ti_inf_2024_cw1");
    $conn->set_charset("utf8"); //ustawienie kodowania połączenia
    if ($conn->connect_errno !== 0)
        die("Błąd połączenia: " . $conn->connect_errno); //zakonczenie skryptu gdy bład połaczenia z DB
    $sqlQuery = "SELECT firstname,lastname,division FROM students ";
    $result = $conn->query($sqlQuery);
    var_dump($result);
    //$data = $result->fetch_all();
    //fetch_row() kilka razy 
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);
    $row = $result->fetch_row();
    var_dump($row);

    $conn->close();//!!!!!!!
    ?>
    </pre>
</body>

</html>