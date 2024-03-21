<?php
//var_dump($_POST);
include_once "functions.php";
if(isset($_POST['save'])){
    $name = trim($_POST['name']);
    $description = trim($_POST['description']);
    $price = $_POST['price'];
    $date = $_POST['date'];
    $products = GetProducts("dane.txt");
    $maxId = getMaxId($products);
    $f = fopen("dane.txt",'a');
    if($f){
        fwrite($f,($maxId+1).';'.$name.';'.$price.';'
               .$description.';'.$date.PHP_EOL);
        fclose($f);
    }
    header("Location: cw17.php");
    
}

/*
'name' => string 'sads dad' (length=8)
  'description' => string 'asdsadas' (length=8)
  'price' => string '56' (length=2)
  'date' => string '2024-03-11' (length=10)
  'save' => string 'Zapisz' (length=6)



*/