import './App.css';
import FilmList from './components/FilmList';
import { films,emptyFilms } from './models/Films';
function App() {
  return (
   <div className="container">
    <h1>Ćwiczenie 4</h1>
    <FilmList color='red' films={films} />
   </div>
  );
}

export default App;
