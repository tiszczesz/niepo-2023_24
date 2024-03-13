<?php

class Product{
    public int $Id;
    public string $Name;
    public string $Description;
    public float $Price;
    public string $Date;
    public function __toString(): string {
        return "{$this->Id};{$this->Name};{$this->Price};"
              ."{$this->Description};{$this->Date}";
    }
    //konstruktor metoda tworzaca obiekt
    public function __construct(array $data) {
        $this->Id = (int)$data[0];
        $this->Name = $data[1];
        $this->Price =(float)$data[2];
        $this->Description = $data[3];
        $this->Date = $data[4];
    }

}