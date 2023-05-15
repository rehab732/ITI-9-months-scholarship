import Movies from "../compontents/Movies";
import Header from "../compontents/Header";
import "./App.css";
import { Suspense } from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import MoviesModule from "../Modules/MoviesModule";

function App() {
  return (
    <div className="App">
    <Suspense fallback={<div>Loading........</div>}>
     <BrowserRouter>
     <Header></Header>
     <Routes>
     {/* <Route path="/" element={<Movies></Movies>}></Route>  */}
     <Route path="movies/*" element={<MoviesModule></MoviesModule>}></Route>
     </Routes>
     </BrowserRouter>
    </Suspense>
    </div>

  );
}

export default App;
