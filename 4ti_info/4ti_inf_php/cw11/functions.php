<?php

function NWD(int $a, int $b): int
{
    $temp = $a;
    while ($b != 0) {
        $temp = $a;
        $a = $b;
        $b = $temp % $b;
    }
    return $a;
}

function NWDRec(int $a, int $b): int
{
    if ($b === 0) return $a;
    return NWDRec($b, $a % $b);
}

/*
36 24

24 36%24=12
24 12
12 24%12=0
12 0

25 7
7  25%7=4
7 4
4 7%4=3
4 4%3=1
3 3%1=0
1 0

*/