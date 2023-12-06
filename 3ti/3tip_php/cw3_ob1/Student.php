<?php

class Student
{
    // private int $a;
    // private string $name;

    public function __construct(  public int $a, private string $name ) {
    }
    // public function __construct(int $a, string $name)
    // {
    //     $this->a = $a;
    //     $this->name = $name;
    // }
    public function __toString(): string
    {
        return "<p>a = {$this->a} name = {$this->name}</p>";
    }
   
}