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
function getStudents(int $id=-1):array {
  $conn = getConnection();
  if ($conn == null) die("ERROR DB CONNECTIOM!!!");
  $students = [];
  $sqlStudents = "SELECT * FROM student ".(($id!=-1)?" WHERE division_id = {$id}":"");
  //echo $sqlStudents;
  $result = $conn->query($sqlStudents);
  if (!$result) die("ERROR QUERY!!!");
  while ($row = $result->fetch_array()) {
    $students[] = $row;
  }
  $conn->close();
  return $students;
}