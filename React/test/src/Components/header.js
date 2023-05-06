import React from "react";
import { Link, NavLink } from "react-router-dom";

const Header = () => {
  return (
    <>
      <header className="hide-when-mobile">

      <Link to="/">
          <h1>React Day 1</h1>
      </Link>
        <ul className="flex">
          <li className="main-list">
            <NavLink className="main-link" to="/page1">
              {" "}
              Movies{" "}
            </NavLink>
            {/* <ul className="sub-ul">
                <li><a href>Full Course</a></li>
                <li><a href>Crash Course</a></li>
                <li><a href>learn in 1h</a></li>
              </ul> */}
          </li>
          <li className="main-list">
            <NavLink className="main-link" to="/page2">
              {" "}
              Page2{" "}
            </NavLink>
            {/* <ul className="sub-ul">
                <li><a href>Full Course</a></li>
                <li><a href>CSS Examples</a></li>
                <li className="mini-projects">
                  <a href>mini projects&nbsp; + </a>
                  <ul className="sub-sub-ul">
                    <li><a href>project 1</a></li>
                    <li><a href>project 2</a></li>
                    <li><a href>project 3</a></li>
                  </ul>
                </li>
              </ul> */}
          </li>
          <li className="main-list">
            <NavLink className="main-link" to="/page3">
              {" "}
              Page3{" "}
            </NavLink>
            {/* <ul className="sub-ul sub-of-js">
                <li><a href>coming soon🔥</a></li>
              </ul> */}
          </li>
        </ul>
      </header>
    </>
  );
};

export default Header;
