<?php
if(filter_has_var(INPUT_POST,'id')){
    //pobrac zmienne z formularza
    $nazwa = trim(filter_input(INPUT_POST,'miejsce'));
    $cena = filter_input(INPUT_POST,'cena');
    $data = filter_input(INPUT_POST,'data');
    $id = filter_input(INPUT_POST,'id');
   
    //utworzyc zapytanie update
    $sqlUpdate = "UPDATE miejsca SET nazwa='{$nazwa}', cena={$cena}, termin='{$data}' WHERE id={$id}";
    //polaczyc z mysql
    $conn = new mysqli("localhost","root",null,"3ti_2023_24_cw1");
    if($conn->connect_errno){
        die("error db!!!");
    }
   
    //wykonac zapytanie
    $result = $conn->query($sqlUpdate);
    var_dump($result);
    //zamknac polaczenia
    $conn->close();
    //ewentulanie przekierowac do głownej tabelki cw1.php
    header("Location: cw1.php");
}

