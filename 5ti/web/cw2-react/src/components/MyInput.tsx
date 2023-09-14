import { useState } from "react";

const MyInput = () => {
    const [myValue,setMyValue] = useState('na początek');
    return (
        <>
            <input onChange={(event)=>{
                console.log(event.target.value);
                setMyValue(event.target.value)
            }} />
            <span>{myValue}</span>
        </>

    )
}
export default MyInput;