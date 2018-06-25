import axios from 'axios';

export const SEARCH_PLAYERS = 'SEARCH_PLAYERS';
export const GET_PLAYER = 'GET_PLAYER';

const ROOT = 'http://fantasy.league.local';

export function searchPlayers(lastName) {
    const url = `${ROOT}/search/players/prefix?lastname=${lastName}`;
//    console.log('search player action called!');

    const request = axios.get(url);
        
    return {
        type: SEARCH_PLAYERS,
        payload: request
    };
}

export function getPlayer(id){
    const url = `${ROOT}/search/players/id/${id}`;
    
    const request = axios.get(url);
    
    console.log('player requested!');
    
    return {
        type: GET_PLAYER,
        payload: request
    }
}