<?php
var_dump($_GET);
if($_GET['id']){
    $conn = new mysqli("localhost","root",null,'4ti_inf_2024_cw1');
    if($conn->connect_errno!=0) die("Błąd połączenia");
    //$conn->set_charset("utf8");
    $id = intval($_GET['id']);
    $sql = "DELETE FROM students WHERE id={$id}";
    $conn->query($sql);
    $conn->close();
    echo "<div>Usunięto rekord o id: {$id} z bazy danych</div>";
    echo "<div><a href='cw19_1.php'>Do tabelki</a>";
}
