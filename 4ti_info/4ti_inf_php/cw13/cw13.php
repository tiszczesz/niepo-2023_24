<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="bootstrap/css/bootstrap.min.css">
    <title>Document</title>
</head>

<body>
    <?php
    require_once "functions.php";
    ?>
    <div class="container">
        <h1>Dane osobowe</h1>
        <form method="post" class="mt-5">
            <div class="row m-2">
                <label for="firstname" class="col-3">Podaj imię</label>
                <input class="col-6" type="text" name="firstname" id="firstname" required />
            </div>
            <div class="row m-2">
                <label for="lastname" class="col-3">Podaj nazwisko</label>
                <input class="col-6" type="text" name="lastname" id="lastname" required />
            </div>
            <div class="row m-2">
                <label for="gender" class="col-3">Wybierz płeć</label><br />

            
                <input class="col-1" type="radio" name="gender" value="k" checked/>
                <label for="gender" class="col-2">Kobieta</label>

           
                <input class="col-1" type="radio" name="gender" value="m" />
                <label for="gender" class="col-2">Mężczyzna</label>

            </div>
            <div class="row m-2">
                <label for="">Wybierz zainteresowania:</label><br />
                
                <?php
                $hobbies = generHobbies();
                echo hobbiesToCheckBox($hobbies);
                ?>
               
            </div>
            <div class="row m-2">
                <input type="submit" value="Zapisz" name="save" class="btn btn-primary offset-3 col-6">
            </div>
        </form>
        <?php
        if (isset($_POST['save'])) {
            $firstname = $_POST['firstname'];
            $lastname = $_POST['lastname'];
           // print_r($_POST['hobbies']);
            //var_dump($_POST);

        ?>
            <div class="card">
                <h4 class="card-header">
                    <?php echo $firstname . ' ' . $lastname; ?>
                </h4>
                <div class="card-body">
                    <h5 class="card-title">
                        <?php echo ($_POST['gender']==='m')? " mężczyzna" : " kobieta" ?>
                    </h5>
                    <div class="card-text">
                        <?php
                        if(isset($_POST['hobbies'])){
                            echo "<ul class='list-group'>";
                            foreach($_POST['hobbies'] as $h){
                                echo "<li class='list-group-item'>$h</li>";
                            }
                            echo "</ul>";
                        }else{
                            echo "Brak zainteresowań!!! a szkoda";
                        }
                          ?>
                    </div>
                </div>
            </div>

        <?php
        }
        ?>
    </div>
    <script src="bootstrap/js/bootstrap.bundle.js" defer></script>
</body>

</html>