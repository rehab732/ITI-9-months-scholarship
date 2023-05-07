const obj={backgroundColor:"lightcoral" , width:'70%' , margin:"15px auto"};

const Movie = (props) => {
  const{id,movieName,rating}=props;
  return (
   <div style={obj}>
        <h3> Movie Id :{id}</h3>
        <h3> Movie Name :{movieName}</h3>
        <h3> Rating :{rating}</h3>
      </div>


  );
}
export default Movie;
