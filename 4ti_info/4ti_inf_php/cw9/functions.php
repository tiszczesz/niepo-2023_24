<?php


function GetWorkers(): array
{
    return [
        ["Jan", "Nowak", 4800, "kierowca"],
        ["Monika", "Nowak", 4300, "sprzedawca"],
        ["Roman", "Bałecki", 8800, "kierownik"],
        ["Tomasz", "Bomasz", 4200, "asystent"],
        ["Eryk", "Beryk", 3700, "kierowca"],
        ["Anna", "Wanna", 5800, "sprzedawca"]
    ];
}
function ShowWorkers(array $workers): string
{
    $html = "<table><tr><th>Lp</th><th>Imie</th><th>Nazwisko</th><th>Pensja</th>"
        . "<th>Stanowisko</th></tr>";
    $lp = 0;
    foreach ($workers as $worker) {
        $lp++;
        $html .= "<tr><td class='right'>{$lp}</td>" .
            "<td>{$worker[0]}</td>" .
            "<td>{$worker[1]}</td>" .
            "<td class='right'>{$worker[2]}</td>" .
            "<td>{$worker[3]}</td></tr>";
    }

    return $html . "</table>";
}
