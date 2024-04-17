<?php
if(filter_has_var(INPUT_POST,'firstname')){ //if(isset($_POST['firstname]))
    $firstname = filter_input(INPUT_POST,'firstname');
    $lastname = filter_input(INPUT_POST,'lastname');
    $date = intval(filter_input(INPUT_POST,'date'));
    $conn = new mysqli("localhost", "root", null, "2ti_inne_cw1");
    $sql = "INSERT INTO users(firstname,lastname,date)"
         ." VALUES('{$firstname}','{$lastname}','{$date}')";
    $result = $conn->query($sql);
    echo "zapisano do bazy";
}
