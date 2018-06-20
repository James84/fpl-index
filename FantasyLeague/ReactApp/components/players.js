import React, { Component } from "react";
import { connect } from 'react-redux';
import { players } from '../reducers/index';

class Players extends Component {
    
    constructor(props) {
        super(props);
        
        this.renderPlayers = this.renderPlayers.bind(this);
    }
    
    getPlayer(){
        console.log('get player');
    }
    
    
    renderPlayers(player){
        //console.log('player', player);
        return (
            <tr onClick={this.getPlayer} key={player.id}>
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
                        this.props.players.map(this.renderPlayers)
                    }
                    </tbody>
                </table>
        );
    }
}

function mapDispatchToProps(state){
    console.log('state', state);
    return ({players: state.players});
}

export default connect(mapDispatchToProps)(Players)