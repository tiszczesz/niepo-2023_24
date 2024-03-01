import './style.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'bootstrap/dist/js/bootstrap.bundle.min';
import { Todo, Todos } from './Todos';
import GetPost from './fromApi';

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
document.querySelector<HTMLDivElement>("#root")?.appendChild(generList(Todos));
function generList(data:Todo[]):HTMLDivElement{
  const result = document.createElement("div");
  const ul = document.createElement("ul");
  ul.className = "list-group";
  data.forEach((item,i)=>{
    const li = document.createElement("li");
    li.className = "list-group-item";
    if(item.isComplete) li.style.color="green"; 
    li.innerHTML = `<b>${item.title}</b> <i>${item.content}</i>`;
    ul.appendChild(li);
  })
  result.appendChild(ul);
  return result;
}
const posts = await GetPost();
console.log(posts);

