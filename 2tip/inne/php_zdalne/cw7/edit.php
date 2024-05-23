<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    if (isset($_GET['id'])) {
        $id = intval($_GET['id']);
        if ($id == 0) {
            //przekierowanie do Tabelki
        }
        $conn = new mysqli("localhost", "root", null, "2ti_inne_cw1");
        if ($conn->connect_errno != 0) die("error DB!!!!");
        $conn->set_charset("utf8");
        $sql = "SELECT id,firstname,lastname,date FROM users WHERE id={$id}";
        $result = $conn->query($sql);
        $user = $result->fetch_row();
        //var_dump($user);
        $conn->close();
        echo <<<TEXT
        <form action="editResult.php" method="post">
        <input type='hidden' name='id' value='{$user[0]}'>
        <div class="line">
            <input type="text" name="firstname" id="firstname" required value='{$user[1]}'>
        </div>
        <div class="line">
            <input type="text" name="lastname" id="lastname" required value='{$user[2]}'>
        </div>
        <div class="line">
            <input type="date" name="date" id="date" required value='{$user[3]}'>
        </div>
        <div class="line">
            <input type="submit" value="Zapisz"> 
            <input type="reset" value="Wyczyść">
        </div>
    </form>




TEXT;
    }

    ?>
</body>

</html>