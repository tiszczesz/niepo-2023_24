import { useEffect, useState } from "react"
import { Categories, Products } from "../Dane"



const Exercise3 = () => {
    const [category, setCategory] = useState("");
    useEffect(
        () => {
            console.log("rendering Exercise3");
        }
    )
    return (
        <div className="container">
            <select className="form-select" onChange={(event) => (setCategory(event.target.value))}>
                <option ></option>
                {Categories.map((v, k) => (
                    <option key={k}>{v}</option>
                ))}
            </select>
            {category !== '' ? <>
                <div>Wybrano {category}</div>
                <ul className="list-group">
                    {Products.filter((v) => v.category === category).map((v, k) => (
                        <li className="list-group-item" key={k}>{v.name} cena: {v.price} zł</li>
                    ))}
                </ul>
            </>
                : <>
                <div>Wybrano wszystkie kategorie: </div>
                <ul className="list-group">
                    {Products.map((v, k) => (
                        <li className="list-group-item" key={k}>{v.name} cena: {v.price} zł</li>
                    ))}
                </ul>
                </>}

        </div>
    )
}

export default Exercise3