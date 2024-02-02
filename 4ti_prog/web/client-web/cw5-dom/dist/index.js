var _a;
import { Products } from "./dane.js";
import { GenerList } from "./functions.js";
const root = document.querySelector("#root");
console.log(Products);
function RefreshList(root) {
    root.innerHTML = "";
    root === null || root === void 0 ? void 0 : root.appendChild(GenerList(Products));
    const imgs = document.querySelectorAll("img.delete");
    imgs.forEach((e, i) => {
        e.addEventListener("click", (event) => {
            console.log((event.target));
        });
    });
}
RefreshList(root);
(_a = document.
    querySelector("#form")) === null || _a === void 0 ? void 0 : _a.addEventListener("submit", (event) => {
    const input = document.querySelector("#product");
    event.preventDefault();
    console.log(input === null || input === void 0 ? void 0 : input.value);
    if ((input === null || input === void 0 ? void 0 : input.value) !== undefined && root !== null) {
        Products.push(input === null || input === void 0 ? void 0 : input.value);
        RefreshList(root);
        input.value = "";
    }
});
