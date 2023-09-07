function MyComp1(){
    let a = 12;
    let b= 45;
    
    return (
        <div>
            <h1>MyComp1 </h1>
            {`${a} + ${b} = ${a+b}`}
            <p>
                Data: {new Date().toLocaleDateString()}<br />
                Czas: {new Date().toLocaleTimeString()}<br />
            </p>
        </div>
    )
}
export default MyComp1;