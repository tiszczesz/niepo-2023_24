import { Link } from "react-router-dom"


const Navbar = () => {
    return (
        <nav className="navbar navbar-expand-lg bg-body-tertiary">
        <div className="container-fluid">
          <Link className="navbar-brand" to="/">Strona domowa</Link>
          <button className="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span className="navbar-toggler-icon"></span>
          </button>
          <div className="collapse navbar-collapse" id="navbarNav">
            <ul className="navbar-nav">             
              <li className="nav-item ">
                <Link className="nav-link active" to="/cw1">ćwiczenie 1</Link>
              </li>
              <li className="nav-item">
                <Link className="nav-link" to="/cw2">ćwiczenie 2</Link>
              </li>            
              <li className="nav-item">
                <Link className="nav-link" to="/cw3">ćwiczenie 3</Link>
              </li>            
            </ul>
          </div>
        </div>
      </nav>
    )
}

export default Navbar