import { SEARCH_PLAYERS, GET_ALL_PLAYERS } from '../actions/players';

export default function(state = [], action){
    
    switch(action.type){
        case SEARCH_PLAYERS:        
        case GET_ALL_PLAYERS:
            return action.payload.data;
        default:
            return state;
    }
    
    return state;
}