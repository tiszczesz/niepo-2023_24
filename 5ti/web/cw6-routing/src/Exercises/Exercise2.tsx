import { useEffect, useState } from "react";

const Exercise2 = () => {
  const [products,setProducts] = useState<string[]>([]);
  useEffect(()=>{
      console.log("pobieranie produktów...");
      setProducts(['Ryby','Bułki']);
      
  },[]);
  return (
    <> 
    <h3>Lista produktów</h3>
    <ul>
      {products.map((elem,index)=>(
        <li key={index}>{elem}</li>
      ))}
    </ul>
    </>
   
  )
}

export default Exercise2