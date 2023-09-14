import React from 'react';

import './App.css';
import MyInput from './components/MyInput';
import MyRange from './components/MyRange';

function App() {
  console.log("Render App component");

  return (
    <div className='container'>
      <MyInput />
      <MyRange />
    </div>
  );
}

export default App;
