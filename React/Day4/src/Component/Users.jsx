
import {v4 as uuid} from 'uuid';

import axios from "axios";
import MovieCard from './MovieCard'
import SimpleBackdrop from './spinner';

const { useState, useEffect } = require("react")

const Users= ()=>{
    const [movieLst ,setMovies] = useState(null);
  
   useEffect(()=>{
    axios.get('https://api.themoviedb.org/3/trending/movie/day?api_key=7318267e0930fb1578053cb357c3b2cd')
    .then((res)=>{setMovies(res.data.results)})
    .then(console.log(movieLst))
   },[])
   if(movieLst ==null) return <SimpleBackdrop></SimpleBackdrop>
    return (
        <div>{movieLst.map((u)=><MovieCard key={u.id} {...u}></MovieCard>)}</div>
    )
}

export default Users;
