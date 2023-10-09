<?php
require_once "functions.php";
if (filter_has_var(INPUT_POST, 'firstname')) {
    $firstname = trim(filter_input(INPUT_POST, 'firstname'));
    $lastname = trim(filter_input(INPUT_POST, 'lastname'));
    $division_id = intval(trim(filter_input(INPUT_POST, 'division', FILTER_VALIDATE_INT)));
    //walidacja danych
    //wywołanie funkcji insertStudent()
    if ($firstname != '' && $lastname != '' && $division_id > 0) {
        if (insertStudent([$firstname, $lastname, $division_id])) {
            //echo "<p>Udany zapis do DB!!!</p>";
            header("Location: cw2.php");
        }
        /// echo "<p>ERROR zapisu do DB!!!</p>"; 
    } else {
        header("Location: cw2_add.php");
    }
    //var_dump($_POST); 

}
