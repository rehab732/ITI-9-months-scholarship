import React, { Component } from 'react';
import axios from 'axios'
import Movie from './Movie';
const apiKey = "&api_key=9813ce01a72ca1bd2ae25f091898b1c7";
const url = "https://api.themoviedb.org/3";
const path = "/discover/movie?sort_by=popularity.desc";
const apiUrl = url + path + apiKey;
class Movies extends Component {


  constructor(props) {
    super(props)
    this.state = {
      movies: [
        {
          id: 1,
          title: 'The Godfather',
          overview: 'test overview',
          vote_count:471 ,
          backdrop_path:'https://image.tmdb.org/t/p/w500/hiHGRbyTcbZoLsYYkO4QiCLYe34.jpg'
       }

      ]
    }
  }
  componentDidMount(){
    axios.get(apiUrl)
      .then(response => {
        console.log(response.data.results)
        this.setState({ movies: response.data.results })
      })
      .catch(function (error) {
        console.log(error)
      })
  }
  render() {
    return (
      <div>
        <h1>Movies List</h1>
        <div style={{display:'flex'}}>
          { this.state.movies.map((movie) => <Movie key={movie.id} title ={movie.title} id={movie.id} overview={movie.overview} vote_count={movie.vote_count} backdrop_path={movie.backdrop_path} />) }
        </div>
      </div>
    )
  }
}
export default Movies;
