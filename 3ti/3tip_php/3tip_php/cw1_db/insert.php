<?php
if(filter_has_var(INPUT_POST,'miejsce')){
    $miejsce = trim(filter_input(INPUT_POST,'miejsce'));
    $cena = trim(filter_input(INPUT_POST,'cena'));
    $data = trim(filter_input(INPUT_POST,'data'));
    var_dump($miejsce,$cena,$data);
    if($miejsce=='' || $cena=='' || $data==''){
        header("Location: cw1_insert.html");
    }
    $conn = new mysqli("localhost","root",null,"3ti_2023_24_cw1");
    if($conn->connect_errno){
        die("error db!!!");
    }
    $sqlQuery = "INSERT INTO miejsca(nazwa,cena,termin) VALUES('{$miejsce}',{$cena},'{$data}')";
    //echo $sqlQuery;
    $result = $conn->query($sqlQuery);
    $conn->close();
    if($result){
         header("Location: cw1.php");
    }else{
        header("Location: cw1_insert.html");
    };
    
   
}