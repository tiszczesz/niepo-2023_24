<?php
if(filter_has_var(INPUT_POST,'firstname')){ // if(isset($_POST['firstname']))
    $id=trim(filter_input(INPUT_POST,'id'));
    $firstname = trim(filter_input(INPUT_POST,'firstname'));
    $lastname = trim(filter_input(INPUT_POST,'lastname'));
    $date = trim(filter_input(INPUT_POST,'date'));
    $conn = new mysqli("localhost", "root", null, "2ti_inne_cw1");
    if ($conn->connect_errno != 0) die("Błąd połączenia z bazą!!!");
    $conn->set_charset("utf8");
    $sql = "UPDATE users SET firstname='{$firstname}',lastname='{$lastname}',date='{$date}' WHERE id={$id}";
   // echo $sql;
    $conn->query($sql);
    header("Location: cw7-1.php");
}else{
    header("Location: addNew.html");
}