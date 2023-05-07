import React, { Component } from "react";
import './movie.css';
const imgPath = "https://image.tmdb.org/t/p/w500";

class Movie extends Component {
  render() {
    let { title } = this.props;
    let { id } = this.props;
    let { overview } = this.props;
    let { vote_count } = this.props;
    let { backdrop_path } = this.props;

    return (
      <div className="moviecards">
        <div className=" onecard">
          <img
            src={imgPath+backdrop_path}
            className="image"
            alt="..."
          />
          <div>
            <h3 >Movie Name : {title}</h3>
            <h3>Movie ID : {id}</h3>
            <h3 >Vote Count : {vote_count}</h3>
            <h3 >OverView</h3>
            <p >{overview}</p>
          </div>
        </div>
      </div>
    );
  }
}

export default Movie;
