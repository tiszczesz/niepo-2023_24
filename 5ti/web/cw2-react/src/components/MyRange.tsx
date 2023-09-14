import React, { useState } from 'react'
import './MyRange.css';


const MyRange = () => {
    const [myValue, setMyValue] = useState('0');
    return (
        <>
            <div className="row">
                <input min="0" max="255" className='col-6 w-50' value={myValue} type='range' onChange={(event) => {
                    setMyValue(event.target.value)
                }} />
                <div className='col-6'>{myValue}</div>
            </div>

            <div id='scene' className='scene'></div>
        </>

    )
}

export default MyRange