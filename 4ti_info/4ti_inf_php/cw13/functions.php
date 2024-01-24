<?php

function generHobbies() : array {
    return [
        "Książki","Sport","Muzyka","Film","Taniec","Inne"
    ];    
}
function hobbiesToCheckBox(array $hobbies):string {
    return implode(array_map(function($hobby){
        return "<label><input type='checkbox' name='hobbies[]' value='$hobby'>$hobby</label>";
    },$hobbies));
}