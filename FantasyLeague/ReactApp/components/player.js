import React, { Component } from 'react';
import { connect } from 'react-redux';
import { getPlayer } from '../actions/players'
import _ from 'lodash';
{/*import Chart from './sparklines_chart';*/}
import LineChart from './chart'
import SearchBar from './searchbar'
import { Link } from 'react-router-dom';

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
        
//        console.log(player);
        
        if(_.isEmpty(player)){
            return (
                <div>loading...</div>
            );
        }
        
        console.log(player.playerSummary.history);
        
        const take = 10;
        const pointHistory = player.playerSummary.history.map(history => history.totalPoints).slice(-take);
        const goals = player.playerSummary.history.map(history => history.goals).slice(-take);
        const assists = player.playerSummary.history.map(history => history.assists).slice(-take);

        const labels = player.playerSummary.history.map(history => history.round).slice(-take);
        
        const chartDatasets = [{
            data: pointHistory,
            label: "Points per game",
            backgroundColor:
            "rgba(255,99,132,0.2)",
            borderColor:
            "rgba(255,99,132,1)",
            pointBackgroundColor:
            "rgba(255,99,132,1)",
            pointBorderColor:
            "#fff",
            pointHoverBackgroundColor:
            "#fff",
            pointHoverBorderColor:
            "rgba(255,99,132,1)"
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
                    <Link className="btn btn-primary" to="/">
                        &lt; Back to search
                    </Link>
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