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

        <?php
        require_once "functions.php";
        $products = getProducts();
        ?>
        <div class="container">
            <main>
                <h3>Nowy produkt</h3>
                <form method="post" action="addNew.php">
                    <div class="row mt-3">
                        <label class="col-3 text-end" for="name">Nazwa</label>
                        <input type="text" class="col-6" name="name" id="name" />
                    </div>
                    <div class="row mt-3">
                        <label class="col-3 text-end" for="description">Opis</label>
                        <input type="text" class="col-6" name="description" id="description" />
                    </div>
                    <div class="row mt-3">
                        <label class="col-3 text-end" for="price">Cena</label>
                        <input type="number" step="0.1" class="col-6" name="price" id="price" step="0.1"/>
                    </div>
                    <div class="row mt-3">
                        <label class="col-3 text-end" for="date">Data</label>
                        <input type="date" class="col-6" name="date" id="date" />
                    </div>
                    <div class="row mt-3">
                        <input type="submit" class="btn btn-primary col-6 offset-3" value="Zapisz"  name="save" id="save" />
                    </div>
                </form>
            </main>
        </div>
    </main>
</body>

</html>