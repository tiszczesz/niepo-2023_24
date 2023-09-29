import { Link } from "react-router-dom"


const Navbar = () => {
    return (
        <nav className="navbar bg-body-tertiary">
            <div className="container-fluid">
               <Link to='/' className="navbar-brand">
                Strona główna
               </Link>
            </div>
        </nav>
    )
}

export default Navbar