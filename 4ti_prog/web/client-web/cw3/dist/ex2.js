"use strict";
function NWDRec(a, b) {
    if (b === 0)
        return a;
    return NWDRec(b, a % b);
}
function NWDIter(a, b) {
    let temp = a;
    while (b !== 0) {
        temp = a;
        a = b;
        b = temp % b;
    }
    return a;
}
console.log('nwdrec:', NWDRec(25, 60));
console.log('nwditer:', NWDIter(25, 60));
