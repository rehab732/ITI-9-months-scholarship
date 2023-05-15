import { Link, NavLink } from "react-router-dom"
import classes from "../Styles/Header.module.css"
import '../../node_modules/bootstrap/dist/css/bootstrap.min.css';

const Header = () => {
    return (
      <nav className="navbar navbar-expand-lg navbar-light bg-light mb-5 p-3">

      <Link to="movies" className="navbar-brand">
        LOGO
      </Link>
      
      
      <div className="collapse navbar-collapse" id="navbarNavDropdown">
        <ul className="navbar-nav">
          <li className="nav-item active">
            <Link to="movies" className="nav-link">
              Home 
            </Link>
          </li>
          <li className="nav-item">
            <Link to="movies/add" className="nav-link">
              Add Movie
            </Link>
          </li>

          
        </ul>
      </div>
    </nav>
    )
}

export default Header