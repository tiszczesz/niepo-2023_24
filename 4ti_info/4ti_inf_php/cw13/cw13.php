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
                <input type="submit" value="Zapisz" name="save" class="btn btn-primary offset-3 col-6">
            </div>
        </form>
        <?php
        if (isset($_POST['save'])) {
            $firstname = $_POST['firstname'];
            $lastname = $_POST['lastname'];
            $salary = $_POST['salary'];
            $manager = $_POST['manager'];

        ?>
            <div class="card">
                <h4 class="card-header">
                <?php echo $firstname.' '. $lastname;?>
                </h4>
                <div class="card-body">
                    <h5 class="card-title">
                    <?php echo $manager;?>
                    </h5>
                    <div class="card-text">
                    <?php echo "Witamy w firmie dzisiaj mamy ".date("d-m-Y")." Twoja pensja: {$salary}"?>
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