import { Film } from "../models/Films"

type Props = {
    color: string,
    films: Film[],
}

const FilmList = (props: Props) => {
    let lp = 0;
    return (
        <>
            <h3 style={{ color: props.color }}>Zbiór filmów</h3>
            {props.films.length === 0 ?
                <p>Lista filmów jest pusta</p> :
                <table className="table table-striped">
                    <thead>
                        <tr>
                            <th>Lp</th>
                            <th>Tytuł</th>
                            <th>Reżyser</th>
                            <th>Długość</th>
                            <th>Data produkcji</th>
                        </tr>
                    </thead>
                    <tbody>
                        {props.films.map((f: Film, i) => (
                            <tr key={i}>
                                <td>{++lp}</td>
                                <td>{f.title}</td>
                                <td>{f.director}</td>
                                <td>{f.length}</td>
                                <td>{f.editDate.toLocaleDateString()}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            }

        </>
    )
}

export default FilmList