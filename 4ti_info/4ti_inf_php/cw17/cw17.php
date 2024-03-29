<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <title>Document</title>
</head>

<body>
    <h1>Produkty w sklepie warzywnym</h1>
    <nav class="navbar bg-dark border-bottom border-body" data-bs-theme="dark">
        <div class="container-fluid">
            <a class="navbar-brand" href="cw17.php">Strona główna</a>
            <a class="navbar-brand" href="AddProduct.php">Dodaj produkt</a>
            <a class="navbar-brand" href="Kontakt.html">Kontakt</a>
           
        </div>


    </nav>


    <main>
        <h3>Przegląd towarów</h3>
        <?php
        require_once "functions.php";
        $products = getProducts();
        ?>
        <div class="container">
            <main>
                <table class="table table-striped">
                    <thead>
                        <th>Lp</th>
                        <th>Nazwa</th>
                        <th>Opis</th>
                        <th>Cena</th>
                        <th>Data</th>
                    </thead>
                    <tbody>
                        <?php
                        $lp = 0;
                        foreach ($products as $p) {
                            $lp++;
                            echo "<tr>\n";
                            echo "\t<td>{$lp}</td>";
                            echo "\t<td>{$p->Name}</td>";
                            echo "\t<td>{$p->Description}</td>";
                            echo "\t<td>{$p->Price}</td>";
                            echo "\t<td>{$p->Date}</td>";
                            echo "</tr>\n";
                        }
                        ?>
                    </tbody>
                </table>
            </main>
        </div>
    </main>
</body>

</html>