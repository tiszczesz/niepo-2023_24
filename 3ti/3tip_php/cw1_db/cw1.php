<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
    <title>Document</title>
</head>

<body>
    <?php
    $conn = new mysqli("localhost", "root", null, "3ti_2023_24_cw1");
    if ($conn->connect_errno) {
        echo "ok brak połączenia : {$conn->connect_error}<br />";
        die("ERROR DB");
    }
    echo "ok połączono<br />";
    $result = $conn->query("SELECT * FROM miejsca");

    //var_dump($result->fetch_array());
    // var_dump($result->fetch_assoc());   
    // var_dump($result->fetch_row());
    // var_dump($result->fetch_object());
    // var_dump($result->fetch_all());
    echo '<table class="table table-striped">';
    echo "<tr> <th>Lp</th><th>Miasto</th><th>Cena</th><th>Termin</th></tr><br />";
    $lp=1;
    while($row = $result->fetch_array()){
        echo "<tr><td>{$lp}</td><td>{$row[1]}</td><td class='text-end'>{$row[2]}</td> <td>{$row[3]}</td> </tr>";
        $lp++;
    }
    echo '</table>';
    $result2 = $conn->query("SELECT min(cena) FROM miejsca");
    var_dump($result2->fetch_row());
    $conn->close();

    ?>
</body>

</html>