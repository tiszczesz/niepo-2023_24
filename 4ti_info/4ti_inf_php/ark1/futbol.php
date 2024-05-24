<!DOCTYPE html>
<html>

<head>
	<meta charset="UTF-8" />
	<title>Rozgrywki futbolowe</title>
	<link rel="stylesheet" href="styl.css" />
</head>

<body>
	<section id="baner">
		<h2>Światowe rozgrywki piłkarskie</h2>
		<img src="obraz1.jpg" alt="boisko" />
	</section>
	<section id="mecze">
		<?php
		$zap1 = "SELECT zespol1,zespol2,wynik,data_rozgrywki FROM"
			. " `rozgrywka` WHERE zespol1 like 'EVG'";
		$conn = new mysqli("localhost", "root", null, "4ti_inf_2024_ark1");
		//$conn1 = mysqli_connect("localhost", "root", null, "4ti_inf_2024_ark1");

		//$resul2 =mysqli_query($conn,$sql);
		$result = $conn->query($zap1);
		//while($row = mysqli_fetch_row($resul2))
		while ($row = $result->fetch_row()) {
			//var_dump($row);
			echo "<section class='mecz'>";
			echo "<h3>{$row[0]} - {$row[1]}</h3>";
			echo "<h4>{$row[2]}</h4>";
			echo "<p>w dniu: {$row[3]}</p>";
			echo "</section>";
		}
		$conn->close();
		//mysqli_close($coon);
		?>
	</section>
	<section id="glowny">
		<h2>Reprezentacja Polski</h2>
	</section>
	<section id="lewy">
		<p>Podaj pozycję zawodników (1-bramkarze, 2-obrońcy, 3-pomocnicy, 4-napastnicy).</p>
		<form action="futbol.php" method="post">
			<input type="number" name="pozycja" />
			<button>Sprawdź</button>
		</form>
		<ul>
			<?php
			//var_dump($_POST);
			if (isset($_POST['pozycja']) && !empty($_POST['pozycja'])) {
				$conn = new mysqli("localhost", "root", null, "4ti_inf_2024_ark1");
				$pozycja_id = $_POST['pozycja'];
				$sql = "SELECT imie ,nazwisko FROM zawodnik where pozycja_id={$pozycja_id}";
				$result = $conn->query(($sql));
				while ($row = $result->fetch_row()) {
					echo "<li>{$row[0]} {$row[1]}</li>";
				}
				//var_dump($sql);
				$conn->close();
			}
			?>
		</ul>
	</section>
	<section id="prawy">
		<img src="zad1.png" alt="piłkarz" />
		<p>Autor: XXXXXXXXXX</p>
	</section>
	<script src="skrypt.js" defer></script>
</body>

</html>