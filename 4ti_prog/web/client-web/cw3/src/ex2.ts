function NWDRec(a: number, b: number): number {
    if (b === 0) return a;
    return NWDRec(b, a % b);
}
console.log(NWDRec(40,60));
