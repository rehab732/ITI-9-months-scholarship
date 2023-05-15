import { createContext, lazy, useCallback, useEffect, useMemo, useState } from "react"
import { Route, Routes } from "react-router-dom";
import Movies from "../compontents/Movies";
import MovieDetails from "../compontents/MovieDetails";
import axios from "axios";
import AddMovie from "../compontents/AddMovie";

//const MoviesPage =lazy(()=>import("../pages/Users"))
const DetailsPage =lazy(()=>import("../compontents/MovieDetails"))
//const AddUserPage =lazy(()=>import("../pages/AddUser"))
//const NotFound=lazy(()=>import("../pages/NotFound"))

export const MovieContext = createContext();

const MoviesModule = () => {

    const [moviesArr,setMoviesArr] = useState(null);
    //ComponentDidMount
    useEffect(()=>{
        axios.get("http://localhost:3000/movies")
        .then((res)=>setMoviesArr(res.data));
    },[moviesArr]);

    const addMovie = useCallback((mov)=>
    {
        axios.post("http://localhost:3000/movies", mov)
      .then(res => {
        console.log(res);})
    },[]);

    const data=useMemo(()=>({moviesArr,addMovie}),[moviesArr,addMovie]);

    if(!moviesArr)
    {
    return <div>Loading!!</div>
    }
   else{
    return <MovieContext.Provider value={data}>
    <Routes>
      <Route index element={<Movies></Movies>}></Route>
       <Route path="add" element={<AddMovie></AddMovie>}></Route> 
      <Route path=":id" element={<MovieDetails ></MovieDetails>}></Route>
      {/* <Route path="*" element={<NotFound></NotFound>}></Route> */}
    </Routes>
    </MovieContext.Provider>
   }

}
export default MoviesModule;