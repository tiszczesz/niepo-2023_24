import { Film } from "../models/Films"

type Props = {
    color: string,
    films: Film[],
}

const FilmList = (props: Props) => {
    let lp = 0;
    return (
        <>
        <h3>Zbiór filmów</h3>
            <table className="table table-stripped">
                <tr>
                    <th>Lp</th>
                    <th>Tytuł</th>
                    <th>Reżyser</th>
                    <th>Długość</th>
                    <th>Data produkcji</th>
                </tr>
            </table>
        </>
    )
}

export default FilmList