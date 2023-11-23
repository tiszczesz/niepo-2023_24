<?php

class Student{
    public function __construct(
        public int $a,
        private string $name
        ){ }
    
    public function __toString():string{
        return "<p>a = {$this->a} name = {$this->name}</p>";
    }
    
}