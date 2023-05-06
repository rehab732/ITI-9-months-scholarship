import { useState } from "react";
import Header from "../Components/header";
import Movie from './Movie';
const Page1 = () => {
  const [movieArr] = useState([
    { id: 1, movieName: "xyz", rating: 5 },
    { id: 2, movieName: "asd", rating: 4 },
    { id: 3, movieName: "xad", rating: 3 },
    { id: 4, movieName: "wer", rating: 5 },
    { id: 5, movieName: "geg", rating: 4 },
  ]);

  return (
    <>
      <Header />
      <div>{movieArr.map((m) => <Movie key={m.id} {...m}></Movie>)}</div>
    </>
  );
};

export default Page1;
