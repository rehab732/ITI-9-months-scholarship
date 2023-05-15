import { useContext, useEffect, useState } from "react";
import { MovieContext } from "../Modules/MoviesModule";
import axios from "axios";
import { useParams } from "react-router-dom";


const MovieDetails = ()=>{

    const id = useParams().id;
    const [movie,setMovie] = useState(null);

    useEffect(()=>{
    axios.get("http://localhost:3000/movies/"+id)
    .then((res)=>{setMovie(res.data)});
 },[id]);

 if(!movie)
    {
    return <div>Loading!!</div>
    }
    else{
 return <section className="py-5" >
 <div className="container" >
     <div className="row gx-5">
         <aside className="col-lg-6">
             <div className="border rounded-4 mb-3 d-flex justify-content-center">
                     <img style={{maxWidth: "100%", maxHeight: "100vh", margin: "auto"}} alt="NO" className="rounded-4 fit" src={"https://image.tmdb.org/t/p/w500"+movie.poster} />

             </div>

         </aside>
         <main className="col-lg-6">
             <div className="ps-lg-3">
                 <h4 className="title text-dark">
                     Name: {movie.name}
                 </h4>

                 <div className="mb-3">
                     <span className="h5">Type: {movie.type}</span>
                 </div>

                 <p>
                     Story: {movie.story}
                 </p>

                 <hr />

                 <input type="button" value="Watch Now" className="btn btn-warning shadow-0" />

             </div>
         </main>
     </div>
 </div>
</section>
    }

}


export default MovieDetails;