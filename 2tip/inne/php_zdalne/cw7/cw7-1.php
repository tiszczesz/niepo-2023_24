<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw7.css">
    <title>Document</title>
</head>

<body>
    <h1>Lista użytkowników</h1>
    <div>
        <a href="addNew.html">dodaj nowego użytkownika</a>
    </div>
    <table>
        <tr>
            <th>Imię</th>
            <th>Nazwisko</th>
            <th>Data rejestracji</th>
            <th>Dodatkowe operacje</th>
        </tr>
        <?php
        $conn = new mysqli("localhost", "root", null, "2ti_inne_cw1");
        if ($conn->connect_errno != 0) die("Błąd połączenia z bazą!!!");
        $conn->set_charset("utf8");
        $sql = "SELECT id,firstname,lastname,date FROM users";
        $result = $conn->query($sql);
        while ($row = $result->fetch_assoc()) {
            echo "<tr>\n";
            echo "\t<td>{$row['firstname']}</td>\n";
            echo "\t<td>{$row['lastname']}</td>\n";
            echo "\t<td>{$row['date']}</td>\n";
            echo "\t<td><a href='delete.php?id={$row['id']}'>Usuń</a> <a href='edit.php?id={$row['id']}'>Edytuj</a></td>\n";
            echo "</tr>\n";
        }
        //CRUD
        $conn->close();
        ?>
    </table>
</body>

</html>