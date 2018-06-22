import React, { Component } from "react";
import SearchBar from "./searchbar";
import Players from "./players";

export default class App extends Component{
//    constructor(props){
//        super(props);
//        
//        this.state = { playerDetails: null };
//    }
//    
    render(){
//        console.log('app.js rendered.');
//        const partial = this.state.playerDetails !== null 
//                        ? <div>Player data</div> 
//                        : <Players />
        
        
        return(
            <section>
                <SearchBar />
                <Players />
            </section>
        );
    }
}