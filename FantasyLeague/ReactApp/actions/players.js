import axios from 'axios';

export const SEARCH_PLAYERS = 'SEARCH_PLAYERS';
export const GET_PLAYER = 'GET_PLAYER';
export const GET_ALL_PLAYERS = 'GET_ALL_PLAYERS';

const ROOT = 'http://fantasy.league.local';
const SEARCH_URL = `${ROOT}/search/players`;

export function searchPlayers(lastName) {
    const url = `${ROOT}/search/players/prefix?lastname=${lastName}`;

    const request = axios.get(url);
        
    return {
        type: SEARCH_PLAYERS,
        payload: request
    };
}

export function getPlayer(id){
    const url = `${SEARCH_URL}/id/${id}`;
    
    const request = axios.get(url);
    
    return {
        type: GET_PLAYER,
        payload: request
    }
}

export function getAllPlayers(){
    const url = `${SEARCH_URL}/all?skip=0&take=50`;
    
    const request = axios.get(url);
    
    return {
        type: GET_ALL_PLAYERS,
        payload: request
    }
}