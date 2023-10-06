<?php
require_once "configuration.php";

function getConnection(): ?mysqli
{
  $conn = new mysqli(HOST, USER, PSWD, DB);
  if ($conn->connect_errno != 0) return null;
  return $conn;
}
function getDivisions(): array
{
  $conn = getConnection();
  if ($conn == null) die("ERROR DB CONNECTIOM!!!");
  $divisions = [];
  $sqlSelect = "SELECT * FROM divisions";
  $result = $conn->query($sqlSelect);
  if (!$result) die("ERROR QUERY!!!");
  while ($row = $result->fetch_array()) {
    $divisions[] = $row;
  }
  $conn->close();
  return $divisions;
}
function getStudents(int $id = -1): array
{

  $conn = getConnection();
  if ($conn == null) die("ERROR DB CONNECTIOM!!!");
  $students = [];
  $sqlStudents = "SELECT student.id, firstname,lastname,name FROM "
     ." student INNER JOIN divisions on division_id=divisions.id " . (($id != -1) ? " WHERE division_id = {$id}" : "");
  //echo $sqlStudents;
  $result = $conn->query($sqlStudents);
  if (!$result) die("ERROR QUERY!!!");
  while ($row = $result->fetch_array()) {
    $students[] = $row;
  }
  $conn->close();
  return $students;
}
function studentsToTabHTML(array $students,$id=-1): string
{
  //var_dump($students);
  $lp = 0;
  $head = $id==-1 ? "<h3>Wszystkie grupy</h3>" : "";
  $html = <<<TEXT
  $head
  <table class='table table-striped'>
  <thead>
    <tr>
      <th>Lp</th>
      <th>Imię</th>
      <th>Nazwisko</th>
      <th>Grupa</th>
    </tr>
  </thead>\n
  <tbody>\n
TEXT;
  foreach ($students as $s) {
    $lp++;
    $html .= "\t<tr><td class='right'>{$lp}</td><td>{$s[1]}</td><td>{$s[2]}</td><td>{$s[3]}</td></tr>\n";
  }
  return $html."</tbody>\n</table>\n";
}
