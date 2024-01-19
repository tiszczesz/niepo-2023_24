function NWDRec(a: number, b: number): number {
    if (b === 0) return a;
    return NWDRec(b, a % b);
}

function NWDIter(a: number, b: number): number {
    
}
console.log('nwdrec:',NWDRec(25,60));
console.log('nwditer:',NWDIter(25,60));
