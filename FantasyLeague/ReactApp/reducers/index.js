import { combineReducers } from 'redux';
import playersReducer from './players_reducer';
import playerReducer from './player_reducer';
import teamsReducer from './teams_reducer';

const rootReducer = combineReducers({
    players: playersReducer,
    player: playerReducer,
    teams: teamsReducer
});

export default rootReducer;