import {useContext, useState} from "react";
import {v4 as uuid} from 'uuid';
import { MovieContext } from "../Modules/MoviesModule";

const AddMovie = () => {

    const {addMovie} = useContext(MovieContext);
    const [movieData,setMovieData] = useState({id:"",name:"",type:"",language:"",poster:"",story:""})

    const handleTextChange=(e)=>
    {
       const {name,value} = e.target;
       setMovieData({...movieData,[name]:value})
    }

    const HandleSubmit = (e)=>
    {
        e.preventDefault();
        movieData.id = uuid();
        addMovie(movieData);
        setMovieData({name:"",type:"",language:"",poster:"",story:""});
    }

    return <form onSubmit={HandleSubmit} >
        <label>Name:</label> <input type="text" name="name" value={movieData.name} onChange={handleTextChange}></input>
        <br></br>
        <br></br>
        <label>Type:</label> <input type="text" name="type" value={movieData.type} onChange={handleTextChange}></input>
        <br></br>
        <br></br>
        <label>Language:</label> <input type="text" name="language" value={movieData.language} onChange={handleTextChange}></input>
        <br></br>
        <br></br>
        <label>Poster:</label> <input type="text" name="poster" value={movieData.poster} onChange={handleTextChange}></input>
        <br></br>
        <br></br>
        <label>story:</label> <input type="text" name="story" value={movieData.story} onChange={handleTextChange}></input>
        <br></br>
        <br></br>
        <input type="submit"></input>
    </form>
    
};

export default AddMovie;