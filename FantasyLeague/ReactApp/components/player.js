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
            <div className="card player-card text-center">
                <div className="player-card-content">
                    <img className="card-img-top player-image mx-auto" src={`https://platform-static-files.s3.amazonaws.com/premierleague/photos/players/110x140/${player.photo}`} alt="player image" />
                    <div className="card-body">
                        <h4 className="card-title">{ `${player.firstName} ${player.secondName}` }</h4>
                        <h5>{player.team}</h5>
                        <h5>{player.squadNumber}</h5>                
                        <h5>{player.elementType}</h5>
                        <div className="card-body">
                            <div className="card-text">
                                <div>Points: {player.totalPoints}</div>
                                <div>Points per game: {player.pointsPerGame}</div>
                                <div>Assists: {player.assists}</div>
                                <div>Goals: {player.goalsScored}</div>
                                <div>Red cards: {player.redCards}</div>
                                <div>Yellow cards: {player.yellowCards}</div>
                            </div>
                            <Chart data={pointHistory} label="Points"/>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
    
    render(){
        return (
            <div>
                <div className="row">
                    <a href="/">&lt;&lt;&lt; Back to search</a>
                </div>
                <div className="row justify-content-lg-center">
                    {this.renderPlayer()}
                </div>
            </div>
        );
    }
}

function mapStateToProps(state){
    return { player: state.player };
}

export default connect(mapStateToProps, { getPlayer })(Player);