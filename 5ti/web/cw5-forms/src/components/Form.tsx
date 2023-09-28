import React, { FormEvent, useRef, useState } from 'react'

type Props = {}
interface Student {
    firstname: string;
    lastname: string;
    age: number;
    date: Date;
}

const Form = (props: Props) => {
    const [students, setStudents] = useState<Student[]>([])
    const student: Student = { firstname: '', lastname: '', age: 0, date: new Date() }
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
        <form className='w-50' onSubmit={handleSubmit}>
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
        <div id="result" className='w-50'>
            {students.length === 0 ? <p>Lista studentów jest pusta</p> :
                <table className='table table-stripped'>
                    <thead>
                        <tr>
                        <th>Imię</th>
                        <th>Nazwisko</th>
                        <th>Wiek</th>
                        <th>Data rejestracji</th>
                    </tr></thead>
                    <tbody>
                        {students.map((s)=>(<tr>
                            <td>{s.firstname}</td>
                            <td>{s.lastname}</td>
                            <td>{s.age}</td>
                            <td>{s.date.toLocaleDateString()}</td>
                        </tr>))}
                    </tbody>

                </table>
            }
        </div>
    </div>

    )
}

export default Form