document.addEventListener("DOMContentLoaded", () => {
    const dragItems = document.querySelectorAll(".toDragg");
    const dragContainer = document.getElementById("drag-container");
    const dragContainer2 = document.getElementById("drag-container2");

    // Rozpoczęcie przeciągania
    dragItems.forEach((elem,index)=>{
        elem.addEventListener("dragstart", (e) => {
            e.dataTransfer.setData("text/plain", dragItems[index].id);
        });
    })
 
    // Zablokowanie domyślnego zachowania dla zdarzenia "drop"
    dragContainer.addEventListener("dragover", (e) => {
        e.preventDefault();
    });
    dragContainer2.addEventListener("dragover", (e) => {
        e.preventDefault();
    });

    // Obsługa upuszczenia elementu
    dragContainer.addEventListener("drop", (e) => {
        e.preventDefault();
        const data = e.dataTransfer.getData("text/plain");
        const draggedItem = document.getElementById(data);

        // Dodanie przeciągniętego elementu do kontenera
        if (draggedItem) {
            dragContainer.appendChild(draggedItem);
        }
    });
     // Obsługa upuszczenia elementu
     dragContainer2.addEventListener("drop", (e) => {
        e.preventDefault();
        const data = e.dataTransfer.getData("text/plain");
        const draggedItem = document.getElementById(data);

        // Dodanie przeciągniętego elementu do kontenera
        if (draggedItem) {
            dragContainer2.appendChild(draggedItem);
        }
    });
});
