import React, { Component } from 'react';
import { connect } from 'react-redux';
import { getPlayer } from '../actions/players'
import _ from 'lodash';
{/*import Chart from './sparklines_chart';*/}
import LineChart from './chart'
import SearchBar from './searchbar'

class Player extends Component {
    componentDidMount(){
        this.props.getPlayer(this.props.match.params.id);
    }

    renderConditionalData(player){
        switch(player.elementType){
            case 'Goalkeeper':
                return (
                    <div>
                        <div>Cleansheets: {player.cleanSheets}</div>
                        <div>Saves: {player.saves}</div>
                    </div>
                );
            default:
                return (
                    <div>
                        <div>Assists: {player.assists}</div>
                        <div>Goals: {player.goalsScored}</div>
                    </div>
                );
        }
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
        const labels = player.playerSummary.history.map(history => history.round);
        
        const chartDatasets = [{
            data: pointHistory,
            label: "Points per game",
            backgroundColor: "rgba(75,192,192,0.4)",
            borderColor: "rgba(75,192,192,1)",
            pointBackgroundColor: "#fff",
            pointsBorderColor: "rgba(75,192,192,1)",
            fill: false,
            borderJoinStyle: "miter"
        }];
        
        return (
            <div className="card-group">
                <div className="card player-card text-center">
                    <div className="player-card-content">
                        <img className="card-img-top player-image mx-auto" src={`https://platform-static-files.s3.amazonaws.com/premierleague/photos/players/110x140/${player.photo}`} alt="player image" />
                        <h4 className="card-title">{ `${player.firstName} ${player.secondName}` }</h4>
                        <h5>{player.team}</h5>
                        <h5>{player.squadNumber}</h5>                
                        <h5>{player.elementType}</h5>
                        <div className="card-body">
                            <div className="card-text">
                                <div>Points: {player.totalPoints}</div>
                                <div>Points per game: {player.pointsPerGame}</div>
                                { this.renderConditionalData(player) }
                                <div>Red cards: {player.redCards}</div>
                                <div>Yellow cards: {player.yellowCards}</div>
                            </div>
                        </div>
                    </div>
                </div>
                <div className="card player-card text-center">
                    <div className="player-card-content">
                        <div className="card-body">
                            <LineChart datasets={chartDatasets} labels={labels}/>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
    
    render(){
        return (
            <div className="player-details-container">
                <div className="row justify-content-lg-center">
                    <a className="btn btn-primary" href="/">&lt; Back to search</a>
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