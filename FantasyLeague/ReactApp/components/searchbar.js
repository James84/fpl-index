import React, { Component } from "react";
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { searchPlayers } from '../actions/players';

class SearchBar extends Component{
    constructor(props){
        super(props);
        
        this.state = { term: ''};
        
        this.submitForm = this.submitForm.bind(this);
        this.onInputChange = this.onInputChange.bind(this);
    }    
    
    submitForm(event){
        event.preventDefault();
        this.props.searchPlayers(this.state.term);
        this.setState({ term: '' });
    }
    
    onInputChange(event){
        this.setState({ term: event.target.value });
        this.props.searchPlayers(this.state.term);
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

function mapDispatchToProps(dispatch){
    return bindActionCreators({ searchPlayers }, dispatch);
}

export default connect(null, mapDispatchToProps)(SearchBar);