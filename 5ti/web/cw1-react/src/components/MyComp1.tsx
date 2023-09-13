import { useEffect, useState } from 'react';
import Euklides from  '../media/Euklides.jpg'
import './MyComp1.css';
function MyComp1(){
    let a = 12;
    let b= 45;
    let author = "Alojzy Gąbka";
    const [time,setTime] = useState(new Date().toLocaleTimeString());
    
    useEffect(()=>{
        setInterval(()=>{
            setTime(new Date().toLocaleTimeString())
        },1000)
    },[]);
    console.log("renderowanie");    
    return (
        <div>
            <h1>MyComp1 </h1>
            {`${a} + ${b} = ${a+b}`}
            <p>
                Data: {new Date().toLocaleDateString()}<br />
                Czas: {time}
                <img onClick={()=>{alert("Hello from Eukldes")}} className='obrazek' src={Euklides} alt="Euklides" />
            </p>
            <div style={{color:'red',fontSize:'2em'}}>To jest inny div ostylowany {author}</div>
        </div>
    )
}
export default MyComp1;