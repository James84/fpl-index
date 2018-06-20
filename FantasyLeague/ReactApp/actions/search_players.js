import axios from 'axios';

export const SEARCH_PLAYERS = 'SEARCH_PLAYERS';

export function searchPlayers(lastName) {
    const url = `http://fantasy.league.local/search/players/prefix?lastname=${lastName}`;
//    console.log('search player action called!');

    const request = axios.get(url);
        
    return {
        type: SEARCH_PLAYERS,
        payload: request
    };
}