
import { createInterface } from "readline/promises";

const r1 =  createInterface({
    input: process.stdin,
    output: process.stdout,
});

const answer1 = await r1.question("Podaj n: ");
const answer2 = await r1.question("Podaj n2: ");

console.log(" Podane n: ",answer1);
console.log(" Podane 2: ",answer2);
r1.close();