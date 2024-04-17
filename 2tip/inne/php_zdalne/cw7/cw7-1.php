<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">

    <title>Document</title>
</head>

<body>
    <h1>Lista użytkowników</h1>
    <?php
    //todo tabelka html po pobraniu z bazy danych jak w ćwiczeniu cw7.php
    // ide na chwile na dół
    //dobra jestem jakby co
    $conn = new mysqli("localhost", "root", null, "2ti_inne_cw1");
    if ($conn->connect_errno != 0) die("DB ERROR");
    $conn->set_charset("utf8"); //ustawienie kodowanie utf8 dla mysql i php
    //$conn->query("SET NAMES utf8");
    //var_dump($conn);
    $sql = "SELECT * FROM users";
    $result = $conn->query($sql);
    $users = $result->fetch_all();
    echo "<table class='table table-striped'>";
    echo "<thead>";
    echo "<tr>";
    echo "<th>Imię</th><th>Nazwisko</th><th>Wiek</th>";
    //var_dump($users);

    $conn->close();
    ?>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>

</html>