import React, { Component } from "react";
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { teams } from '../reducers/index';
import { searchPlayers } from '../actions/players';
import { getAllTeams } from '../actions/teams';

class SearchBar extends Component{
    componentDidMount(){
        this.props.getAllTeams();
    }
    
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
    }
    
    renderTeamDropdown(team){
        return (
            <option key={team.id} value={team.id}>{team.name}</option>
        );
    }
    
    render(){
        //console.log('teams', this.props.teams);
        
        //Player type
        //Player team
        //Transfer value
        //Player name
        return(
            <form onSubmit={this.submitForm} className="search-bar input-group">
                <input 
                    type="input" 
                    className="form-control" 
                    placeholder="player"
                    value={this.state.term}
                    onChange={this.onInputChange}/>
                <span className="input-group-btn">
                    <select className="form-control">
                        {
                            this.props.teams.map(this.renderTeamDropdown)
                        }
                    </select>
                </span>
                <span className="input-group-btn">
                    <button type="submit" className="form-control btn btn-secondary">search</button>
                </span>
            </form>
        );
    }
}

function mapDispatchToProps(dispatch){
    return bindActionCreators({ searchPlayers, getAllTeams }, dispatch);
}

function mapStateToProps(state){
    return {
        teams: state.teams
    }
}

export default connect(mapStateToProps, mapDispatchToProps)(SearchBar);