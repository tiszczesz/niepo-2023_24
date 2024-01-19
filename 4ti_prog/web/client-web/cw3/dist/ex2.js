"use strict";
function NWDRec(a, b) {
    if (b === 0)
        return a;
    return NWDRec(b, a % b);
}
console.log(NWDRec(25, 60));
