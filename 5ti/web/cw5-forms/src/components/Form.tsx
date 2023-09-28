import React, { FormEvent, useRef } from 'react'

type Props = {}

const Form = (props: Props) => {

    const student = { firstname: '', lastname: '', age: 0, date: new Date() }
    const firstnameRef = useRef<HTMLInputElement>(null);
    const lastnameRef = useRef<HTMLInputElement>(null);
    const ageRef = useRef<HTMLInputElement>(null);
    const dateRef = useRef<HTMLInputElement>(null);
    function handleSubmit(event: FormEvent<HTMLFormElement>): void {
        event.preventDefault();
        if (
            firstnameRef.current !== null &&
            lastnameRef.current !== null &&
            ageRef.current !== null &&
            dateRef.current !== null) {
            student.firstname = firstnameRef.current.value;
            student.lastname = lastnameRef.current.value;
            student.age = parseInt(ageRef.current.value);
            student.date = new Date(dateRef.current.value);
            console.log(student);
            (document.querySelector("#result") as HTMLDivElement)
                .innerHTML = `imię ${student.firstname} nazwisko: ${student.lastname}
                    wiek: ${student.age} data rejestracji: ${student.date.toLocaleDateString()}`
        }
    }

    return (<div className='d-flex justify-content-around'>
        <form onSubmit={handleSubmit}>
            <div className="mb-3">
                <label htmlFor="" className="form-label">Imię</label>
                <input ref={firstnameRef} type="text" className="form-control" />
            </div>
            <div className="mb-3">
                <label htmlFor="" className="form-label">Nazwisko</label>
                <input ref={lastnameRef} type="text" className="form-control" />
            </div>
            <div className="mb-3">
                <label htmlFor="" className="form-label">Wiek</label>
                <input ref={ageRef} type="number" className="form-control" />
            </div>
            <div className="mb-3">
                <label htmlFor="" className="form-label">Data rejestracji</label>
                <input ref={dateRef} type="date" className="form-control" />
            </div>
            <button className='btn btn-primary w-100' type='submit'>Zapisz</button>
        </form>
        <div id="result"></div>
    </div>

    )
}

export default Form