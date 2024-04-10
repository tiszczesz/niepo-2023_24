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
    $conn = new mysqli("localhost", "root", null, "2ti_inne_cw1");
    if ($conn->connect_errno != 0) die("DB ERROR");
    $conn->set_charset("utf8"); //ustawienie kodowanie utf8 dla mysql i php
    //$conn->query("SET NAMES utf8");
    var_dump($conn);
    $sql = "SELECT * FROM users";
    $result = $conn->query($sql);
    var_dump($result);
    //$dane = $result->fetch_all();
    //var_dump($dane);
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
    ?>
    </pre>
</body>

</html>