<?php


class Dog extends Animal{
    public function __construct(private string $sound="hhh",string $name,string $color) {
        parent::__construct(name:$name,color:$color);
        echo "to konstruktor Dog.....<br>";
    }
    public function __toString()
    {
        $result = parent::__toString();
        return $result." daj głos hau hau..";
    }
   
}