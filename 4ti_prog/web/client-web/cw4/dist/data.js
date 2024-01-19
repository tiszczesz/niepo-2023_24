export const colors = ["red", "green", "blue", "yellow"];
export const firstname = "aasasasa";
export function getPrimes(size) {
    const primes = [];
    let value = 1;
    while (primes.length < size) {
        value++;
        if (isPrime(value)) {
            primes.push(value);
        }
    }
    return primes;
}
function isPrime(value) {
    if (value < 2)
        return false;
    for (let i = 2; i * i <= value; i++) {
        if (value % i === 0)
            return false;
    }
    return true;
}
