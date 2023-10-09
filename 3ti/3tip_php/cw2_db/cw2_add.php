<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="cw2.css">
    <title>Document</title>
</head>

<body>
    <?php
    require_once "functions.php";
    ?>
    <div class="container">
        <header>
            <h1>System kursów 2023-23</h1>
        </header>

        <section class=main>
            <nav>


                <div class='menu-item'> <a href='cw2_add.php'>Dodaj do kursu</a></div>
            </nav>
            <section id="content">
                <!-- <pre> -->
                <form action="addNew.php" method="post">
                    <div class="mb-3">
                        <label for="firstname" class="form-label">Podaj imię</label>
                        <input type="text" class="form-control" id="firstname" name="firstname">

                    </div>
                    <div class="mb-3">
                        <label for="lastname" class="form-label">Podaj nazwisko</label>
                        <input type="text" class="form-control" id="lastname" name="lastname">

                    </div>
                    <div class="mb-3">
                        <select class="form-select" name="division" id="division">
                            <?php
                            $divisions = getDivisions();
                            echo divisionToList($divisions);
                            ?>
                        </select>
                    </div>
                    <div class="mb-3">
                        <button type="submit" class="btn btn-primary">Zapisz</button>
                        <button type="reset" class="btn btn-secondary">Wyczyść</button>
                    </div>
                </form>
                <!-- </pre> -->
            </section>
        </section>

    </div>

</body>

</html>