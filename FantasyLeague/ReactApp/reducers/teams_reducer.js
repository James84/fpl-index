import { GET_ALL_TEAMS } from '../actions/teams';

export default function(state = [], action){
    switch(action.type){
        case GET_ALL_TEAMS:
            return action.payload.data;
        default:
            return state;
    }
    
    return state;
}