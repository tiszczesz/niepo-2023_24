
const counter = {
  infoText: ' Czas do wystąpienia zdarzenia',
  endDate: new Date('2024-06-09T10:00:00'),
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
    const sec = 1000;
    const min = sec * 60;
    const hour = min * 60;
    const day = hour * 24;
    let days = Math.floor(differenceMS / day);
    const dayText = days !== 1 ? "dni" : "dzień";
    differenceMS %= day;
    let hours = Math.floor(differenceMS / hour);
    differenceMS %= hour;
    let minutes = Math.floor(differenceMS / min);
    differenceMS %= min;
    let secs = Math.floor(differenceMS / sec);
    return `${this.infoText}:<br> ${days} ${dayText}, ${hours} ${this.generText("godzin", hours)},
               ${minutes} ${this.generText("minut", minutes)}, ${secs} ${this.generText("sekund", secs)}`;
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
