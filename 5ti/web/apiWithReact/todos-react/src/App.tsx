import './App.css';

function App() {
  fetch("http://localhost:5224/todos").then(res => res.json())
  .then(data => console.log(data));
  return (
    <div className="App">
      
    </div>
  );
}

export default App;
