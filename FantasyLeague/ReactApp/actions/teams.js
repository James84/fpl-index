import axios from 'axios';

import { ROOT } from './players';

export const GET_ALL_TEAMS = 'GET_ALL_TEAMS';

export function getAllTeams() {
   const request = axios.get(`${ROOT}/search/teams/all`);
    
    return {
        type: GET_ALL_TEAMS,
        payload: request
    }
}