<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw19.css">
    <title>Document</title>
   
</head>
<body>
    <h1>Tabelka z użytkownikami</h1>
    <table>
    <tr>
        <th>Imię</th>
        <th>Nazwisko</th>
        <th>Klasa</th>
    </tr>
    <?php
    $conn = new mysqli("localhost","root",null,"4ti_inf_2024_cw1");
    if($conn->connect_errno!=0) die("Błąd połączenia");
    $conn->set_charset("utf8");
    $sql = "SELECT firstname,lastname,division FROM students";
    $result = $conn->query($sql); //wykonanie zapytania do bazy
    while($row=$result->fetch_assoc()){
        echo "<tr>\n";
        echo "<td>{$row['firstname']}</td><td>{$row['lastname']}</td><td>{$row['division']}</td>\n";
        echo "</tr>\n";
    }
    $conn->close();
    ?>
    </table>

    <div>
        <a href="insert.html">dodaj użytkownika</a>
    </div>
</body>
</html>