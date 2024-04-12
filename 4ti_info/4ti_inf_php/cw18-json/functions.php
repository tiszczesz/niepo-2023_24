<?php
function getAllRecipes(string $filename):array {
    $strings = file_get_contents($filename);
    $dane = json_decode($strings, true);
    return $dane;
}
function Card(array $recipe):string {
    $html = "<div class='card'>";
    $html .= "<h1>{$recipe['Name']}</h1>";
    $html .= "</div>";
    return $html;
}