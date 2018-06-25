import { combineReducers } from 'redux';
import playersReducer from './players_reducer';
import playerReducer from './player_reducer';

const rootReducer = combineReducers({
    players: playersReducer,
    player: playerReducer
});

export default rootReducer;