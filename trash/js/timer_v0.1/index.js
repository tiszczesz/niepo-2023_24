// Krok 1: Definiowanie dwóch dat
let data1 = new Date('2024-06-24');

// Krok 2: Obliczanie różnicy w milisekundach

const counter = {
  infoText: ' Czas do wystąpienia zdarzenia',
  endDate,
  startDate: new Date(),
  //   endDate,
  differentBetween: function () {
    let differenceMS = this.endDate - this.startDate;
    if (differenceMS <= 0)
      return 'Data początkowa nie może być późniejsza niż końcowa';
    const sekunda = 1000;
    const minuta = sekunda * 60;
    const godzina = minuta * 60;
    const dzień = godzina * 24;
    let dni = Math.floor(differenceMS / dzień);
    differenceMS %= dzień;
    let godziny = Math.floor(differenceMS / godzina);
    differenceMS %= godzina;
    let minuty = Math.floor(differenceMS / minuta);
    differenceMS %= minuta;
    let sekundy = Math.floor(differenceMS / sekunda);
    return `${this.infoText}: ${dni} dni, ${godziny} godzin, ${minuty} minut, ${sekundy} sekund`;
  },
};
function updateTimer() {
  document.querySelector('#timer').innerText = counter.differentBetween();
}
updateTimer();
setInterval(() => {
  updateTimer();
}, 1000);
