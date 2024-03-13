<?php
include_once "Product.php";
function GetProduct(string $line): Product|null
{
    $data = explode(';', $line);
    if (count($data) !== 5) {
        return null;
    }
    return new Product($data);
}
function FromFile(string $path = "dane.txt"):array {
    return file($path,FILE_IGNORE_NEW_LINES);
}
function GetProducts(string $path="dane.txt") : array {
    $lines = FromFile($path);
    $products = [];
    foreach ($lines as $line) {
        $product = GetProduct($line);
        if ($product !== null) {
            $products[] = $product;
        }
    }
    return $products;
}
