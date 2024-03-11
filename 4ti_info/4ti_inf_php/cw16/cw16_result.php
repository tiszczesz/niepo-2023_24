<?php

if(isset($_POST['imie'])){
    $f = fopen("dane.txt",'a');
    fwrite($f,$_POST['imie'].'|'.$_POST['nazwisko'].'|'.$_POST['wiek']."\n");
    fclose($f);
}