import * as readline from 'readline';
const r1 = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
function show(a) {
    //zwraca napis a^2 = .... a^3 = ....
    return `${a}^2 = ${a * a}\n${a}^3 = ${Math.pow(a, 3)}`;
}
// r1.question('Podaj a: ',(a)=>{
//     console.log(show(parseInt(a))); 
// })
r1.question('Podaj a: ', (a) => {
    r1.question('Podaj b: ', (b) => {
        const sum = parseInt(a) + parseInt(b);
        console.log(`${a} + ${b} = ${sum}`);
        r1.close();
        console.log("koniec r1");
    });
});
console.log("koniec ...");
// r1.on('line',(a)=>{
//     console.log("Napisano: "+a);
// })
