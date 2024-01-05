//alert("ala ma kota");
function Hello(){
    return "Ala ma kota";
}
console.log(Hello());
function isPrime(number){
    if(number<2) return false;
    for(let i=2;i*i<=number;i++){
        if(number%i===0) return false;
    }
    return true
}
console.log(isPrime(11));
//console.log(window);
console.log(global);