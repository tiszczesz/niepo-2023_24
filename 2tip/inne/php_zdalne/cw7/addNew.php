<?php
var_dump($_POST);
if(filter_has_var(INPUT_POST,'firstname')){ // if(isset($_POST['firstname']))
    $firstname = trim(filter_input(INPUT_POST,'firstname'));
    $lastname = trim(filter_input(INPUT_POST,'lastname'));
    $date = trim(filter_input(INPUT_POST,'date'));
    $conn = new mysqli("localhost", "root", null, "2ti_inne_cw1");
    if ($conn->connect_errno != 0) die("Błąd połączenia z bazą!!!");
    $conn->set_charset("utf8");
    $sql = "INSERT INTO users(firstname,lastname,date) VALUES('{$firstname}','{$lastname}','{$date}')";
    //echo $sql;
    $conn->query($sql);
    header("Location: cw7-1.php");
}else{
    header("Location: addNew.html");
}
