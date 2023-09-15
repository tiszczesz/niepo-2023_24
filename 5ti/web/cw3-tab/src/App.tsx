import React, { useEffect } from 'react';
import Course from "./models/course";

import './App.css';
const courses = [
  new Course("Java wstęp","Warszawa",3500,new Date('2023-09-04')),
      new Course("C++ wskaźniki","Kraków",2800,new Date('2023-11-04')),
      new Course("React - wstęp","zdalne",4000,new Date('2023-06-12')),
      new Course("Angular - aplikacje webowe","zdalne",3900,new Date('2023-11-23'))
]
function App() {
  
  
  console.log("render");
  console.log(courses);
  
  return (
   <div className="container">
    <h2>Lista kursów</h2>
   </div>
  );
}

export default App;
