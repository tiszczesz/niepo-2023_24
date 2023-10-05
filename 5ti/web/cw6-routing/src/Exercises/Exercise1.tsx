import { useEffect, useRef } from "react";

const Exercise1 = () => {
  const inputRef1 = useRef<HTMLInputElement>(null);
  const inputRef2 = useRef<HTMLInputElement>(null);
  console.log("rendering Exercise 1....");
  //po renderingu wykonuje sie zawartosc
  useEffect(()=>{
    if(inputRef1.current) inputRef1.current.focus();
  });
  useEffect(()=>{
    setTimeout(()=>{
      document.title = "UseEffect";
      if(inputRef2.current) inputRef2.current.focus();
    },2000);
    
  });
  return (
    <>
      <h2>Exercise 1</h2>
      <input ref={inputRef1} type="text" className="form-control m-2" />
      <input ref={inputRef2} type="text" className="form-control m-2" />
    </>
  )
}

export default Exercise1


