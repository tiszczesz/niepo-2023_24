import React, { useState } from 'react'
import './MyRange.css';


const MyRange = () => {
    const [myRed, setMyRed] = useState('0');
    const [myGreen, setMyGreen] = useState('0');
    const [myBlue, setMyBlue] = useState('0');
    const [style,setStyle] = useState('rgb(0,0,0');
    // const setColor = (r,g,b)=>{
    //     (document.querySelector("#scene") as HTMLDivElement)?.style({bac})
    // };
    return (
        <>
            <div className="row">
                <input min="0" max="255" className='col-6 w-50' value={myRed} type='range' onChange={(event) => {
                    setMyRed(event.target.value);
                    setStyle(`rgb(${myRed},${myGreen},${myBlue})`);
                }} />
                <div className='col-6' style={{color:"red"}}>Red: {myRed}</div>
            </div>
            <div className="row">
                <input min="0" max="255" className='col-6 w-50' value={myGreen} type='range' onChange={(event) => {
                    setMyGreen(event.target.value);
                    setStyle(`rgb(${myRed},${myGreen},${myBlue})`);
                }} />
                <div className='col-6' style={{color:"green"}}>Green: {myGreen}</div>
            </div>
            <div className="row">
                <input min="0" max="255" className='col-6 w-50' value={myBlue} type='range' onChange={(event) => {
                    setMyBlue(event.target.value);
                    setStyle(`rgb(${myRed},${myGreen},${myBlue})`);
                }} />
                <div className='col-6' style={{color:"blue"}}>Blue: {myBlue}</div>
            </div>
            <div id='scene' className='scene' style={{backgroundColor:style}} ></div>
        </>

    )
}

export default MyRange