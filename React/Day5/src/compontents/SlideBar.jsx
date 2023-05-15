import { Component, PureComponent } from "react";

class SlideBar extends PureComponent{
    
    constructor()
    {
        super();
        this.state = {i:1}
    }
    render()
    {
        const handleNextClick=()=>{
            if(this.state.i<6)
            this.setState({i:this.state.i+1});
           
        }
        const handlePrevClick=()=>{
            if(this.state.i >1)
            this.setState({i:this.state.i-1});
        };
        return<div style={{textAlign:"center"}}> <img  height={400} src={"Images/"+this.state.i+".jpg"} alt="No"></img>
        <br></br>
        <button onClick={handlePrevClick} >Prev</button>
        <button onClick={handleNextClick}> Next</button>

        </div>
    }
}
export default SlideBar;