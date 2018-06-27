import React, { Component } from "react";
import { connect } from 'react-redux';
import { players } from '../reducers/index';
import { searchPlayers, getAllPlayers } from '../actions/players';

class Players extends Component {
    componentDidMount(){
        this.props.getAllPlayers();
    }
    
    getPlayer(id){
        window.location.href = `/player/${id}`
    }
    
    
    renderPlayers(player){
        console.log('player', player);
        return (
            <tr className="player-record" onClick={this.getPlayer.bind(this, player.id)} key={player.id}>
                <td>{player.firstName}</td>
                <td>{player.secondName}</td>
                <td>{player.team}</td>
                <td>{player.squadNumber}</td>
                <td>{player.totalPoints}</td>
            </tr>
        );
    }
    
    render() {
        return (
                <table className="table table-hover">
                    <thead>
                        <tr>
                            <th>First name</th>
                            <th>Second name</th>
                            <th>Team</th>
                            <th>Squad number</th>
                            <th>Total points</th>
                        </tr>
                    </thead>
                    <tbody>
                    {
                        this.props.players.map(this.renderPlayers.bind(this))
                    }
                    </tbody>
                </table>
        );
    }
}

function mapStateToProps(state){
//    console.log('state', state);
    return ({players: state.players});
}

export default connect(mapStateToProps, { searchPlayers, getAllPlayers })(Players)