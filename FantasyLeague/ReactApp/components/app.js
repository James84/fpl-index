import React, { Component } from "react";
import SearchBar from "./searchbar";
import Players from "./players";

export default class App extends Component{
    render(){
        return(
            <section>
                <SearchBar />
                <Players/>
            </section>
        );
    }
}