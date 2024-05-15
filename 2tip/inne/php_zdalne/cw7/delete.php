<?php

if(filter_has_var(INPUT_GET,'id')){
    $id = filter_input(INPUT_GET,'id');
    //echo "id = {$id}";
    $sql = "DELETE FROM users WHERE id = {$id}";
    $conn = new mysqli("localhost","root",null,"2ti_inne_cw1");
    if($conn->connect_errno!=0) die("ERROR DB");
    $conn->query($sql);
    $conn->close();
}
header("Location: cw7-1.php");