import {useEffect, useState} from "react";
import Movie from "./Movie";
import {v4 as uuid} from 'uuid';
import AddMovie from "./AddMovie";
import axios from "axios";

import * as React from 'react';
import { styled } from '@mui/material/styles';
import Box from '@mui/material/Box';
import Paper from '@mui/material/Paper';
import Grid from '@mui/material/Grid';
import { MovieContext } from "../Modules/MoviesModule";


const Item = styled(Paper)(({ theme }) => ({
    backgroundColor: theme.palette.mode === 'dark' ? '#1A2027' : '#fff',
    ...theme.typography.body2,
    padding: theme.spacing(1),
    textAlign: 'center',
    color: theme.palette.text.secondary,
  }));

const Movies = () => {
    
    const {moviesArr} = React.useContext(MovieContext);
    // const AddMov =(movData)=>
    // {
    //     setMovieArr((oldArr)=>[...oldArr,{...movData,id:uuid()}]);
    // }

    

    if(!moviesArr)
    {
    return <div>Loading!!</div>
    }
    else{
    return (
        <>
        <div >
     
        <Box sx={{ flexGrow: 1 }}>
        <Grid container spacing={3} >
        
          {moviesArr.map((m)=>
          <Grid item xs={3} style={{}}>
           <Item style={{}}><Movie key={m.id} {...m}></Movie></Item>
          </Grid>
           )} 
             
        </Grid>
        </Box>
  
        </div>
        </>      
    );
    }
};

export default Movies;