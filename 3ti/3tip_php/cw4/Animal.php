<?php
class Animal
{
    public function __construct(
        private string $secret="",
        protected string $name = "noname",
        protected string $color = "biały",
        protected int $weight =  5,
        protected int $age = 2
    ) {
        echo "to konstruktor Animal.....<br>";
        $this->setSecret($secret);
    }
    public function __toString()
    {
        return "Nazwa: {$this->name} Kolor: {$this->color}"
            . " masa: {$this->weight}kg wiek: {$this->age} ";
    }
    public function setSecret(string $value)
    {
        $this->secret = mb_strtoupper(trim($value));
    }
}
