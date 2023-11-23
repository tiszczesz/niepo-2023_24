<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h3>Tablice superglobalne w php</h3>
    <form method="get">
        <input type="text" name="imie">
        <input type="text" name="nazwisko">
        <select name="opcja" id="opcja">
            <option value="opcja 1">opcja 1</option>
            <option value="opcja 2">opcja 2</option>
            <option value="opcja 3">opcja 3</option>
        </select>
        <input type="submit" value="Wyślij">
    </form>
    <pre>
    <?php
        var_dump($_FILES);
       // var_dump($_SERVER);
        var_dump($_GET);
       // echo "<p>imie = {$_GET['imie']}</p>";
       // echo "<p>{$_GET['a']} + {$_GET['b']} = ".($_GET['a']+$_GET['b'])."</p>";

    ?>
    </pre>
</body>

</html>