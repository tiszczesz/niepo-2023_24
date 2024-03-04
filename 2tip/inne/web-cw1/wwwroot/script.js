console.log("Hello from JS");


setInterval(()=>{
    document.querySelector("#root")
      .innerHTML = new Date().toLocaleTimeString();
},1000);