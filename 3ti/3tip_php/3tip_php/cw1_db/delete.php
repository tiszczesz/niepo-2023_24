<?php
//if(isset($_GET['id'])){}
if(filter_has_var(INPUT_GET,'id')){
    echo "usuwanie";
    $id = filter_input(INPUT_GET,'id',FILTER_VALIDATE_INT);
    $conn = new mysqli("localhost","root",null,"3ti_2023_24_cw1");
    if(!$conn->connect_errno){
       // header("Location: cw1.php");
    }
    $sqlQuery = "DELETE FROM miejsca WHERE id={$id}";
    echo $sqlQuery;
    $result = $conn->query($sqlQuery);
    var_dump($result);
    $conn->close();
    header("Location: cw1.php");
}
