<?php
function generGifts():array {
    return [
        "Konik na biegunach",
        "Konsola PS5 slim",
        "Rower elektryczny",
        "Domek dla lalek",
        "Klocki LEGO",
        "Skarpetki",
        "Mandarynki"
    ];
}
//wyswietlenie prezentów w liście numerowanej ShowGifts($gifts)
function ShowGifts(array $gifts):string {
    $html = "<ol>";
    foreach ($gifts as  $value) {
        $html .= "<li>{$value}</li>";
    }
    return $html."</ol>";
}
//wylosowanie prezentu RandomGift($gifts)
function RandomGift(array $gifts):string {
    $index = rand(0, count($gifts)-1);
    return $gifts[$index];
}