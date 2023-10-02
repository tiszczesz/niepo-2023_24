<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw2.css">
    <title>Document</title>
</head>

<body>
    <div class="container">
        <header>
            <h1>System kursów 2023-23</h1>
        </header>

        <section class=main>
            <nav>
                <?php
                require_once "functions.php";
                $divisions = getDivisions();
                echo "<div class='menu-item'> <a href='cw2.php'>Wszystkie grupy</a></div>";
                foreach ($divisions as $elem) {
                    echo "<div class='menu-item'> <a href='cw2.php?id={$elem['id']}'>{$elem['name']}</a></div>";
                }
                ?>
            </nav>
            <section id="content">
                <!-- <pre> -->
                <?php
                    if(filter_has_var(INPUT_GET,'id')){
                        $id = filter_input(INPUT_GET,'id',FILTER_VALIDATE_INT);
                        
                    }else{
                        $id = -1;
                    }                   
                    $students = getStudents($id);
                    var_dump($students);
                ?>
                <!-- </pre> -->
            </section>
        </section>

    </div>

</body>

</html>