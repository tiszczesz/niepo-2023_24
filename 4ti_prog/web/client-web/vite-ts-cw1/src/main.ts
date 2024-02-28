import './style.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';

document.querySelector<HTMLDivElement>('#app')!.innerHTML = `
  <div class="container">
    <h1>Test VITE</h1>
    <div id="root"></div>
  </div>
`

const div = document.createElement("div");
const text = document.createTextNode("Ala ma kota");
div.appendChild(text);
document.querySelector<HTMLDivElement>("#root")?.appendChild(div);
