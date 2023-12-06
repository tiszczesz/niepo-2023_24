<?php
class DocImage extends Document
{
    public function __construct(
        private int $heigh,
        private int $width,
        private string $genre,
        protected string $name,
        protected float $size
    ) {
        parent::__construct($name, $size);
    }
    
    public function getHeigh(): int
    {
        return  $this->heigh;
    }
    
    public function getWidth(): int
    {
        return $this->width;
    }
    public function getGenre(): string
    {
        return $this->genre;
    }
    public function getInfo(): string
    {
        return "";
    }
}
