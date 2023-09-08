<?php
function GenerMenu(string $dirname):string {
    $html = "";
    $result = scandir($dirname);
    var_dump($result);
    $firstLines = GetAllFirstLines($result,$dirname);
    var_dump($firstLines);
    return $html;
}
function GetAllFirstLines(array $files,string $dirname):array{
    $result = [];
    foreach($files as $f){
        if($f!=='.' && $f!=='..')
            $result[] = file($dirname.'/'.$f,FILE_IGNORE_NEW_LINES)[0]; 
    }

    return $result;
}