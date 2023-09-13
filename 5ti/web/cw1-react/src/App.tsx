import React from 'react';

import './App.css';
import MyComp1 from './components/MyComp1';
import MyList1 from './components/MyList1';


function App() {
  return (
    <div>
     <h1>Hello from React</h1>
     <p className='par1'>Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum molestiae perferendis a quis, assumenda doloremque, tempore fuga quod placeat doloribus maiores soluta corporis, nobis ad necessitatibus tenetur repellat dolore hic?</p>
    <MyComp1 />
    <MyList1 />
    </div>
  );
}

export default App;
