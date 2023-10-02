<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
    <title>Document</title>
</head>

<body>
    Edycja wycieczki
    <?php
    if(filter_has_var(INPUT_GET,'id')){
        $conn = new mysqli("localhost","root",null,"3ti_2023_24_cw1");
        if($conn->connect_errno){
            //go to tabelka
        }
        $id = filter_input(INPUT_GET,'id',FILTER_VALIDATE_INT);
        $sqlQuery = "SELECT * FROM miejsca WHERE id={$id}";
        $result = $conn->query($sqlQuery);
        $row = $result->fetch_row();
        //var_dump($row);
        echo <<<HTML
        <form action="editRun.php" method="post">
                  <div class="col-6 m-2">
      
                    <input type="hidden" name="id" value="{$id}"/>
                    <label for="" class="form-label">Podaj miejsce</label>
                    <input type="text" class="form-control" name="miejsce" value="{$row[1]}" />
                  </div>
                  <div class="col-6 m-2">
                    <label for="" class="form-label">Podaj cenę</label>
                    <input
                      value="{$row[2]}"
                      type="number"
                      class="form-control"
                      name="cena"
                      step="0.01"
                      min="0"
                    />
                  </div>
                  <div class="col-6 m-2">
                    <label for="" class="form-label">Podaj cenę</label>
                    <input type="date" class="form-control" name="data" id="data" value="{$row[3]}"/>
                  </div>
                  <div class="col-6 m-2">
                      <input type="submit" class="btn btn-primary w-100" value="Zapisz">
                  </div>
                  
                </form>
HTML;
      
    }
   
    ?>
</body>

</html>