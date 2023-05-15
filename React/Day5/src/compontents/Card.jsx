import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import axios from 'axios';
import { Link } from 'react-router-dom';

export default function ImgMediaCard({id,name,type,language,poster,story}) {
    const HandleDelete=  ()=>
    {
        axios.delete("http://localhost:3000/movies/"+id)
       .then(() => console.log('Delete successful'));
    }

  return (
    <Card sx={{ width: 350 ,height:620}}>
      <Link to={`/movies/${id}`}>
      <CardMedia
        component="img"
        alt="green iguana"
        height="450"
        image={"https://image.tmdb.org/t/p/w500"+poster}
      >
        
      </CardMedia>
      </Link>
      <CardContent>
        <Typography gutterBottom variant="h5" component="div">
          {name}
        </Typography>
        <Typography variant="body2" color="text.secondary">
          {type}
        </Typography>
      </CardContent>
      <CardActions>
        <Button size="small" onClick={HandleDelete}>Delete</Button>
      </CardActions>
    </Card>
  );
}