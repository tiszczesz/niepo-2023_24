<?php
class DocText extends Document
{
    public function __construct(
        public array $content = [],
        protected string $name,
        protected float $size
    ) {
        parent::__construct($name, $size);
    }
    public function getInfo(): string
    {
        return <<<HTML
        <h2>Informacje o dokumencie tekstowy</h2>
        <h4>Nazwa: {$this->name} </h4>
        <div class="content">
            {$this->getContentToString()}
        </div>
HTML;
    }
    public function getContentToString():string {
        $html ="";
        foreach($this->content as $line){
            $html .= "<div>$line</div>";
        }
        return $html;
    }   
}
