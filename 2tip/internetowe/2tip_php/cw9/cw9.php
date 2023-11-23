<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="cw9.css">
    <title>Document</title>
</head>

<body>
    <form method="post" action="result.php">
        <div class="line">
            <label for="firstname">Podaj imie: </label>
            <input type="text" name="firstname" id="firstname">
        </div>
        <div class="line">
            <label for="lastname">Podaj nazwisko: </label>
            <input type="text" name="lastname" id="lastname">
        </div>
        <div class="line">
            <label for="dateBirth">Podaj date urodzenia: </label>
            <input type="date" name="dateBirth" id="dateBirth">
        </div>
        <div class="line">            
            <input type="submit"  value="Zapisz" name="submit">
            <input type="reset"  value="Wyczyść">
        </div>
    </form>
</body>

</html>