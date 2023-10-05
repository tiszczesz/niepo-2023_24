import { Route, Routes } from "react-router-dom"
import Navbar from "./components/Navbar"
import Exercise1 from "./Exercises/Exercise1"
import Exercise2 from "./Exercises/Exercise2"
import 'bootstrap/dist/js/bootstrap.bundle.min.js';


function App() {
  console.log("rendering App .....");
  

  return (
    <>
     <Navbar />
     <div className="container mt-3">
      <Routes>
        <Route path="/" element={<Exercise1 />}  />
        <Route path="/cw1" element={<Exercise1 />}  />
        <Route path="/cw2" element={<Exercise2 />}  />
      </Routes>
     </div>
    </>
  )
}

export default App
