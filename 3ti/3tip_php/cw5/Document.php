<?php
abstract class Document{
    public function __construct(protected string $name,protected float $size)
    { }
    abstract public function getInfo():string;   
}