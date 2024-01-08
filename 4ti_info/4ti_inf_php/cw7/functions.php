<?php
function GetMax(array $dane):int{
    $max = -PHP_INT_MAX;
    foreach($dane as $value){
        if($value>$max) $max = $value;
    }
    return $max;
   // return max($dane);
}
function GetMin(array $dane):int{
    $min = PHP_INT_MAX;
    foreach($dane as $value){
        if($value<$min) $min = $value;
    }
    return $min;
   // return max($dane);
}
function ShowTable(array $dane):void{
    foreach($dane as $value){ 
        echo $value." ";  
    }
    echo "<br>";
}
function GenerTab(int $size):array{
    $result = [];
    for($i= 0;$i<$size;$i++){
        $result[] = rand(0,100);
    }
    return $result;
}

