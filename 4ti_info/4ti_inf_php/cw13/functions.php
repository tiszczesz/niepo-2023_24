<?php

function generHobbies() : array {
    return [
        "Książki","Sport","Muzyka","Film","Taniec","Inne"
    ];    
}
function hobbiesToCheckBox(array $hobbies):string {
    // return implode(array_map(function($hobby){
    //     return "<label class='offset-3'><input type='checkbox' name='hobbies[]' value='$hobby'>$hobby</label>";
    // },$hobbies));
    $html = '';
    foreach($hobbies as $h){
        $html .= "<label class='offset-3'><input type='checkbox' name='hobbies[]' value='$h'>$h</label>";
    }
    return $html;
}