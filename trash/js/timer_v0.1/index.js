// Krok 1: Definiowanie dwóch dat
let data1 = new Date('2024-06-24');

// Krok 2: Obliczanie różnicy w milisekundach

const counter = {
  infoText: ' Czas do wystąpienia zdarzenia',
  endDate: new Date('2024-06-21:13:35:00:00'),
  //   endDate,
  generText: function (text, time) {
    if (time == 1) return text + 'a';
    if (time > 1 && time < 5) return text + 'y';
    else return text;
  },
  differentBetween: function (currentDate) {
    let differenceMS = this.endDate - currentDate;
    if (differenceMS <= 0)
      return `${this.infoText} już się odbyło!`;
    const sekunda = 1000;
    const minuta = sekunda * 60;
    const godzina = minuta * 60;
    const dzień = godzina * 24;
    let dni = Math.floor(differenceMS / dzień);
    const dniText = dni > 1 ? "dni" : "dzień";
    differenceMS %= dzień;
    let godziny = Math.floor(differenceMS / godzina);
    differenceMS %= godzina;
    let minuty = Math.floor(differenceMS / minuta);
    differenceMS %= minuta;
    let sekundy = Math.floor(differenceMS / sekunda);
    return `${this.infoText}:<br> ${dni} ${dniText}, ${godziny} ${this.generText("godzin", godziny)},
               ${minuty} ${this.generText("minut", minuty)}, ${sekundy} ${this.generText("sekund", sekundy)}`;
  },
};
function updateTimer() {
  document.querySelector('#timer').innerHTML = counter.differentBetween(
    new Date()
  );
}
updateTimer();
setInterval(() => {
  updateTimer();
}, 1000);
