import React, { Component } from "react";
import axios from "axios"

export default class Players extends Component {

    constructor(props) {
        super(props);
        this.state = { players: [] };

        const request = axios.get('https://localhost:44371/players/all').then(res => {
            this.setState({ players: res.data });
        });
    }
    
    renderPlayers(player){
//        console.log('playerProps', player)

        return (
            <tr key={player.id}>
                <td>{player.first_name}</td>
                <td>{player.second_name}</td>
                <td>{player.team}</td>
                <td>{player.squad_number}</td>
                <td>{player.total_points}</td>
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
                        this.state.players.map(this.renderPlayers)
                    }
                    </tbody>
                </table>
        );
    }
}