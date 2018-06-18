import React, { Component } from "react";
import PlayerRecord from "./playerRecord";
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
        console.log('playerProps', player)

        return (
            <tr key={player.id}>
                <td>{player.web_name}</td>
                <td>{player.team}</td>
            </tr>
        );
    }
    
    render() {
        return (
            <table>
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Team</th>
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