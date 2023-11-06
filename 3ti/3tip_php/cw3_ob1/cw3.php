<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    class Example{
        //pola
        private string $info;
        //metdody
        public function __construct(string $info = "domyślna")
        {
            $this->setInfo($info);
        }
        public function __toString():string
        {
            return "<div>To jest obiekt Example z wartością: {$this->getInfo()}"
                    ." o długości: {$this->getInfoLength()}</div>";
        }
        public function getInfo() : string {
            return mb_strtoupper($this->info);
        }
        public function setInfo(string $value):void{
            $this->info = trim($value);
        }
        public function getInfoLength(){
            return mb_strlen($this->info);
        }
    }
    /**
     * Napisz formularz zgłoszeniowy: imie nazwisko wiek(number) klasa(select)
     * Dane z formularza do obietku klasy Student
     * Wyswitl informacje o studencie używając metody __toString()
     * echo ($student1)
     */
    $ex1 = new Example("  ala ma łódkę  ");
    $ex2 = new Example();
    echo $ex1;
    echo $ex2;
    $ex1->setInfo("To jest nowe żółte info");
    echo $ex1->getInfo();
    ?>
</body>
</html>