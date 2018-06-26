import React, { Component } from 'react';
import { connect } from 'react-redux';
import { getPlayer } from '../actions/players'
import _ from 'lodash';
import Chart from './chart';

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
        
        const pointHistory = player.playerSummary.history.map(history => history.totalPoints);
        
        console.log('player points', pointHistory);
        
        return (
            <div>
                <img className="player-image" src={`https://platform-static-files.s3.amazonaws.com/premierleague/photos/players/110x140/${player.photo}`} alt="player image" />
                <h4>{player.squadNumber}</h4>                
                <h3>{ `${player.firstName} ${player.secondName}` }</h3>
                <h4>{player.team}</h4>
                <h4>{player.elementType}</h4>
                <ul>
                    <li>Points: {player.totalPoints}</li>
                    <li>Points per game: {player.pointsPerGame}</li>
                    <li>Assists: {player.assists}</li>
                    <li>Goals: {player.goalsScored}</li>
                    <li>Red cards: {player.redCards}</li>
                    <li>Yellow cards: {player.yellowCards}</li>
                </ul>
                <Chart data={pointHistory} label="Points"/>
            </div>
        );
    }
    
    render(){
        return (
            <div className="row justify-content-lg-center">
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