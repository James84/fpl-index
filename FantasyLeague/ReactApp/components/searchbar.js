import React, { Component } from "react";
import axios from "axios";

export default class SearchBar extends Component{
    constructor(props){
        super(props);
        
        this.state = { term: ''};
        
        this.submitForm = this.submitForm.bind(this);
        this.onInputChange = this.onInputChange.bind(this);
    }    
    
    submitForm(event){
        event.preventDefault();
        
        let players = axios(`http://fantasy.league.local/playersearch?lastname=${this.state.term}`).then(res => {
            this.setState({ players: res.data});
        });

        console.log("players", this.state.players);
        
        this.setState({ term: '' });
    }
    
    onInputChange(event){
        this.setState({ term: event.target.value });
    }
    
    render(){
        return(
            <form onSubmit={this.submitForm} className="input-group">
                <input 
                    type="input" 
                    className="form-control" 
                    placeholder="player"
                    value={this.state.term}
                    onChange={this.onInputChange}/>
                <span className="input-group-btn">
                    <button type="submit" className="form-control btn btn-secondary">search</button>
                </span>
            </form>
        );
    }
}