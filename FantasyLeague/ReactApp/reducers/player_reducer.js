import { GET_PLAYER } from '../actions/players';

export default function(state = {}, action){
    
    switch(action.type){
        case GET_PLAYER:
            return action.payload.data;
    }
    
    return state;
}