<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw9.css">
    <title>Document</title>
</head>
<body>
 
    
    <?php
    if(isset($_POST['submit'])){
        var_dump($_POST);
        $firstname = trim($_POST['firstname']);
        $lastname = trim($_POST['lastname']);
        $date = $_POST['dateBirth'];
        if(!empty($firstname) && !empty($lastname) && !empty($date)){
          echo <<<TEXT
          <div class="info">
          <p>Imie: {$firstname}</p>
          <p>Nazwisko: {$lastname}</p>
          <p>Data urodzenia: {$date}</p>
      </div>
TEXT;          
        }
    }else{
        var_dump($_POST);
        echo "<p>BRAK DANYCH</p>";
    }
    
    ?>
    
</body>
</html>