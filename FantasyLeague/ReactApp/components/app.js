import React, { Component } from "react";
import { Switch, Route } from 'react-router-dom';

import SearchBar from "./searchbar";
import Players from "./players";
import Player from "./player";

let Index = (props) => {
    return (
        <div>
            <SearchBar />
            <Players />
        </div>
    );
}

const App = () => {
    return(
      <Switch>
        <Route exact path="/" component={Index}/>                    
        <Route path="/player/:id" component={Player}/>
      </Switch>
    );
}

export default App;