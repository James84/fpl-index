import React from 'react';

export default (props) => {
    const player = props.data;
    return (
        <div>
            <td>{player.name}</td>
            <td>{player.team}</td>
        </div>
    );
}