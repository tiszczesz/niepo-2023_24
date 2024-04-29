<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    //var_dump($_POST);
    if(isset($_POST['firstname'])){
        $firstname = trim($_POST['firstname']);
        $lastname = trim($_POST['lastname']);
        $division = trim($_POST['division']);
        if($firstname!=='' && $lastname!=='' && $division!==''){
            $conn = new mysqli("localhost","root",null,"4ti_inf_2024_cw1");
            if($conn->connect_errno!=0) die("Błąd bazy danych");
            $sql = "INSERT INTO students(firstname,lastname,division)".
                   " VALUES('{$firstname}','{$lastname}','{$division}')";
           // echo $sql;
           $conn->query($sql);
           $conn->close();
           echo "<p>Zapisano do bazy danych: {$firstname}, {$lastname}, {$division}</p>";
        }
    }
    ?>
    <div>
        <a href="cw19_1.php">Powrót do tabelki</a>
    </div>
</body>
</html>