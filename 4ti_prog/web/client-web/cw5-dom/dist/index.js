var _a;
import { Products } from "./dane.js";
import { GenerList } from "./functions.js";
let products = [...Products];
const root = document.querySelector("#root");
console.log(products);
function RefreshList(root, products) {
    root.innerHTML = "";
    root === null || root === void 0 ? void 0 : root.appendChild(GenerList(products));
    const imgs = document.querySelectorAll("img.delete");
    imgs.forEach((e, i) => {
        e.addEventListener("click", (event) => {
            console.log("przed usunięciem: ", products);
            products.splice(parseInt(event.target.id), 1);
            console.log("po usunięciu: ", products);
            RefreshList(root, products);
            // debugger;
        });
    });
}
RefreshList(root, products);
(_a = document.
    querySelector("#form")) === null || _a === void 0 ? void 0 : _a.addEventListener("submit", (event) => {
    const input = document.querySelector("#product");
    event.preventDefault();
    console.log(input === null || input === void 0 ? void 0 : input.value);
    if ((input === null || input === void 0 ? void 0 : input.value) !== undefined && root !== null) {
        // debugger;
        products.push(input === null || input === void 0 ? void 0 : input.value);
        console.log("po dodaniu:", products);
        RefreshList(root, products);
        input.value = "";
    }
});
