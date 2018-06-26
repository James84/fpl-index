import React, { Component } from 'react';
import { connect } from 'react-redux';
import { getPlayer } from '../actions/players'
import _ from 'lodash';

class Player extends Component {
    componentDidMount(){
        this.props.getPlayer(this.props.match.params.id);
    }
    
    renderPlayer(){
        const player = this.props.player;
        
        console.log(player);
        
        if(_.isEmpty(player)){
            return (
                <div>loading...</div>
            );
        }
        
        return (
            <div>
                <img src={`https://platform-static-files.s3.amazonaws.com/premierleague/photos/players/110x140/${player.photo}`} alt="player image" />
                <h3>{ `${player.firstName} ${player.secondName}` }</h3>
                <h4>{player.squadNumber}</h4>
                <ul>
                    <li>Points: {player.totalPoints}</li>
                    <li>Assists: {player.assists}</li>
                    <li>Goals: {player.goalsScored}</li>
                    <li>Red cards: {player.redCards}</li>
                    <li>Yellow cards: {player.yellowCards}</li>
                </ul>
            </div>
        );
    }
    
    render(){
        return (
            <div>
                <a href="/">&lt;&lt;&lt; Back to search</a>
                {this.renderPlayer()}
            </div>
        );
    }
}

function mapStateToProps(state){
    return { player: state.player };
}

export default connect(mapStateToProps, { getPlayer })(Player);