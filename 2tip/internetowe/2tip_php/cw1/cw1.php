<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Ćwiczenie 1</title>
    <style>
        .border-center{
            text-align: center;
            border: solid 1px blue;
            padding: 5px;
        }
    </style>
</head>
<body>
    
        <h1>Hello from localhost</h1>
    
    <?php
        // echo "<h3>Hello from php</h3>";
        // //phpinfo();
        // echo "ala ma kota\n";
        // echo 'ala ma kota\n';
        echo "<div class='border-center'>";
        echo "<h2>Alojzy Gąbka</h2>";
        echo "<h3>uczeń klasy 7b</h3>";
        echo "<h4>rok szkolny 2023/24</h4>";
        echo "</div>"; 
    ?>
    <script>
        document.querySelector(".border-center").addEventListener("click",()=>{alert("ffff")})
    </script>
</body>
</html>