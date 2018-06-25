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
                { `${player.firstName} ${player.secondName}` }
            </div>
        );
    }
    
    render(){
        return (
            <div>
                {this.renderPlayer()}
            </div>
        );
    }
}

function mapStateToProps(state){
    return { player: state.player };
}

export default connect(mapStateToProps, { getPlayer })(Player);