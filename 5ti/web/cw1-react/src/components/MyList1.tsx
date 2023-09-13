import React, { useState } from 'react'

type Props = {}

const MyList1 = (props: Props) => {
    const todos = [
        "Przeczytać o map w javascript",
        "Zastosować map do generowania listy todos",
        "Ostylować listę",
        "Pochwalić się lub nie z efektu pracy",
        "zjeść porządnie"
    ];
   
    return (
        <>
            <div>Moja lista do zrobienia</div>
            <ul style={{listStyleType:"circle"}}>
                {todos.map((elem,index)=>(
                    <li key={index}>{elem}</li>
                ))}
            </ul>
        </>


    )
}

export default MyList1