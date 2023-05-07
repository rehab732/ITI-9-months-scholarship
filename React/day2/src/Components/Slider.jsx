import React from 'react'
import './Slider.css'
import images from '../assets/images'


export default function Slider() {
    const [current, setCurrent] = React.useState(0)
    const previousHandler = () => {
        setCurrent((prevState)=>{
            if(prevState === 0){
                return 0
            } else {
                return prevState - 1
            }
        })
    }
    const nextHandler = () => {
        setCurrent((prevState)=>{
            if(prevState === 2){
                return 2
            } else {
                return prevState + 1
            }
        })
    }

  return (
    

    <div className='App'>
      <h1>Slider Component</h1>
      <div className='slider'>
          <button className='btn btn-outline-success' id="prev" onClick={previousHandler}>Previous</button>
          <img src={images[current]} alt="img"/>
          <button className='btn btn-outline-success' id="next" onClick={nextHandler}>Next</button>
      
      </div>
    </div>
  )
}