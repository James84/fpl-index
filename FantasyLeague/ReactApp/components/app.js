import React, { Component } from "react";
import { BrowserRouter, Switch, Route } from 'react-router-dom';

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
      <BrowserRouter>
          <Switch>
            <Route path="/player/:id" component={Player}/>
            <Route exact path="/" component={Index}/>                    
          </Switch>
      </BrowserRouter>
    );
}

export default App;