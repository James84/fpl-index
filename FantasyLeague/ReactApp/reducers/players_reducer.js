import { SEARCH_PLAYERS } from '../actions/players';

export default function(state = [], action){
    
    switch(action.type){
        case SEARCH_PLAYERS:
            return action.payload.data;
    }
    
    return state;
}